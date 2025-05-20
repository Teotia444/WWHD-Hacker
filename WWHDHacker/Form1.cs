using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TCPGeckoAromaLibrary;
using WWHDHacker.Properties;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using YamlDotNet.Core;
using System.Runtime.CompilerServices;
using YamlDotNet.Core.Tokens;
using System.Configuration;

namespace WWHDHacker
{
    public partial class Form1: Form
    {
        Dictionary<string, string> yamlMap;
        float storedLinkX;
        float storedLinkY;
        float storedLinkZ;
        int storedLinkAngle;
        DateTime lastDpadRight;
        DateTime lastFrameAdvance;
        bool doorCancelFromMacro;
        bool paused;

        DataViewer dataViewerControl;

        SeparateForm separate = new SeparateForm();
        DataViewer separateDataViewerControl;

        public (int, int) mainStickValues { get; set; }
        public (int, int) cStickValues { get; set; }
        public (float, float, float) linkCoordinates { get; set; }
        public int linkAngle { get; set; }
        public float linkSpeed { get; set; }

        public string stage { get; set; }
        public int roomId { get; set; }
        public int spawnId { get; set; }
        public int layer { get; set; }

        public List<string> selectedMapSubs;
        public bool favoriteMode;
        public bool favoriteText;
        public DateTime ftDate;

        public string settingsDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WWHDHacker");
        Dictionary<string, JsonInput> config;

        public static unsafe int FloatToHex(float f)
        {
            var i = *((int*)&f);
            string s = "0x" + i.ToString("X8");
            return Convert.ToInt32(s, 16);
        }


        public static TCPGecko tcpGecko = new TCPGecko();

        public Form1()
        {
            InitializeComponent();
            string yml = Encoding.ASCII.GetString(Resources.aroma);
            var deserializer = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build();


            Directory.CreateDirectory(settingsDir);
            if (!File.Exists(settingsDir + "\\Config.json"))
            {
                Dictionary<string, JsonInput> toadd = new Dictionary<string, JsonInput>()
                {
                    { "levitate", new JsonInput((int)InputEnum.L, value:64f)},
                    { "doorCancel", new JsonInput((int)InputEnum.DpadLeft)},
                    { "superswim", new JsonInput((int)InputEnum.DpadRight, value:500f)},
                    { "storage", new JsonInput((int)InputEnum.DpadDown)},
                    { "masterkey", new JsonInput((int)InputEnum.ZR)},
                    { "storePosition", new JsonInput((int)InputEnum.DpadRight, masterkey:true)},
                    { "restorePosition", new JsonInput((int)InputEnum.DpadLeft, masterkey:true)},
                    { "reloadRoom", new JsonInput((int)InputEnum.DpadDown, masterkey:true)},
                    { "refillMagic", new JsonInput((int)InputEnum.R, masterkey:true)},
                    { "refillHealth", new JsonInput((int)InputEnum.L, masterkey:true)},
                    { "refillAmmo", new JsonInput((int)InputEnum.DpadUp, masterkey:true)},
                    { "windDirection", new JsonInput((int)InputEnum.L3)},
                };

                string json = JsonConvert.SerializeObject(toadd, Formatting.Indented);
                File.WriteAllText(settingsDir + "\\Config.json", json);
                
            }
            config = JsonConvert.DeserializeObject<Dictionary<string, JsonInput>>(File.ReadAllText(settingsDir + "\\Config.json"));
            
            

            yamlMap = deserializer.Deserialize<Dictionary<string, string>>(yml);

            lToLevitateCheckbox.Checked = config["levitate"].enabled;
            doorCancelCheckbox.Checked = config["doorCancel"].enabled;
            superswimCheckbox.Checked = config["superswim"].enabled;
            storageCheckbox.Checked = config["storage"].enabled;
            masterkey.Checked = config["masterkey"].enabled;
            storeRestoreCheckbox.Checked = config["storePosition"].enabled;
            reloadRoomCheckbox.Checked = config["reloadRoom"].enabled;
            refillMagicCheckbox.Checked = config["refillMagic"].enabled;
            refillHealthCheckbox.Checked = config["refillHealth"].enabled;
            refillAmmoCheckbox.Checked = config["refillAmmo"].enabled;
            changeWindCheckbox.Checked = config["windDirection"].enabled;
            alternativeDpadRight.Checked = config["superswim"].alternative;
            alternativeMemfiles.Checked = config["storePosition"].alternative;

            levitateMK.Checked = config["levitate"].masterkey;
            doorCancelMK.Checked = config["doorCancel"].masterkey;
            superswimMK.Checked = config["superswim"].masterkey;
            storageMK.Checked = config["storage"].masterkey;
            
            saveReloadMK.Checked = config["storePosition"].masterkey;
            reloadRoomMK.Checked = config["reloadRoom"].masterkey;
            refillHealthMK.Checked = config["refillMagic"].masterkey;
            refillMagicMK.Checked = config["refillHealth"].masterkey;
            refillAmmoMK.Checked = config["refillAmmo"].masterkey;
            windDirectionMK.Checked = config["windDirection"].masterkey;
            

            foreach (GroupBox gb in miscFeaturesPanel.Controls.OfType<GroupBox>())
            {
                foreach (ComboBox item in gb.Controls.OfType<ComboBox>())
                {
                    foreach (InputEnum e in Enum.GetValues(typeof(InputEnum)).Cast<InputEnum>().ToArray())
                    {
                        item.Items.Add(e);
                    }
                    item.SelectedIndex = config[item.Name.Substring(0, item.Name.LastIndexOf("Combo"))].input;
                }
            }

            ipTextBox.Text = Properties.Settings.Default.wiiuIP;


            FormClosed += (object sender, FormClosedEventArgs e) => { if (tcpGecko.client != null) tcpGecko.Disconnect(); 
                string json = JsonConvert.SerializeObject(config, Formatting.Indented);
                File.WriteAllText(settingsDir + "\\Config.json", json); 
                Application.Exit(); };

            mainFeaturesPanel.Visible = true;
            miscFeaturesPanel.Visible = false;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = false;
            itemsManager.Visible = false;
            memfilesPanel.Visible = false;
            teleporterPanel.Visible = false;

            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(Panel))
                {
                    item.Enabled = false;
                }
            }

            typeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (string type in Enum.GetNames(typeof(TCPGecko.Datatype)))
            {
                typeDropdown.Items.Add(type);
            }
            dataViewerControl = new DataViewer(this);
            separateDataViewerControl = new DataViewer(this);
            dataViewerPanel.Controls.Add(dataViewerControl);
        }



        #region Top menu
        private void connect_Click(object sender, EventArgs e)
        {
            if (connect.Text == "Connect")
            {
                Properties.Settings.Default.wiiuIP = ipTextBox.Text;
                Properties.Settings.Default.Save();
                tcpGecko.Connect(ipTextBox.Text);
                timer1.Start();

                timer1.Interval = 10;
                CheckInv.Start();
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                connect.Text = "Disconnect";
                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(Panel))
                    {
                        item.Enabled = true;
                    }
                }
            }
            else
            {
                tcpGecko.Disconnect();
                CheckInv.Stop();
                timer1.Stop();
                connect.Text = "Connect";
                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(Panel))
                    {
                        item.Enabled = false;
                    }
                }
            }
        }

        private void mainFeatures_Click(object sender, EventArgs e)
        {
            mainFeaturesPanel.Visible = true;
            miscFeaturesPanel.Visible = false;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = false;
            itemsManager.Visible = false;
            memfilesPanel.Visible = false;
            teleporterPanel.Visible = false;
        }

        private void miscFeatures_Click(object sender, EventArgs e)
        {
            mainFeaturesPanel.Visible = false;
            miscFeaturesPanel.Visible = true;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = false;
            itemsManager.Visible = false;
            memfilesPanel.Visible = false;
            teleporterPanel.Visible = false;
        }

        private void dataViewer_Click(object sender, EventArgs e)
        {
            mainFeaturesPanel.Visible = false;
            miscFeaturesPanel.Visible = false;
            dataViewerPanel.Visible = true;
            advancedPanel.Visible = false;
            itemsManager.Visible = false;
            memfilesPanel.Visible = false;
            teleporterPanel.Visible = false;
        }

        private void advanced_Click(object sender, EventArgs e)
        {
            mainFeaturesPanel.Visible = false;
            miscFeaturesPanel.Visible = false;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = true;
            itemsManager.Visible = false;
            memfilesPanel.Visible = false;
            teleporterPanel.Visible = false;
        }

        private void itemManagerButton_Click(object sender, EventArgs e)
        {
            mainFeaturesPanel.Visible = false;
            miscFeaturesPanel.Visible = false;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = false;
            itemsManager.Visible = true;
            memfilesPanel.Visible = false;
            teleporterPanel.Visible = false;
        }

        private void memfilesManager_Click(object sender, EventArgs e)
        {
            mainFeaturesPanel.Visible = false;
            miscFeaturesPanel.Visible = false;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = false;
            itemsManager.Visible = false;
            memfilesPanel.Visible = true;
            teleporterPanel.Visible = false;
        }

        private void detachDataViewer_Click(object sender, EventArgs e)
        {
            separate.Controls.Clear();
            separate.Controls.Add(separateDataViewerControl);
            separate.Show();
        }

        private void teleporter_Click(object sender, EventArgs e)
        {
            mainFeaturesPanel.Visible = false;
            miscFeaturesPanel.Visible = false;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = false;
            itemsManager.Visible = false;
            memfilesPanel.Visible = false;
            teleporterPanel.Visible = true;
        }
        #endregion

        #region Main features

        #region Game
        private void softResetButton_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1098f293, 0x01);
        }

        private void reloadMapButton_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763fc, 0x1);
        }

        private void resetCollisionButton_Click(object sender, EventArgs e)
        {
            Cheats.RestoreCollision(tcpGecko);
        }

        #endregion

        #region Storage
        private void chestStorageButton_Click(object sender, EventArgs e)
        {
            Cheats.ChestStorage(tcpGecko, true);
        }

        private void doorCancelButton_Click(object sender, EventArgs e)
        {
            Cheats.DoorCancel(tcpGecko, true);
        }

        private void getStorageButton_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x10976543, 0x1);
        }

        private void removeStorageButton_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x10976543, 0x0);
        }


        #endregion

        #region Amounts
        private void refillHealthButton_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b501), out int maxHealth);
            if (maxHealth != 0)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b503, maxHealth);
            }
        }

        private void refillBombsButton_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b570), out int maxBombs);
            if (maxBombs != 0)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b56a, maxBombs);
            }
        }

        private void refillMagicButton_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b513), out int maxMagic);
            if (maxMagic != 0)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b514, maxMagic);
            }
        }

        private void refillArrowsButton_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b56f), out int maxArrows);
            if (maxArrows != 0)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b569, maxArrows);
            }
        }

        #endregion

        #region Link

        private void setHealthButton_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b503, (int)healthNumber.Value);
        }

        private void setMagicButton_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b514, (int)magicNumber.Value);
        }

        private void setAngleButton_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u16, 0x1096ef12, (int)angleNumber.Value);
        }

        private void setSpeedButton_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u32, 0x10976de4), out int link_ptr);
            tcpGecko.Poke(TCPGecko.Datatype.f32, link_ptr + 27156, FloatToHex((float)speedNumber.Value));
            tcpGecko.Poke(TCPGecko.Datatype.u16, 0x10976dfe, 900);
        }

        private void setSAButton_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096EF0A, FloatToHex((float)speedAngleNumber.Value));
        }

        private void setPositionButton_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef48, FloatToHex((float)xNumber.Value));
            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef4c, FloatToHex((float)yNumber.Value));
            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef50, FloatToHex((float)zNumber.Value));
        }

        private void storePositionButton_Click(object sender, EventArgs e)
        {
            float.TryParse(tcpGecko.Peek(TCPGecko.Datatype.f32, 0x1096ef48), out storedLinkX);
            float.TryParse(tcpGecko.Peek(TCPGecko.Datatype.f32, 0x1096ef4c), out storedLinkY);
            float.TryParse(tcpGecko.Peek(TCPGecko.Datatype.f32, 0x1096ef50), out storedLinkZ);
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u16, 0x1096ef12), out storedLinkAngle);

        }

        private void restorePositionButton_Click(object sender, EventArgs e)
        {
            Cheats.DoorCancel(tcpGecko, true);
            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef48, FloatToHex(storedLinkX));
            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef4c, FloatToHex(storedLinkY));
            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef50, FloatToHex(storedLinkZ));
            tcpGecko.Poke(TCPGecko.Datatype.u16, 0x1096ef12, storedLinkAngle);
            Cheats.DoorCancel(tcpGecko, false);
        }


        #endregion

        #region Macros
        private void triggerLoadingButton_Click(object sender, EventArgs e)
        {
            byte[] array = new byte[stageNameLoader.TextLength];
            array = Encoding.ASCII.GetBytes(stageNameLoader.Text);
            byte b = byte.Parse(roomIdLoader.Text);
            byte b2 = Convert.ToByte(spawnIdLoader.Text, 16);
            byte b3 = Convert.ToByte(layerLoader.Text, 16);
            for (int i = 0; i < stageNameLoader.TextLength; i++)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763F0 + i, array[i]);
            }
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763F0 + stageNameLoader.TextLength, 0x0);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763FA, b);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763F9, b2);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763FB, b3);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763FC, 1);
        }

        #endregion

        #region Fetchers

        private void fetchAngle_Click(object sender, EventArgs e)
        {
            angleNumber.Value = linkAngle;
        }

        private void fetchSpeed_Click(object sender, EventArgs e)
        {
            speedNumber.Value = (decimal)linkSpeed;
        }

        private void fetchSA_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u16, 0x1096EF0A), out int sa);
            speedAngleNumber.Value = sa;
        }

        private void fetchX_Click(object sender, EventArgs e)
        {
            xNumber.Value = (decimal)linkCoordinates.Item1;
        }

        private void fetchY_Click(object sender, EventArgs e)
        {
            yNumber.Value = (decimal)linkCoordinates.Item2;
        }

        private void fetchZ_Click(object sender, EventArgs e)
        {
            zNumber.Value = (decimal)linkCoordinates.Item3;
        }

        private void fetchAllLink_Click(object sender, EventArgs e)
        {
            angleNumber.Value = linkAngle;
            speedNumber.Value = (decimal)linkSpeed;
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u16, 0x1096EF0A), out int sa);
            speedAngleNumber.Value = sa;
            xNumber.Value = (decimal)linkCoordinates.Item1;
            yNumber.Value = (decimal)linkCoordinates.Item2;
            zNumber.Value = (decimal)linkCoordinates.Item3;
        }

        private void fetchStage_Click(object sender, EventArgs e)
        {
            stageNameLoader.Text = stage;
        }

        private void fetchRoomId_Click(object sender, EventArgs e)
        {
            roomIdLoader.Text = roomId.ToString();
        }

        private void fetchSpawnId_Click(object sender, EventArgs e)
        {
            spawnIdLoader.Text = spawnId.ToString();
        }

        private void fetchLayer_Click(object sender, EventArgs e)
        {
            layerLoader.Text = layer.ToString();
        }

        private void fetchAllTeleport_Click(object sender, EventArgs e)
        {
            stageNameLoader.Text = stage;
            roomIdLoader.Text = roomId.ToString();
            spawnIdLoader.Text = spawnId.ToString();
            layerLoader.Text = layer.ToString();
        }

        #endregion

        #endregion

        #region Misc features

        #region Checkboxes
        private void lToLevitateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            config["levitate"].enabled = lToLevitateCheckbox.Enabled;
        }

        private void doorCancelCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            config["doorCancel"].enabled = doorCancelCheckbox.Checked;
            
        }

        private void superswimCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            config["superswim"].enabled = superswimCheckbox.Checked;
            
        }
        private void storageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            config["storage"].enabled = storageCheckbox.Checked;
            
        }

        private void masterkey_CheckedChanged(object sender, EventArgs e)
        {
            config["masterkey"].enabled = masterkey.Checked;
            
        }

        private void storeRestoreCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            config["storePosition"].enabled = storeRestoreCheckbox.Checked;
            config["restorePosition"].enabled = storeRestoreCheckbox.Checked;
            
        }

        private void reloadRoomCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            config["reloadRoom"].enabled = reloadRoomCheckbox.Checked;
            
        }

        private void refillMagicCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            config["refillMagic"].enabled = refillMagicCheckbox.Checked;
            
        }

        private void refillHealthCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            config["refillHealth"].enabled = refillHealthCheckbox.Checked;
            
        }

        private void refillAmmoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            config["refillAmmo"].enabled = refillAmmoCheckbox.Checked;
            
        }

        private void changeWindCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            config["windDirection"].enabled = changeWindCheckbox.Checked;
            
        }

        private void alternativeDpadRight_CheckedChanged(object sender, EventArgs e)
        {
            config["superswim"].alternative = alternativeDpadRight.Checked;
            
        }

        private void alternativeMemfiles_CheckedChanged(object sender, EventArgs e)
        {
            config["storePosition"].alternative = alternativeMemfiles.Checked;
            config["restorePosition"].alternative = alternativeMemfiles.Checked;
            
        }

        private void levitateMK_CheckedChanged(object sender, EventArgs e)
        {
            config["levitate"].masterkey = levitateMK.Checked;
        }

        private void doorCancelMK_CheckedChanged(object sender, EventArgs e)
        {
            config["doorCancel"].masterkey = doorCancelMK.Checked;
        }

        private void superswimMK_CheckedChanged(object sender, EventArgs e)
        {
            config["superswim"].masterkey = superswimMK.Checked;
        }

        private void storageMK_CheckedChanged(object sender, EventArgs e)
        {
            config["storage"].masterkey = storageMK.Checked;
        }

        private void windDirectionMK_CheckedChanged(object sender, EventArgs e)
        {
            config["windDirection"].masterkey = windDirectionMK.Checked;
        }

        private void saveReloadMK_CheckedChanged(object sender, EventArgs e)
        {
            config["storePosition"].masterkey = saveReloadMK.Checked;
            config["restorePosition"].masterkey = saveReloadMK.Checked;
        }

        private void reloadRoomMK_CheckedChanged(object sender, EventArgs e)
        {
            config["reloadRoom"].masterkey = reloadRoomMK.Checked;
        }

        private void refillHealthMK_CheckedChanged(object sender, EventArgs e)
        {
            config["refillHealth"].masterkey = refillHealthMK.Checked;
        }

        private void refillMagicMK_CheckedChanged(object sender, EventArgs e)
        {
            config["refillMagic"].masterkey = refillMagicMK.Checked;
        }

        private void refillAmmoMK_CheckedChanged(object sender, EventArgs e)
        {
            config["refillAmmo"].masterkey = refillAmmoMK.Checked;
        }
        #endregion

        #region Combos
        private void levitateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config["levitate"].input = levitateCombo.SelectedIndex;
            config["levitate"].masterkey = levitateMK.Checked;
        }

        private void doorCancelCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config["doorCancel"].input = doorCancelCombo.SelectedIndex;
            config["doorCancel"].masterkey = doorCancelMK.Checked;
        }

        private void superspeedCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config["superswim"].input = superswimCombo.SelectedIndex;
            config["superswim"].masterkey = superswimMK.Checked;
            
        }

        private void storageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config["storage"].input = storageCombo.SelectedIndex;
            config["storage"].masterkey = storageMK.Checked;
            
        }

        private void windDirectionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config["windDirection"].input = windDirectionCombo.SelectedIndex;
            config["windDirection"].masterkey = windDirectionMK.Checked;
            
        }

        private void masterkeyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config["masterkey"].input = masterkeyCombo.SelectedIndex;
            
        }

        private void savePosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config["storePosition"].input = storePositionCombo.SelectedIndex;
            config["storePosition"].masterkey = saveReloadMK.Checked;
            
        }

        private void reloadPosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config["restorePosition"].input = restorePositionCombo.SelectedIndex;
            config["restorePosition"].masterkey = saveReloadMK.Checked;
        }

        private void reloadRoomCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config["reloadRoom"].input = reloadRoomCombo.SelectedIndex;
            config["reloadRoom"].masterkey = reloadRoomMK.Checked;
            
        }

        private void refillHealthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config["refillHealth"].input = refillHealthCombo.SelectedIndex;
            config["refillHealth"].masterkey = refillHealthMK.Checked;
            
        }

        private void refillMagicCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config["refillMagic"].input = refillMagicCombo.SelectedIndex;
            config["refillMagic"].masterkey = refillMagicMK.Checked;

        }

        private void refillAmmoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            config["refillAmmo"].input = refillAmmoCombo.SelectedIndex;
            config["refillAmmo"].masterkey = refillAmmoMK.Checked;

        }
        #endregion

        private void infBombs_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b56f, 0xFF);
        }

        private void infArrows_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b570, 0xFF);
        }

        private void magic80_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b513, 128);
        }

        private void fullHealth_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b501, 0x80);
        }

        private void fullCapacities_Click(object sender, EventArgs e)
        {
            //magic
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b513, 32);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b514, 32);
            //arrows
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b56f, 99);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b569, 99);
            //bombs
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b570, 99);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b56a, 99);
        }
        private void giveAllSongs_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b5bd, 0x3F);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if(paused && lastFrameAdvance + TimeSpan.FromMilliseconds(100) < DateTime.Now)
            {
                tcpGecko.AdvanceExec();
                lastFrameAdvance = DateTime.Now;
            }
        }

        private void pauseGame_Click(object sender, EventArgs e)
        {
            paused = true;
            tcpGecko.PauseExec();
        }

        private void resumeGame_Click(object sender, EventArgs e)
        {
            paused = false;
            tcpGecko.ResumeExec();
        }

        private void refreshAS_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506bb24 + 0x2D), out int animSetByte);
            currentAnimSet.Text = "Current anim set : Anim set " + (((animSetByte | 0b0000_0001) == animSetByte) ? "2" : "1");
        }

        private void animSet1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506bb24 + 0x2D), out int animSetByte);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506bb24 + 0x2D, (animSetByte & ~0b0000_0001));
            currentAnimSet.Text = "Current anim set : Anim set 1";
        }

        private void animSet2_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506bb24 + 0x2D), out int animSetByte);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506bb24 + 0x2D, (animSetByte | 0b0000_0001));
            currentAnimSet.Text = "Current anim set : Anim set 2";
        }

        #endregion

        #region Data viewer



        #endregion

        #region Advanced features
        private void peekButton_Click(object sender, EventArgs e)
        {
            if (typeDropdown.SelectedIndex != 3)
            {
                Int32.TryParse(tcpGecko.Peek((TCPGecko.Datatype)typeDropdown.SelectedIndex, Convert.ToInt32(memoryAddress.Text, 16)), out int v);
                valueTextbox.Text = $"0x{v:X}";
            }
            else
            {
                float.TryParse(tcpGecko.Peek((TCPGecko.Datatype)typeDropdown.SelectedIndex, Convert.ToInt32(memoryAddress.Text, 16)), out float fv);
                valueTextbox.Text = fv.ToString();
            }
        }

        private void pokeButton_Click(object sender, EventArgs e)
        {
            if (typeDropdown.SelectedIndex != 3)
            {
                tcpGecko.Poke((TCPGecko.Datatype)typeDropdown.SelectedIndex, Convert.ToInt32(memoryAddress.Text, 16), Convert.ToInt32(valueTextbox.Text, 16));
            }
            else
            {
                tcpGecko.Poke((TCPGecko.Datatype)typeDropdown.SelectedIndex, Convert.ToInt32(memoryAddress.Text, 16), FloatToHex(float.Parse(valueTextbox.Text)));
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, Slot.GetAll()[slotList.SelectedIndex].address, Item.GetAll()[itemList.SelectedIndex].value);
        }
        private void removeItem_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, Slot.GetAll()[slotList.SelectedIndex].address, 0x00);
        }
        #endregion

        #region Items manager
        private void giveAll_Click(object sender, EventArgs e)
        {
            foreach (CheckBoxImage item in itemsPanel.Controls)
            {
                item.Index = item.Max;
            }

        }

        private void setHC_Click(object sender, EventArgs e)
        {
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b501, (int)setHCValue.Value * 4);
        }
        #endregion

        #region Teleporter

        private void teleporterMap_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            int mapIndex = coordinates.X / (teleporterMap.Size.Width / 7) + coordinates.Y / (teleporterMap.Size.Height / 7) * 7;
            mapIndex++;
            if (me.Button == MouseButtons.Left)
            {

                islandLabel.Text = "Island : " + Stages.islands[mapIndex - 1].usingName;
                byte[] array = new byte["sea".Length];

                array = Encoding.ASCII.GetBytes("sea");
                byte b = byte.Parse(mapIndex.ToString());
                byte b2 = Convert.ToByte(teleporterSpawnId.Text, 16);
                byte b3 = Convert.ToByte(teleporterLayer.Text, 16);
                for (int i = 0; i < "sea".Length; i++)
                {
                    tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763F0 + i, array[i]);
                }
                tcpGecko.PokeMultiple(TCPGecko.Datatype.u8, new int[] { 0x109763F0 + 3, 0x109763FA, 0x109763F9, 0x109763FB, 0x109763FC }, new int[] { 0x0, b, b2, b3, 1 });
            }
            else if (me.Button == MouseButtons.Right)
            {
                favoriteMode = false;
                subAreas.Controls.Clear();
                foreach (string key in yamlMap.Keys)
                {
                    if (key.StartsWith(Stages.islands[mapIndex - 1].usingName) || key.StartsWith("Inside " + Stages.islands[mapIndex - 1].usingName))
                    {
                        Label element = new Label();
                        element.Text = key;
                        element.MinimumSize = new Size(200, 5);
                        element.MaximumSize = new Size(200, 20);
                        element.Click += ListTeleportHandler;
                        subAreas.Controls.Add(element);
                    }
                    switch (Stages.islands[mapIndex - 1].dungeonId) {
                        case 0:
                            break;
                        case 1: // drc
                            if (key.Contains("Dragon Roost Cavern"))
                            {
                                Label element = new Label();
                                element.Text = key;
                                element.MinimumSize = new Size(200, 5);
                                element.MaximumSize = new Size(200, 20);
                                element.Click += ListTeleportHandler;
                                subAreas.Controls.Add(element);
                            }
                            break;
                        case 2: // fw
                            if (key.Contains("Forbidden Woods"))
                            {
                                Label element = new Label();
                                element.Text = key;
                                element.MinimumSize = new Size(200, 5);
                                element.MaximumSize = new Size(200, 20);
                                element.Click += ListTeleportHandler;
                                subAreas.Controls.Add(element);
                            }
                            break;
                        case 3: // totg
                            if (key.Contains("Tower of Gods"))
                            {
                                Label element = new Label();
                                element.Text = key;
                                element.MinimumSize = new Size(200, 5);
                                element.MaximumSize = new Size(200, 20);
                                element.Click += ListTeleportHandler;
                                subAreas.Controls.Add(element);
                            }
                            break;
                        case 4: // ff is already treated as an individual island
                            
                            break;
                        case 5: // et
                            if (key.Contains("Earth Temple"))
                            {
                                Label element = new Label();
                                element.Text = key;
                                element.MinimumSize = new Size(200, 5);
                                element.MaximumSize = new Size(200, 20);
                                element.Click += ListTeleportHandler;
                                subAreas.Controls.Add(element);
                            }
                            break;
                        case 6: // wt
                            if (key.Contains("Wind Temple"))
                            {
                                Label element = new Label();
                                element.Text = key;
                                element.MinimumSize = new Size(200, 5);
                                element.MaximumSize = new Size(200, 20);
                                element.Click += ListTeleportHandler;
                                subAreas.Controls.Add(element);
                            }
                            break;
                        case 7: // hyrule
                            if (key.Contains("Hyrule") || key.StartsWith("Ganon"))
                            {
                                Label element = new Label();
                                element.Text = key;
                                element.MinimumSize = new Size(200, 5);
                                element.MaximumSize = new Size(200, 20);
                                element.Click += ListTeleportHandler;
                                subAreas.Controls.Add(element);
                            }
                            break;

                    }
                }
            }
        }

        private void ListTeleportHandler(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Label a = (Label)sender;
            string stage = yamlMap[a.Text];
            if (me.Button == MouseButtons.Left)
            {

                byte[] array = new byte[stage.Length];

                array = Encoding.ASCII.GetBytes(stage);
                byte b = byte.Parse(teleporterRoomId.Text);
                byte b2 = Convert.ToByte(teleporterSpawnId.Text, 16);
                byte b3 = Convert.ToByte(teleporterLayer.Text, 16);
                for (int i = 0; i < stage.Length; i++)
                {
                    tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763F0 + i, array[i]);
                }
                tcpGecko.PokeMultiple(TCPGecko.Datatype.u8, new int[] { 0x109763F0 + stage.Length, 0x109763FA, 0x109763F9, 0x109763FB, 0x109763FC }, new int[] { 0x0, b, b2, b3, 1 });
            }
            else if (me.Button == MouseButtons.Right)
            {
                
                if (!Properties.Settings.Default.favorites.Contains(a.Text))
                {
                    
                    Properties.Settings.Default.favorites.Add(a.Text);
                    Properties.Settings.Default.Save();
                    addedRemoved.ForeColor = Color.Green;
                    favoriteText = true;
                    ftDate = DateTime.Now;
                    addedRemoved.Text = "Added " + a.Text + " as favorite";
                }
                else
                {
                    
                    Properties.Settings.Default.favorites.Remove(a.Text);
                    Properties.Settings.Default.Save();
                    if(favoriteMode) teleporterToggleFavorites_Click(sender, e);
                    addedRemoved.ForeColor = Color.Red;
                    favoriteText = true;
                    ftDate = DateTime.Now;
                    addedRemoved.Text = "Removed " + a.Text + " from favorite";

                }
            }
        }


        private void teleporterMap_MouseLeave(object sender, EventArgs e)
        {
            islandLabel.Text = "No island selected";
        }

        private void teleporterMap_MouseMove(object sender, MouseEventArgs e)
        {

            Point coordinates = teleporterMap.PointToClient(System.Windows.Forms.Cursor.Position);
            int mapIndex = coordinates.X / (teleporterMap.Size.Width / 7) + coordinates.Y / (teleporterMap.Size.Height / 7) * 7;
            if (mapIndex < 49) islandLabel.Text = "Island : " + Stages.islands[mapIndex].usingName;
        }

        private void teleporterToggleHyrule_Click(object sender, EventArgs e)
        {
            favoriteMode = false;
            subAreas.Controls.Clear();
            foreach (var key in yamlMap.Keys)
            {
                if (key.Contains("Hyrule") || key.StartsWith("Ganon"))
                {
                    Label element = new Label();
                    element.Text = key;
                    element.MinimumSize = new Size(200, 5);
                    element.MaximumSize = new Size(200, 15);
                    element.Click += ListTeleportHandler;
                    subAreas.Controls.Add(element);
                }
            }

        }

        private void teleporterToggleFavorites_Click(object sender, EventArgs e)
        {
            favoriteMode = true;
            subAreas.Controls.Clear();
            foreach (string key in Properties.Settings.Default.favorites)
            {
                Label element = new Label();
                element.Text = key;
                element.MinimumSize = new Size(200, 5);
                element.MaximumSize = new Size(200, 15);
                element.Click += ListTeleportHandler;
                subAreas.Controls.Add(element);
            }
        }

        #endregion

        #region Timers
        private void CheckInv_Tick(object sender, EventArgs e)
        {
            
            if (infAir.Checked)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u16, 0x10976dfe, 1200);
            }
            if (infHealth.Checked)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b503, 100);
            }
            if (infMagic.Checked)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b514, 40);
            }

            if (itemsManager.Visible != true || !autoupdateTracker.Checked)
            {
                return;
            }
            foreach (CheckBoxImage item in itemsPanel.Controls)
            {
                Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, item.itemsList[0].slot.address), out int value);
                bool found = false;
                switch (item.itemsList[0].@enum)
                {
                    case ItemEnum.WindsRequiem:
                    case ItemEnum.BalladOfGales:
                    case ItemEnum.CommandMelody:
                    case ItemEnum.EarthGodLyric:
                    case ItemEnum.WindGodAria:
                    case ItemEnum.SongOfPassing:
                    case ItemEnum.NayrusPearl:
                    case ItemEnum.DinsPearl:
                    case ItemEnum.FaroresPearl:
                        int shift = (int)Math.Log(item.itemsList[1].value, 2);
                        if (((value >> shift) & 1) != 0)
                        {
                            found = true;
                            item.Index = 1;
                        }
                        break;
                    default:
                        for (int i = 1; i < item.itemsList.Count; i++)
                        {
                            if (item.itemsList[i].value == value)
                            {
                                found = true;
                                item.Index = i;
                            }
                        }
                        break;
                }
                if (!found)
                {
                    item.Index = 0;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (ftDate + TimeSpan.FromMilliseconds(5000) < DateTime.Now && favoriteText)
            {
                favoriteText = false;
                addedRemoved.Text = "";
            }

            int[] addresses = new int[]
            {
                0x102F48A8,
                0x102F48B4,
                0x102F48B8,
                0x102F48BC,
                0x102F48C0,
                0x1096ef48,
                0x1096ef4c,
                0x1096ef50,
                0x1096ef12,
                0
            };
            
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u32, 0x10976de4), out int link_ptr);
            addresses[9] = (link_ptr + 27156);
            var raw = tcpGecko.PeekMultiple(TCPGecko.Datatype.u32, addresses);
            addresses = new int[]
            {
                0x109763E4,
                0x109763E5,
                0x109763E6,
                0x109763E7,
                0x109763E8,
                0x109763E9,
                0x109763EA,
                0x109763EB,
                0x109763EC,
                0x10978CF8,
                0x109763ED,
                0x109763EF,
            };
            var stageInfo = tcpGecko.PeekMultiple(TCPGecko.Datatype.u8, addresses);

            if (raw.Count < 10) return;
            Int32.TryParse(raw[0], out int inputs);
            mainStickValues = ((int)(BitConverter.ToSingle(BitConverter.GetBytes((Int32)UInt32.Parse(raw[1])), 0) * 128), (int)(BitConverter.ToSingle(BitConverter.GetBytes((Int32)UInt32.Parse(raw[2])), 0) * 128));
            cStickValues = ((int)(BitConverter.ToSingle(BitConverter.GetBytes((Int32)UInt32.Parse(raw[3])), 0) * 128), (int)(BitConverter.ToSingle(BitConverter.GetBytes((Int32)UInt32.Parse(raw[4])), 0) * 128));
            linkCoordinates = ((BitConverter.ToSingle(BitConverter.GetBytes(UInt32.Parse(raw[5])), 0)),
                (BitConverter.ToSingle(BitConverter.GetBytes(UInt32.Parse(raw[6])), 0)),
                (BitConverter.ToSingle(BitConverter.GetBytes(UInt32.Parse(raw[7])), 0)));

            linkAngle = (int)(UInt32.Parse(raw[8]) >> 16);
            linkSpeed = BitConverter.ToSingle(BitConverter.GetBytes(UInt32.Parse(raw[9])), 0);




            if (stageInfo.Count < 11) return;
            stage = Encoding.ASCII.GetString(new byte[]{
                    BitConverter.GetBytes(UInt32.Parse(stageInfo[0]))[0],
                    BitConverter.GetBytes(UInt32.Parse(stageInfo[1]))[0],
                    BitConverter.GetBytes(UInt32.Parse(stageInfo[2]))[0],
                    BitConverter.GetBytes(UInt32.Parse(stageInfo[3]))[0],
                    BitConverter.GetBytes(UInt32.Parse(stageInfo[4]))[0],
                    BitConverter.GetBytes(UInt32.Parse(stageInfo[5]))[0],
                    BitConverter.GetBytes(UInt32.Parse(stageInfo[6]))[0],
                    BitConverter.GetBytes(UInt32.Parse(stageInfo[7]))[0],
            });

            roomId = int.Parse(stageInfo[9]);
            spawnId = int.Parse(stageInfo[10]);
            layer = int.Parse(stageInfo[8]);

            //l
            if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["levitate"].input)) &&
                (config["levitate"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["masterkey"].input))) 
                && lToLevitateCheckbox.Checked)
            {
                Cheats.LToLevitate(tcpGecko, config["levitate"].value);
            }
            
            //left dpad
            if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["doorCancel"].input)) &&
                (config["doorCancel"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["masterkey"].input)))
                && doorCancelCheckbox.Checked)
            {
                Cheats.DoorCancel(tcpGecko, true);
                doorCancelFromMacro = true;
            }
            else if (doorCancelFromMacro)
            {
                Cheats.DoorCancel(tcpGecko, false);
                doorCancelFromMacro = false;
            }



            //right dpad
            if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["superswim"].input)) &&
                (config["superswim"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["masterkey"].input)))
                && superswimCheckbox.Checked && 
                lastDpadRight + TimeSpan.FromMilliseconds(100) < DateTime.Now)
            {
                bool zlHeld = Inputs.isPressed(inputs, Inputs.zlButton) || !config["superswim"].alternative;
                Cheats.Superswim(tcpGecko, config["superswim"].value, linkSpeed, zlHeld, link_ptr);

                lastDpadRight = DateTime.Now;
            }

            //down dpad 
            if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["storage"].input)) &&
                (config["storage"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["masterkey"].input)))
                && storageCheckbox.Checked)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, 0x10976543, 0x1);
            }
            //l3
            if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["windDirection"].input)) &&
                (config["windDirection"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["masterkey"].input)))
                && storageCheckbox.Checked)
            {
                Cheats.ChangeWindDir(tcpGecko);
            }

            //l + zr
            if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["refillHealth"].input)) &&
                (config["refillHealth"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["masterkey"].input)))
                && refillHealthCheckbox.Checked)
            {
                Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b501), out int maxHealth);
                if (maxHealth != 0)
                {
                    tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b503, maxHealth);
                }
            }

            //r + zr
            if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["refillMagic"].input)) &&
                (config["refillMagic"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["masterkey"].input)))
                && refillMagicCheckbox.Checked)
            {
                Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b513), out int maxMagic);
                if (maxMagic != 0)
                {
                    tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b514, maxMagic);
                }
            }

            //dpad up + zr
            if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["refillAmmo"].input)) &&
                (config["refillAmmo"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["masterkey"].input)))
                && refillAmmoCheckbox.Checked)
            {
                Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b56f), out int maxArrows);
                if (maxArrows != 0)
                {
                    tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b569, maxArrows);
                }

                Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b570), out int maxBombs);
                if (maxBombs != 0)
                {
                    tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b56a, maxBombs);
                }
            }

            //dpad down + zr
            if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["reloadRoom"].input)) &&
                (config["reloadRoom"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["masterkey"].input)))
                && reloadRoomCheckbox.Checked)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763fc, 0x1);
            }

            //dpad left + zr
            if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["restorePosition"].input)) &&
                (config["restorePosition"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["masterkey"].input)))
                && (storedLinkX != 0 || storedLinkY != 0 || storedLinkZ != 0) 
                && storeRestoreCheckbox.Checked)
            {
                Cheats.DoorCancel(tcpGecko, true);
                tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef48, FloatToHex(storedLinkX));
                tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef4c, FloatToHex(storedLinkY));
                tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef50, FloatToHex(storedLinkZ));
                tcpGecko.Poke(TCPGecko.Datatype.u16, 0x1096ef12, storedLinkAngle);
                Cheats.DoorCancel(tcpGecko, false);
            }

            //dpad right + zr
            if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["storePosition"].input)) &&
                (config["storePosition"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)config["masterkey"].input)))
                && storeRestoreCheckbox.Checked)
            {
                float.TryParse(tcpGecko.Peek(TCPGecko.Datatype.f32, 0x1096ef48), out storedLinkX);
                float.TryParse(tcpGecko.Peek(TCPGecko.Datatype.f32, 0x1096ef4c), out storedLinkY);
                float.TryParse(tcpGecko.Peek(TCPGecko.Datatype.f32, 0x1096ef50), out storedLinkZ);
                Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u16, 0x1096ef12), out storedLinkAngle);
            }
            
            

            if (Inputs.isNotPressed(inputs, Inputs.enumToInput((InputEnum)config["doorCancel"].input))
                && doorCancelFromMacro)
            {
                Cheats.RestoreCollision(tcpGecko);
                doorCancelFromMacro = false;
            }
            

            dataViewerControl.RefreshSticks();
            separateDataViewerControl.RefreshSticks();
            dataViewerControl.RefreshInputs(inputs);
            separateDataViewerControl.RefreshInputs(inputs);

            if (stage.StartsWith("sea"))
            {
                int mapQuadrant = Math.Min(Math.Max((int)(linkCoordinates.Item1 + 340000) / (680000 / 7), 0), 6) + 7 * (int)Math.Min(Math.Max((int)(linkCoordinates.Item3 + 340000) / (680000 / 7), 0), 6);
                linkLocationLabel.Text = Stages.islands[mapQuadrant].usingName;
                movingLink.Visible = displayOnMap.Checked;
                movingLink.Location = new Point((int)(((linkCoordinates.Item1 + 340000) /680000)*transparentLayer.Width) - movingLink.Width / 2, (int)(((linkCoordinates.Item3 + 340000) / 680000) * transparentLayer.Height) - movingLink.Height / 2);
            }
            else
            {
                movingLink.Visible = false;
                bool found = false;
                foreach (var item in yamlMap.Keys)
                {
                    if (stage.Split(new[] { '\0' }, 2)[0] == yamlMap[item]){
                        linkLocationLabel.Text = item;
                        found = true;
                        break;
                    }

                }
                if (!found) linkLocationLabel.Text = "Unknown";
                

            }
        }



        #endregion
    }

    //Class for having images that act as checkboxes 
    public class CheckBoxImage : PictureBox
    {
        private int cindex;
        private ItemEnum t;
        private int max;

        public List<Item> itemsList = new List<Item>();

        public int Max
        {
            get
            {
                return max;
            }
            set
            {
                max = value;
            }
        }

        public ItemEnum SelectedItem
        {
            get
            {
                return t;
            }
            set
            {
                itemsList.Clear();
                foreach (Item item in Item.GetAll())
                {
                    if (item.@enum == value)
                    {
                        if(itemsList.Count == 0)
                        {
                            switch (value)
                            {
                                case ItemEnum.BombBag:
                                case ItemEnum.Quiver:
                                    itemsList.Add(Item.Instance(item.slot, 30, item.name, item.@enum, false));
                                    break;
                                case ItemEnum.Sword:
                                case ItemEnum.Shield:
                                    itemsList.Add(Item.Instance(item.slot, 0xFF, item.name, item.@enum, false));
                                    break;
                                case ItemEnum.WindsRequiem:
                                case ItemEnum.BalladOfGales:
                                case ItemEnum.CommandMelody:
                                case ItemEnum.EarthGodLyric:
                                case ItemEnum.WindGodAria:
                                case ItemEnum.SongOfPassing:
                                case ItemEnum.NayrusPearl:
                                case ItemEnum.DinsPearl:
                                case ItemEnum.FaroresPearl:
                                    itemsList.Add(Item.Instance(item.slot, item.value, item.name, item.@enum, false));
                                    break;
                                default:
                                    itemsList.Add(Item.Instance(item.slot, 0x00, item.name, item.@enum, false));
                                    break;
                            }
                            
                        }
                        itemsList.Add(item);
                    }
                }
                if(itemsList.Count == 0)
                {
                    Image = (Bitmap)Resources.ResourceManager.GetObject("TelescopeUnchecked");
                    t = value;
                    return;
                }
                Image = (Bitmap)Resources.ResourceManager.GetObject(itemsList[0].name + "Unchecked");
                t = value;
                max = itemsList.Count - 1;
            }
        }

        public int Index
        {
            get
            {
                return cindex;
            }
            set
            {
                cindex = value;
                if (cindex >= itemsList.Count || cindex < 0)
                {
                    cindex = 0;
                    if (itemsList.Count == 0)
                    {
                        Image = (Bitmap)Resources.ResourceManager.GetObject("TelescopeUnchecked");
                        return;
                    }
                }
                if(cindex == 0)
                {
                    Image = (Bitmap)Resources.ResourceManager.GetObject(itemsList[cindex].name + "Unchecked");
                    switch (itemsList[cindex].@enum)
                    {
                        case ItemEnum.WindsRequiem:
                        case ItemEnum.BalladOfGales:
                        case ItemEnum.CommandMelody:
                        case ItemEnum.EarthGodLyric:
                        case ItemEnum.WindGodAria:
                        case ItemEnum.SongOfPassing:
                        case ItemEnum.NayrusPearl:
                        case ItemEnum.DinsPearl:
                        case ItemEnum.FaroresPearl:
                            Int32.TryParse(Form1.tcpGecko.Peek(TCPGecko.Datatype.u8, itemsList[cindex].slot.address), out int v);
                            Form1.tcpGecko.Poke(TCPGecko.Datatype.u8, itemsList[cindex].slot.address, v & ~itemsList[cindex].value);
                            break;
                        case ItemEnum.MagicMeter:
                            Int32.TryParse(Form1.tcpGecko.Peek(TCPGecko.Datatype.u8, itemsList[cindex].slot.address), out int maxMagic);
                            if (itemsList[cindex].value > 0 && maxMagic > 32) break;
                            Form1.tcpGecko.Poke(TCPGecko.Datatype.u8, itemsList[cindex].slot.address, itemsList[cindex].value);
                            break;
                        default:
                            Form1.tcpGecko.Poke(TCPGecko.Datatype.u8, itemsList[cindex].slot.address, itemsList[cindex].value);
                            break;
                    }
                    return;
                }

                Image = (Bitmap)Resources.ResourceManager.GetObject(itemsList[cindex].name + "Checked");
                switch (itemsList[cindex].@enum)
                {
                    case ItemEnum.WindsRequiem:
                    case ItemEnum.BalladOfGales:
                    case ItemEnum.CommandMelody:
                    case ItemEnum.EarthGodLyric:
                    case ItemEnum.WindGodAria:
                    case ItemEnum.SongOfPassing:
                    case ItemEnum.NayrusPearl:
                    case ItemEnum.DinsPearl:
                    case ItemEnum.FaroresPearl:
                        Int32.TryParse(Form1.tcpGecko.Peek(TCPGecko.Datatype.u8, itemsList[cindex].slot.address), out int v);
                        Form1.tcpGecko.Poke(TCPGecko.Datatype.u8, itemsList[cindex].slot.address, v | itemsList[cindex].value);
                        break;
                    default:
                        Form1.tcpGecko.Poke(TCPGecko.Datatype.u8, itemsList[cindex].slot.address, itemsList[cindex].value);
                        break;
                }
            }
        }

        public CheckBoxImage()
        {
            Cursor = Cursors.Hand;
            Click += (sender, e) => {if(Form1.tcpGecko.connected) Index = (((MouseEventArgs)e).Button == MouseButtons.Left ? 1 : -1) * 1 + Index; };
            DoubleClick += (sender, e) => { if (Form1.tcpGecko.connected) Index = (((MouseEventArgs)e).Button == MouseButtons.Left ? 1 : -1) * 1 + Index; };
        }
    }
}
