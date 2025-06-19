using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TCPGeckoAromaLibrary;
using WWHDHacker.Properties;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using Octokit;
using System.Threading.Tasks;
using System.Security.AccessControl;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.CompilerServices;

namespace WWHDHacker
{
    public partial class Form1: Form
    {
        // paused : 0x106EC269

        static Version local = new Version("1.0.1");

        public static Dictionary<string, string> yamlMap;
        
        float storedLinkX;
        float storedLinkY;
        float storedLinkZ;
        int storedLinkAngle;
        DateTime lastDpadRight;
        DateTime lastFrameAdvance;
        bool doorCancelFromMacro;
        bool paused;

        Thread looping;

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
        

        List<MemViewerEntry> entries = Enumerable.Range(1, 16).Select(_ => new MemViewerEntry(0, 0, 0, 0, 0)).ToList();

        public static unsafe int FloatToHex(float f)
        {
            var i = *((int*)&f);
            string s = "0x" + i.ToString("X8");
            return Convert.ToInt32(s, 16);
        }

        Memfile tempMemfile;
        Dictionary<string, Memfile> availableMemfiles;
        FileSystemWatcher memfilesWatcher;
        FileSystemWatcher savefilesWatcher;


        public static TCPGecko tcpGecko = new TCPGecko();

        public Form1()
        {
            InitializeComponent();
            string yml = Encoding.ASCII.GetString(Resources.aroma);
            var deserializer = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build();
            yamlMap = deserializer.Deserialize<Dictionary<string, string>>(yml);

            Task.Run(CheckGitHubNewerVersion);
            

            Directory.CreateDirectory(settingsDir);
            Directory.CreateDirectory(settingsDir + "\\Memfiles");
            Directory.CreateDirectory(settingsDir + "\\Savefiles");

            if (!File.Exists(settingsDir + "\\Config.json"))
            {
                string json = JsonConvert.SerializeObject(ConfigObject.Default(), Formatting.Indented);

                File.WriteAllText(settingsDir + "\\Config.json", json);
            }

            
            ConfigObject.config = JsonConvert.DeserializeObject<ConfigObject>(File.ReadAllText(settingsDir + "\\Config.json"));
            ConfigObject.config.FillConfig();

            #region Config checks
            lToLevitateCheckbox.Checked = ConfigObject.config.macros["levitate"].enabled;
            doorCancelCheckbox.Checked = ConfigObject.config.macros["doorCancel"].enabled;
            superswimCheckbox.Checked = ConfigObject.config.macros["superswim"].enabled;
            storageCheckbox.Checked = ConfigObject.config.macros["storage"].enabled;
            masterkey.Checked = ConfigObject.config.macros["masterkey"].enabled;
            storeRestoreCheckbox.Checked = ConfigObject.config.macros["storePosition"].enabled;
            reloadRoomCheckbox.Checked = ConfigObject.config.macros["reloadRoom"].enabled;
            refillMagicCheckbox.Checked = ConfigObject.config.macros["refillMagic"].enabled;
            refillHealthCheckbox.Checked = ConfigObject.config.macros["refillHealth"].enabled;
            refillAmmoCheckbox.Checked = ConfigObject.config.macros["refillAmmo"].enabled;
            changeWindCheckbox.Checked = ConfigObject.config.macros["windDirection"].enabled;
            alternativeDpadRight.Checked = ConfigObject.config.macros["superswim"].alternative;
            alternativeMemfiles.Checked = ConfigObject.config.macros["storePosition"].alternative;

            levitateMK.Checked = ConfigObject.config.macros["levitate"].masterkey;
            doorCancelMK.Checked = ConfigObject.config.macros["doorCancel"].masterkey;
            superswimMK.Checked = ConfigObject.config.macros["superswim"].masterkey;
            storageMK.Checked = ConfigObject.config.macros["storage"].masterkey;
            
            saveReloadMK.Checked = ConfigObject.config.macros["storePosition"].masterkey;
            reloadRoomMK.Checked = ConfigObject.config.macros["reloadRoom"].masterkey;
            refillHealthMK.Checked = ConfigObject.config.macros["refillMagic"].masterkey;
            refillMagicMK.Checked = ConfigObject.config.macros["refillHealth"].masterkey;
            refillAmmoMK.Checked = ConfigObject.config.macros["refillAmmo"].masterkey;
            windDirectionMK.Checked = ConfigObject.config.macros["windDirection"].masterkey;

            levitateHeight.Value = (decimal)ConfigObject.config.macros["levitate"].value;
            superswimSpeed.Value = (decimal)ConfigObject.config.macros["superswim"].value;

            #endregion

            #region FSWatcher
            memfilesWatcher = new FileSystemWatcher(settingsDir + "\\Memfiles");

            memfilesWatcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            memfilesWatcher.Changed += MemfileRefresh;
            memfilesWatcher.Created += MemfileRefresh;
            memfilesWatcher.Deleted += MemfileRefresh;
            memfilesWatcher.Renamed += MemfileRefresh;

            memfilesWatcher.EnableRaisingEvents = true;


            savefilesWatcher = new FileSystemWatcher(settingsDir + "\\Savefiles");

            savefilesWatcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            savefilesWatcher.Changed += SavefileRefresh;
            savefilesWatcher.Created += SavefileRefresh;
            savefilesWatcher.Deleted += SavefileRefresh;
            savefilesWatcher.Renamed += SavefileRefresh;

            savefilesWatcher.EnableRaisingEvents = true;
            #endregion
            
            availableMemfiles = new Dictionary<string, Memfile>();
            
            foreach (GroupBox gb in miscFeaturesPanel.Controls.OfType<GroupBox>())
            {
                foreach (ComboBox item in gb.Controls.OfType<ComboBox>())
                {
                    foreach (InputEnum e in Enum.GetValues(typeof(InputEnum)).Cast<InputEnum>().ToArray())
                    {
                        item.Items.Add(e);
                    }
                    item.SelectedIndex = ConfigObject.config.macros[item.Name.Substring(0, item.Name.LastIndexOf("Combo"))].input;
                }
            }



            ipTextBox.Text = ConfigObject.config.wiiuIP;
            warningRuns.Checked = ConfigObject.config.warningBeforeRuns;
            displayMacros.Checked = ConfigObject.config.displayMacros;
            macrosPausedCheckBox.Checked = ConfigObject.config.disableMacrosWhenPaused;
            accuratePositionRestore.Checked = ConfigObject.config.accuratePosRestore;

            FormClosed += (object sender, FormClosedEventArgs e) => { if (tcpGecko.client != null) { tcpGecko.DisplayText(".", 255, 255, 255, 2); tcpGecko.Disconnect(); looping.Abort(); }
                ; 
                string json = JsonConvert.SerializeObject(ConfigObject.config, Formatting.Indented);
                File.WriteAllText(settingsDir + "\\Config.json", json); 

                System.Windows.Forms.Application.Exit(); 
            };

            mainFeaturesPanel.Visible = true;
            miscFeaturesPanel.Visible = false;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = false;
            itemsManager.Visible = false;
            memfilesPanel.Visible = false;
            teleporterPanel.Visible = false;

            foreach (Control item in Controls)
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
                MemfileRefresh(null, null);
                SavefileRefresh(null, null);
                ConfigObject.config.wiiuIP = ipTextBox.Text;
                
                if (!tcpGecko.Connect(ipTextBox.Text)) { 
                    return; 
                }

                looping = new Thread(new ThreadStart(Loopthread));
                looping.Start();

                tcpGecko.DisplayText(".", 255, 255, 255, 2);

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
                tcpGecko.DisplayText(".", 255, 255, 255, 2);
                tcpGecko.Disconnect();
                CheckInv.Stop();
                looping.Abort();
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

        private void levitateHeight_ValueChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["levitate"].value = (float)levitateHeight.Value;
        }

        private void superswimSpeed_ValueChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["superswim"].value = (float)superswimSpeed.Value;
        }

        private void warningRuns_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.warningBeforeRuns = warningRuns.Checked;
        }

        private void displayMacros_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.displayMacros = displayMacros.Checked;
            
        }

        private void lToLevitateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["levitate"].enabled = lToLevitateCheckbox.Enabled;
        }

        private void doorCancelCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["doorCancel"].enabled = doorCancelCheckbox.Checked;
            
        }

        private void superswimCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["superswim"].enabled = superswimCheckbox.Checked;
            
        }
        private void storageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["storage"].enabled = storageCheckbox.Checked;
            
        }

        private void masterkey_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["masterkey"].enabled = masterkey.Checked;
            
        }

        private void storeRestoreCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["storePosition"].enabled = storeRestoreCheckbox.Checked;
            ConfigObject.config.macros["restorePosition"].enabled = storeRestoreCheckbox.Checked;
            
        }

        private void reloadRoomCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["reloadRoom"].enabled = reloadRoomCheckbox.Checked;
            
        }

        private void refillMagicCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["refillMagic"].enabled = refillMagicCheckbox.Checked;
            
        }

        private void refillHealthCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["refillHealth"].enabled = refillHealthCheckbox.Checked;
            
        }

        private void refillAmmoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["refillAmmo"].enabled = refillAmmoCheckbox.Checked;
            
        }

        private void changeWindCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["windDirection"].enabled = changeWindCheckbox.Checked;
            
        }

        private void alternativeDpadRight_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["superswim"].alternative = alternativeDpadRight.Checked;
            
        }

        private void alternativeMemfiles_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["storePosition"].alternative = alternativeMemfiles.Checked;
            ConfigObject.config.macros["restorePosition"].alternative = alternativeMemfiles.Checked;
            
        }

        private void levitateMK_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["levitate"].masterkey = levitateMK.Checked;
        }

        private void doorCancelMK_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["doorCancel"].masterkey = doorCancelMK.Checked;
        }

        private void superswimMK_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["superswim"].masterkey = superswimMK.Checked;
        }

        private void storageMK_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["storage"].masterkey = storageMK.Checked;
        }

        private void windDirectionMK_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["windDirection"].masterkey = windDirectionMK.Checked;
        }

        private void saveReloadMK_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["storePosition"].masterkey = saveReloadMK.Checked;
            ConfigObject.config.macros["restorePosition"].masterkey = saveReloadMK.Checked;
        }

        private void reloadRoomMK_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["reloadRoom"].masterkey = reloadRoomMK.Checked;
        }

        private void refillHealthMK_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["refillHealth"].masterkey = refillHealthMK.Checked;
        }

        private void refillMagicMK_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["refillMagic"].masterkey = refillMagicMK.Checked;
        }

        private void refillAmmoMK_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["refillAmmo"].masterkey = refillAmmoMK.Checked;
        }

        private void macrosPausedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.disableMacrosWhenPaused = macrosPausedCheckBox.Checked;
        }

        private void accuratePositionRestore_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.accuratePosRestore = accuratePositionRestore.Checked;
        }
        #endregion

        #region Combos
        private void levitateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["levitate"].input = levitateCombo.SelectedIndex;
            ConfigObject.config.macros["levitate"].masterkey = levitateMK.Checked;
        }

        private void doorCancelCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["doorCancel"].input = doorCancelCombo.SelectedIndex;
            ConfigObject.config.macros["doorCancel"].masterkey = doorCancelMK.Checked;
        }

        private void superspeedCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["superswim"].input = superswimCombo.SelectedIndex;
            ConfigObject.config.macros["superswim"].masterkey = superswimMK.Checked;
            
        }

        private void storageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["storage"].input = storageCombo.SelectedIndex;
            ConfigObject.config.macros["storage"].masterkey = storageMK.Checked;
            
        }

        private void windDirectionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["windDirection"].input = windDirectionCombo.SelectedIndex;
            ConfigObject.config.macros["windDirection"].masterkey = windDirectionMK.Checked;
            
        }

        private void masterkeyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["masterkey"].input = masterkeyCombo.SelectedIndex;
            
        }

        private void savePosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["storePosition"].input = storePositionCombo.SelectedIndex;
            ConfigObject.config.macros["storePosition"].masterkey = saveReloadMK.Checked;
            
        }

        private void reloadPosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["restorePosition"].input = restorePositionCombo.SelectedIndex;
            ConfigObject.config.macros["restorePosition"].masterkey = saveReloadMK.Checked;
        }

        private void reloadRoomCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["reloadRoom"].input = reloadRoomCombo.SelectedIndex;
            ConfigObject.config.macros["reloadRoom"].masterkey = reloadRoomMK.Checked;
            
        }

        private void refillHealthCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["refillHealth"].input = refillHealthCombo.SelectedIndex;
            ConfigObject.config.macros["refillHealth"].masterkey = refillHealthMK.Checked;
            
        }

        private void refillMagicCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["refillMagic"].input = refillMagicCombo.SelectedIndex;
            ConfigObject.config.macros["refillMagic"].masterkey = refillMagicMK.Checked;

        }

        private void refillAmmoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["refillAmmo"].input = refillAmmoCombo.SelectedIndex;
            ConfigObject.config.macros["refillAmmo"].masterkey = refillAmmoMK.Checked;

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
        private void giveTunic_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506bb24 + 0x2A), out int tunicByte);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506bb24 + 0x2A, (tunicByte | 0b1000_0000));
        }

        private void removeTunic_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506bb24 + 0x2A), out int tunicByte);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506bb24 + 0x2A, (tunicByte & ~0b1000_0000));
        }

        private void giveMap_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506bb24 + 0x08), out int mapByte);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506bb24 + 0x08, (mapByte | 0b0000_0001));
        }

        private void removeMap_Click(object sender, EventArgs e)
        {
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506bb24 + 0x08), out int mapByte);
            tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506bb24 + 0x08, (mapByte & ~0b0000_0001));
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
                tcpGecko.Poke((TCPGecko.Datatype)typeDropdown.SelectedIndex, unchecked((int)Convert.ToUInt32(memoryAddress.Text, 16)), Convert.ToInt32(valueTextbox.Text, 16));
            }
            else
            {
                tcpGecko.Poke((TCPGecko.Datatype)typeDropdown.SelectedIndex, unchecked((int)Convert.ToUInt32(memoryAddress.Text, 16)), FloatToHex(float.Parse(valueTextbox.Text)));
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

        #region Memfiles

        private void createMemfile_Click(object sender, EventArgs e)
        {
            if (memfilesViewer.SelectedNode != null && memfilesViewer.SelectedNode.Text == "(Temporary memfile)")
            {
                tempMemfile = Memfile.Create(tcpGecko, true);
                ftDate = DateTime.Now;
                SavefileIndicator.Text = "Memfile saved on temporary slot!";
                favoriteText = true;
                return;
            }
            (bool, string) infos = MemfilePrompt.ShowDialog("Enter Memfile name", "Enter Memfile name");
            if (infos.Item2 != "")
            {
                Console.WriteLine(infos.Item1);
                Memfile memfile = Memfile.Create(tcpGecko, infos.Item1);
                string json = JsonConvert.SerializeObject(memfile, Formatting.Indented);
                File.WriteAllText(settingsDir + "\\Memfiles\\" + ((memfilesViewer.SelectedNode == null || memfilesViewer.SelectedNode.Nodes.Count == 0)? "" : memfilesViewer.SelectedNode.FullPath + "\\") + infos.Item2 + ".json", json);
                ftDate = DateTime.Now;
                SavefileIndicator.Text = "Succesfully created the memfile!";
                favoriteText = true;
            }

        }

        private void loadMemfile_Click(object sender, EventArgs e)
        {
            if (memfilesViewer.SelectedNode.Nodes.Count != 0) return;

            if (memfilesViewer.SelectedNode == null || memfilesViewer.SelectedNode.Text == "(Temporary memfile)")
            {
                tempMemfile.Load(tcpGecko, this);
            }
            else
            {
                availableMemfiles[memfilesViewer.SelectedNode.Text].Load(tcpGecko, this);
            }
            ftDate = DateTime.Now;
            SavefileIndicator.Text = "Succesfully loaded the memfile!";
            favoriteText = true;
        }

        void MemfileRefresh(object sender, FileSystemEventArgs e)
        {
            this.Invoke(new MethodInvoker(memfilesViewer.Nodes.Clear));
            
            this.Invoke(new EventHandler((s, ee) => memfilesViewer.Nodes.Add("(Temporary memfile)")));
            availableMemfiles.Clear();

            TreeNode[] tn = GetDirectoryNodes(settingsDir + "\\Memfiles\\").Nodes.OfType<TreeNode>().ToArray();
            Invoke(new EventHandler((s, ee) => memfilesViewer.Nodes.AddRange(tn)));
           
        }

        private TreeNode GetDirectoryNodes(string path)
        {
            
            DirectoryInfo dir = new DirectoryInfo(path);
            TreeNode tree = new TreeNode(dir.Name);
            foreach (var file in dir.GetFiles("*.json"))
            {
                if (File.Exists(file.FullName))
                {
                    using (StreamReader fi = File.OpenText(file.FullName))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        Memfile get = (Memfile)serializer.Deserialize(fi, typeof(Memfile));
                        availableMemfiles.Add(file.Name.Replace(".json", ""), get);
                        this.Invoke(new EventHandler((s, ee) => tree.Nodes.Add(file.Name.Replace(".json", ""))));
                    }
                }
            }

            var subDirs = Directory.GetDirectories(path).Select(d => GetDirectoryNodes(d)).ToArray();
            tree.Nodes.AddRange(subDirs);

            return tree;
        }

        void SavefileRefresh(object sender, FileSystemEventArgs e)
        {
            this.Invoke(new MethodInvoker(fileRep.Items.Clear));
            this.Invoke(new MethodInvoker(fileRep.SelectedIndices.Clear));
            DirectoryInfo d = new DirectoryInfo(settingsDir + "\\Savefiles");

            foreach (var dir in d.GetDirectories())
            {
                if (Directory.Exists(dir.FullName))
                {
                    this.Invoke(new EventHandler((s, ee) => fileRep.Items.Add(dir.Name)));
                }

            }

        }

        private void deleteMemfile_Click(object sender, EventArgs e)
        {
            File.Delete(settingsDir + "\\Memfiles\\" + memfilesViewer.SelectedNode.FullPath + ".json");
        }

        private void openMemfileFolder_Click(object sender, EventArgs e)
        {
            Process.Start(settingsDir + "\\Memfiles\\");
        }

        private void openSFDir_Click(object sender, EventArgs e)
        {
            Process.Start(settingsDir + "\\Savefiles\\");
        }

        private void loadSF_Click(object sender, EventArgs e)
        {
            var filepath = settingsDir + "\\Savefiles\\" + fileRep.Items[fileRep.SelectedIndices[0]].Text + "\\cking.sav";
            byte[] allBytes = File.ReadAllBytes(filepath);

            List<uint> firstBatch = new List<uint>();
            List<int> everythingToWatch = new List<int>();
            for (int i = 0;  i < 0x1FBC; i+=4)
            {
                byte[] toadd = new byte[4] { allBytes[i], allBytes[i + 1], allBytes[i + 2], allBytes[i + 3] };
                Array.Reverse(toadd);
                firstBatch.Add(BitConverter.ToUInt32(toadd, 0));
            }


            for (int i = 0x14FBC600; i < 0x14FBC600 + 0x1FBC; i+=4)
            {
                everythingToWatch.Add(i);
            }

            List<List<int>> packedAddress = everythingToWatch.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / 20)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();
            
            List<List<uint>> packedValues = firstBatch.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / 20)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();

            for (int i = 0; i < packedAddress.Count; i++)
            {
                tcpGecko.PokeMultiple(TCPGecko.Datatype.u32, packedAddress[i].ToArray(), packedValues[i].ToArray());
            }

            everythingToWatch.Clear();
            List<uint> nameBatch = new List<uint>();

            for(int i = 0x2035; i < 0x2035 + 18*3; i++)
            {
                nameBatch.Add(allBytes[i]);
            }

            for (int i = 0x14FBC600 + 0xB024D; i < 0x14FBC600 + 0xB024D + 18; i++)
            {
                everythingToWatch.Add(i);
            }

            for (int i = 0x14FBC600 + 0xB028D; i < 0x14FBC600 + 0xB028D + 18; i++)
            {
                everythingToWatch.Add(i);
            }

            for (int i = 0x14FBC600 + 0xB02CD; i < 0x14FBC600 + 0xB02CD + 18; i++)
            {
                everythingToWatch.Add(i);
            }

            for (int i = 0x2035; i < 0x2035 + 18 * 3; i+=2)
            {
                nameBatch.Add(allBytes[i]);
            }

            for (int i = 0x14FBC600 + 0xB01EC; i < 0x14FBC600 + 0xB01EC + 9; i++)
            {
                everythingToWatch.Add(i);
            }

            for (int i = 0x14FBC600 + 0xB022C; i < 0x14FBC600 + 0xB022C + 9; i++)
            {
                everythingToWatch.Add(i);
            }

            for (int i = 0x14FBC600 + 0xB026C; i < 0x14FBC600 + 0xB026C + 9; i++)
            {
                everythingToWatch.Add(i);
            }


            Console.WriteLine(everythingToWatch.Count);
            Console.WriteLine(nameBatch.Count);


            packedAddress = everythingToWatch.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / 20)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();

            packedValues = nameBatch.Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / 20)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();

            for (int i = 0; i < packedAddress.Count; i++)
            {
                tcpGecko.PokeMultiple(TCPGecko.Datatype.u8, packedAddress[i].ToArray(), packedValues[i].ToArray());
            }

            ftDate = DateTime.Now;
            SavefileIndicator.Text = "Succesfully injected the save!";
            favoriteText = true;

        }

        private void dumpSF_Click(object sender, EventArgs e)
        {

            string filePath = "storage_mlc\\usr\\save\\00050000\\";

            if (Memfile.ListFolders("storage_mlc", 2000) == "ServerUnk")
            {
                MessageBox.Show("Could not communicate through FTP with the wii u. Make sure to have the ftpiiu plugin installed and have the \"Allow access to system files\" checkbox checked in its settings.", "Alert");
                return;
            }

            if (Memfile.ListFolders("fs\\vol\\save\\80000001", 2000) != "DirNotFound")
            {
                filePath = "fs\\vol\\save\\80000001\\cking.sav";

                string name = Prompt.ShowDialog("Enter Savefile name", "Enter Savefile name");

                Directory.CreateDirectory(settingsDir + "\\Savefiles\\" + name);
                FileStream fs = File.Create(settingsDir + "\\Savefiles\\" + name + "\\cking.sav");
                fs.Close();
                Memfile.Download(filePath, settingsDir + "\\Savefiles\\" + name + "\\cking.sav");
                ftDate = DateTime.Now;
                SavefileIndicator.Text = "Succesfully dumped the save!";
                favoriteText = true;
            }
        }


        #endregion

        #region Teleporter

        private void addCustomFavorite_Click(object sender, EventArgs e)
        {
            (string, Stage) fav = FavoritePrompt.ShowDialog();
            if (fav.Item1 == "") return;
            ConfigObject.config.favorites.Add(fav.Item1, fav.Item2);
            if (favoriteMode) teleporterToggleFavorites_Click(sender, e);
            addedRemoved.ForeColor = Color.Green;
            favoriteText = true;
            ftDate = DateTime.Now;
            addedRemoved.Text = "Added " + fav.Item1 + " as favorite";

        }

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
                tcpGecko.PokeMultiple(TCPGecko.Datatype.u8, new int[] { 0x109763F0 + 3, 0x109763FA, 0x109763F9, 0x109763FB, 0x109763FC }, new uint[] { 0x0, b, b2, b3, 1 });
            }
            else if (me.Button == MouseButtons.Right)
            {
                favoriteMode = false;
                subAreas.Controls.Clear();
                foreach (string key in yamlMap.Keys)
                {
                    if (key.StartsWith(Stages.islands[mapIndex - 1].usingName) || key.StartsWith("Inside " + Stages.islands[mapIndex - 1].usingName))
                    {
                        System.Windows.Forms.Label element = new System.Windows.Forms.Label();
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
                                System.Windows.Forms.Label element = new System.Windows.Forms.Label();
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
                                System.Windows.Forms.Label element = new System.Windows.Forms.Label();
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
                                System.Windows.Forms.Label element = new System.Windows.Forms.Label();
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
                                System.Windows.Forms.Label element = new System.Windows.Forms.Label();
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
                                System.Windows.Forms.Label element = new System.Windows.Forms.Label();
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
                                System.Windows.Forms.Label element = new System.Windows.Forms.Label();
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
            System.Windows.Forms.Label a = (System.Windows.Forms.Label)sender;
            string stage = "";
            byte b;
            byte b2;
            byte b3;

            if (yamlMap.ContainsKey(a.Text))
            {
                stage = yamlMap[a.Text];
                b = byte.Parse(teleporterRoomId.Text);
                if (stage.Contains("M_Dra09") && Convert.ToByte(teleporterRoomId.Text, 16) == 0) b = byte.Parse("9");
                if (stage.Contains("kinMB") && Convert.ToByte(teleporterRoomId.Text, 16) == 0) b = byte.Parse("10");
                if (stage.Contains("SirenMB") && Convert.ToByte(teleporterRoomId.Text, 16) == 0) b = byte.Parse("23");
                if (stage.Contains("M_DaiMB") && Convert.ToByte(teleporterRoomId.Text, 16) == 0) b = byte.Parse("12");
                if (stage.Contains("kazeMB") && Convert.ToByte(teleporterRoomId.Text, 16) == 0) b = byte.Parse("06");

                b2 = Convert.ToByte(teleporterSpawnId.Text, 16);
                b3 = Convert.ToByte(teleporterLayer.Text, 16);
            }
            else
            {
                stage = ConfigObject.config.favorites[a.Text].stage;
                b = Convert.ToByte(ConfigObject.config.favorites[a.Text].roomId);
                b2 = Convert.ToByte(ConfigObject.config.favorites[a.Text].spawnId);
                b3 = Convert.ToByte(ConfigObject.config.favorites[a.Text].layer);
            }



            if (me.Button == MouseButtons.Left)
            {
                byte[] array = new byte[stage.Length];

                array = Encoding.ASCII.GetBytes(stage);


                for (int i = 0; i < stage.Length; i++)
                {
                    tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763F0 + i, array[i]);
                }
                tcpGecko.PokeMultiple(TCPGecko.Datatype.u8, new int[] { 0x109763F0 + stage.Length, 0x109763FA, 0x109763F9, 0x109763FB, 0x109763FC }, new uint[] { 0x0, b, b2, b3, 1 });
            }
            else if (me.Button == MouseButtons.Right)
            {

                if (!ConfigObject.config.favorites.ContainsKey(a.Text))
                {
                    string text = Prompt.ShowDialog("Enter favorite name:", "Add favorite");
                    if (text == "") return;
                    ConfigObject.config.favorites.Add(text, new Stage("", stage, 0, false, byte.Parse(teleporterRoomId.Text), Convert.ToByte(teleporterSpawnId.Text, 16), Convert.ToByte(teleporterLayer.Text, 16)));
                    addedRemoved.ForeColor = Color.Green;
                    favoriteText = true;
                    ftDate = DateTime.Now;
                    addedRemoved.Text = "Added " + text + " as favorite";
                }
                else
                {
                    ConfigObject.config.favorites.Remove(a.Text);
                    if (favoriteMode) teleporterToggleFavorites_Click(sender, e);
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
                    System.Windows.Forms.Label element = new System.Windows.Forms.Label();
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
            foreach (string key in ConfigObject.config.favorites.Keys)
            {
                System.Windows.Forms.Label element = new System.Windows.Forms.Label();
                element.Text = key;
                element.MinimumSize = new Size(200, 5);
                element.MaximumSize = new Size(200, 15);
                element.Click += ListTeleportHandler;
                subAreas.Controls.Add(element);
            }
        }

        #endregion

        #region Timers

        public void Loopthread()
        {
            while (tcpGecko.connected)
            {
                Loop();
            }
            looping.Abort();
            return;
        }

        public void Loop()
        {
            if (!tcpGecko.connected)
            {
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
                return;
            }

            if (Memfile.isLoading)
            {
                return;
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
                0x109763E4, // stage
                0x109763E5,
                0x109763E6,
                0x109763E7,
                0x109763E8,
                0x109763E9,
                0x109763EA,
                0x109763EB, // stage

                0x109763EF, // layer
                0x10978CF8, // roomId
                0x109763ED, // spawnId
                0x106EC269, // pause status
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

            bool cheatActivated = false;

            if (!(ConfigObject.config.disableMacrosWhenPaused && int.Parse(stageInfo[11]) == 1))
            {
                //l
                if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["levitate"].input)) &&
                    (ConfigObject.config.macros["levitate"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["masterkey"].input)))
                    && lToLevitateCheckbox.Checked)
                {
                    Cheats.LToLevitate(tcpGecko, ConfigObject.config.macros["levitate"].value, displayMacros.Checked);
                    cheatActivated = true;
                }

                //left dpad
                if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["doorCancel"].input)) &&
                    (ConfigObject.config.macros["doorCancel"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["masterkey"].input)))
                    && doorCancelCheckbox.Checked)
                {
                    Cheats.DoorCancel(tcpGecko, true);
                    doorCancelFromMacro = true;
                    cheatActivated = true;
                    if (displayMacros.Checked) tcpGecko.DisplayText("[Macros] Door Cancel", 255, 153, 0, 255);
                }
                else if (doorCancelFromMacro)
                {
                    Cheats.DoorCancel(tcpGecko, false);
                    doorCancelFromMacro = false;
                }



                //right dpad
                if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["superswim"].input)) &&
                    (ConfigObject.config.macros["superswim"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["masterkey"].input)))
                    && superswimCheckbox.Checked &&
                    lastDpadRight + TimeSpan.FromMilliseconds(100) < DateTime.Now)
                {
                    bool zlHeld = Inputs.isPressed(inputs, Inputs.zlButton) || !ConfigObject.config.macros["superswim"].alternative;
                    Cheats.Superswim(tcpGecko, ConfigObject.config.macros["superswim"].value, linkSpeed, zlHeld, link_ptr, displayMacros.Checked);
                    cheatActivated = true;
                    lastDpadRight = DateTime.Now;
                }

                //down dpad 
                if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["storage"].input)) &&
                    (ConfigObject.config.macros["storage"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["masterkey"].input)))
                    && storageCheckbox.Checked)
                {
                    tcpGecko.Poke(TCPGecko.Datatype.u8, 0x10976543, 0x1);
                    if (displayMacros.Checked) tcpGecko.DisplayText("[Macros] Give Storage", 255, 153, 0, 255);
                    cheatActivated = true;
                }
                //l3
                if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["windDirection"].input)) &&
                    (ConfigObject.config.macros["windDirection"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["masterkey"].input)))
                    && storageCheckbox.Checked)
                {
                    Cheats.ChangeWindDir(tcpGecko, displayMacros.Checked);
                    cheatActivated = true;
                }

                //l + zr
                if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["refillHealth"].input)) &&
                    (ConfigObject.config.macros["refillHealth"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["masterkey"].input)))
                    && refillHealthCheckbox.Checked)
                {
                    Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b501), out int maxHealth);
                    if (maxHealth != 0)
                    {
                        tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b503, maxHealth);
                        if (displayMacros.Checked) tcpGecko.DisplayText("[Macros] Refill Health", 255, 153, 0, 255);
                        cheatActivated = true;
                    }
                }

                //r + zr
                if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["refillMagic"].input)) &&
                    (ConfigObject.config.macros["refillMagic"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["masterkey"].input)))
                    && refillMagicCheckbox.Checked)
                {
                    Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b513), out int maxMagic);
                    if (maxMagic != 0)
                    {
                        if (displayMacros.Checked) tcpGecko.DisplayText("[Macros] Refill Magic", 255, 153, 0, 255);
                        tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b514, maxMagic);
                        cheatActivated = true;
                    }
                }

                //dpad up + zr
                if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["refillAmmo"].input)) &&
                    (ConfigObject.config.macros["refillAmmo"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["masterkey"].input)))
                    && refillAmmoCheckbox.Checked)
                {
                    Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b56f), out int maxArrows);
                    if (maxArrows != 0)
                    {

                        tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b569, maxArrows);
                        cheatActivated = true;
                    }

                    Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b570), out int maxBombs);
                    if (maxBombs != 0)
                    {
                        tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b56a, maxBombs);
                        cheatActivated = true;
                    }
                    if (displayMacros.Checked) tcpGecko.DisplayText("[Macros] Refill Ammo", 255, 153, 0, 255);
                }

                //dpad down + zr
                if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["reloadRoom"].input)) &&
                    (ConfigObject.config.macros["reloadRoom"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["masterkey"].input)))
                    && reloadRoomCheckbox.Checked)
                {
                    tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763fc, 0x1);
                    if (displayMacros.Checked) tcpGecko.DisplayText("[Macros] Reload Room", 255, 153, 0, 255);
                    cheatActivated = true;
                }

                //dpad left + zr
                if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["restorePosition"].input)) &&
                    (ConfigObject.config.macros["restorePosition"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["masterkey"].input)))
                    && storeRestoreCheckbox.Checked)
                {
                    if (!ConfigObject.config.macros["restorePosition"].alternative && (storedLinkX != 0 || storedLinkY != 0 || storedLinkZ != 0))
                    {
                        
                        if (ConfigObject.config.accuratePosRestore)
                        {
                            tcpGecko.PauseExec();
                            Cheats.DoorCancel(tcpGecko, true);
                            Thread.Sleep(100);

                            tcpGecko.AdvanceExec();
                            //account for 1 frame of falling
                            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef4c, FloatToHex(storedLinkY));

                            Thread.Sleep(100);

                            tcpGecko.AdvanceExec();
                            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef48, FloatToHex(storedLinkX));
                            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef50, FloatToHex(storedLinkZ));
                            tcpGecko.Poke(TCPGecko.Datatype.u16, 0x1096ef12, storedLinkAngle);
                            Cheats.DoorCancel(tcpGecko, false);

                            Thread.Sleep(100);
                            tcpGecko.ResumeExec();

                        }
                        else
                        {
                            Cheats.DoorCancel(tcpGecko, true);
                            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef48, FloatToHex(storedLinkX));
                            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef4c, FloatToHex(storedLinkY));
                            tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef50, FloatToHex(storedLinkZ));
                            Cheats.DoorCancel(tcpGecko, false);
                        }
                        if (displayMacros.Checked) tcpGecko.DisplayText("[Macros] Restore Position", 255, 153, 0, 255);
                        cheatActivated = true;
                    }
                    else if (ConfigObject.config.macros["restorePosition"].alternative)
                    {
                        if (memfilesViewer.SelectedNode == null || memfilesViewer.SelectedNode.Text == "(Temporary memfile)")
                        {
                            tempMemfile.Load(tcpGecko, this);
                        }
                        else
                        {
                            availableMemfiles[memfilesViewer.SelectedNode.Name].Load(tcpGecko, this);
                        }
                        if (displayMacros.Checked) tcpGecko.DisplayText("[Macros] Restore selected memfile", 255, 153, 0, 255);
                        cheatActivated = true;
                    }

                }

                //dpad right + zr
                if (Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["storePosition"].input)) &&
                    (ConfigObject.config.macros["storePosition"].masterkey == Inputs.isPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["masterkey"].input)))
                    && storeRestoreCheckbox.Checked)
                {
                    if (!ConfigObject.config.macros["storePosition"].alternative)
                    {
                        storedLinkX = linkCoordinates.Item1;
                        storedLinkY = linkCoordinates.Item2;
                        storedLinkZ = linkCoordinates.Item3;
                        storedLinkAngle = linkAngle;
                        if (displayMacros.Checked) tcpGecko.DisplayText("[Macros] Store Position", 255, 153, 0, 255);
                        cheatActivated = true;
                    }
                    else
                    {
                        tempMemfile = Memfile.Create(tcpGecko, true);
                        if (displayMacros.Checked) tcpGecko.DisplayText("[Macros] Save into temp memfile", 255, 153, 0, 255);
                        cheatActivated = true;
                    }
                }
                if (Inputs.isNotPressed(inputs, Inputs.enumToInput((InputEnum)ConfigObject.config.macros["doorCancel"].input))
                    && doorCancelFromMacro)
                {
                    Cheats.RestoreCollision(tcpGecko);
                    doorCancelFromMacro = false;
                }
            }
            


            this.Invoke(new MethodInvoker(dataViewerControl.RefreshSticks));
            this.Invoke(new MethodInvoker(separateDataViewerControl.RefreshSticks));
            this.Invoke(new Action<int>(dataViewerControl.RefreshInputs), inputs);
            this.Invoke(new Action<int>(separateDataViewerControl.RefreshInputs), inputs);

            this.Invoke(new MethodInvoker(UpdateLinkLabel));

            if (stage.Contains("sea_T") && warningRuns.Checked)
            {
                tcpGecko.DisplayText("[Warning] Make sure to disable the TCPGecko plugin before starting a run!", 255, 0, 0, 255);
            }
            else if (!cheatActivated || !displayMacros.Checked)
            {
                if (dataViewerPanel.Visible || separate.Visible)
                {
                    tcpGecko.DisplayText(".", 255, 0, 0, 2);
                }
                else
                {
                    tcpGecko.DisplayText(".", 255, 255, 255, 2);
                }

            }
        }

        public void UpdateLinkLabel()
        {
            if (ftDate + TimeSpan.FromMilliseconds(5000) < DateTime.Now && favoriteText)
            {
                favoriteText = false;
                addedRemoved.Text = "";
                SavefileIndicator.Text = "";
            }

            if (stage.StartsWith("sea"))
            {
                int mapQuadrant = Math.Min(Math.Max((int)(linkCoordinates.Item1 + 340000) / (680000 / 7), 0), 6) + 7 * (int)Math.Min(Math.Max((int)(linkCoordinates.Item3 + 340000) / (680000 / 7), 0), 6);
                linkLocationLabel.Text = Stages.islands[mapQuadrant].usingName;
                movingLink.Visible = displayOnMap.Checked;
                movingLink.Location = new Point((int)(((linkCoordinates.Item1 + 340000) / 680000) * transparentLayer.Width) - movingLink.Width / 2, (int)(((linkCoordinates.Item3 + 340000) / 680000) * transparentLayer.Height) - movingLink.Height / 2);
            }
            else
            {
                movingLink.Visible = false;
                bool found = false;
                foreach (var item in yamlMap.Keys)
                {
                    if (stage.Split(new[] { '\0' }, 2)[0] == yamlMap[item])
                    {
                        linkLocationLabel.Text = item;
                        found = true;
                        break;
                    }

                }
                if (!found) linkLocationLabel.Text = "Unknown";
            }
        }

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

            if(memoryAddress.Text != "" && memoryAddress.Text.Length == 10 && Convert.ToInt32(memoryAddress.Text, 16) > 0x10000000)
            {
                
                var a = memoryAddress.Text.Substring(0, memoryAddress.Text.Length - 1) + "0";
                int startAddress = Convert.ToInt32(a, 16);
                List<int> addr = new List<int>();
                for(int i = startAddress;
                    i < startAddress + 0x10 * 16; 
                    i += 0x4)
                {
                    addr.Add(i);
                }

                List<List<int>> packed = addr.Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / 20)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();

                List<string> raw = new List<string>();
                foreach (List<int> toSend in packed)
                {
                    raw.AddRange(tcpGecko.PeekMultiple(TCPGecko.Datatype.u32, toSend.ToArray()));
                }

                Console.WriteLine(addr.Count);
                Console.WriteLine(raw.Count);

                for (int i = 0; i < raw.Count; i+=4)
                {
                    uint zero = unchecked((UInt32)Int64.Parse(raw[i]));
                    uint four = unchecked((UInt32)Int64.Parse(raw[i+1]));
                    uint eight = unchecked((UInt32)Int64.Parse(raw[i+2]));
                    uint c = unchecked((UInt32)Int64.Parse(raw[i+3]));
                    entries[i / 4] = new MemViewerEntry(addr[i], zero, four, eight, c);
                }
                memViewer.DataSource = entries;
                memViewer.Refresh();
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

        private static async System.Threading.Tasks.Task CheckGitHubNewerVersion()
        {
            GitHubClient client = new GitHubClient(new ProductHeaderValue("WWHD-Hacker"));
            IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("Teotia444", "WWHD-Hacker");

            Version latestGitHubVersion = new Version(releases[0].TagName);

            int versionComparison = local.CompareTo(latestGitHubVersion);
            if (versionComparison < 0)
            {
                DialogResult yesno = MessageBox.Show("There is a newer version available on github. Would you like to download it?", "Update", MessageBoxButtons.YesNo);
                if (yesno == DialogResult.Yes)
                {
                    Process.Start("https://github.com/Teotia444/WWHD-Hacker/releases/latest");
                }
            }
        }

        #endregion


    }

    public class MemViewerEntry
    {
        public string address {get; set;}
        public string zero {get; set;}
        public string four {get; set;}
        public string eight {get; set;}
        public string c { get; set; }

        public MemViewerEntry(int address, uint zero, uint four, uint eight, uint c)
        {
            this.address = $"0x{address:X}";
            this.zero = $"0x{zero:X8}";
            this.four = $"0x{four:X8}";
            this.eight = $"0x{eight:X8}";
            this.c = $"0x{c:X8}";
        }
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

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            System.Windows.Forms.Label textSystemLabel = new System.Windows.Forms.Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textSystemLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
    
    public static class MemfilePrompt
    {
        public static (bool, string) ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            System.Windows.Forms.Label textSystemLabel = new System.Windows.Forms.Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            CheckBox savePos = new CheckBox() { Text = "Restore position when loaded", Left = 20, Top = 70, Checked = true };

            Button confirmation = new Button() { Text = "Ok", Left = 170, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(savePos);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textSystemLabel);
            prompt.AcceptButton = confirmation;

            return  prompt.ShowDialog() == DialogResult.OK ? (savePos.Checked, textBox.Text) : (false, "");
        }
    }

    public static class FavoritePrompt
    {
        public static (string, Stage) ShowDialog()
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 350,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Add favorite",
                StartPosition = FormStartPosition.CenterScreen
            };
            System.Windows.Forms.Label nameLabel = new System.Windows.Forms.Label() { Left = 50, Top = 20, Text = "Favorite name" };
            TextBox nameTextbox = new TextBox() { Left = 50, Top = 40, Width = 200 };
            System.Windows.Forms.Label stageLabel = new System.Windows.Forms.Label() { Left = 50, Top = 70, Text = "Stage" };
            TextBox stageTextbox = new TextBox() { Left = 50, Top = 90, Width = 200 };
            System.Windows.Forms.Label roomIdLabel = new System.Windows.Forms.Label() { Left = 50, Top = 120, Text = "Room ID" };
            TextBox roomIdTextbox = new TextBox() { Left = 50, Top = 140, Width = 200 };
            System.Windows.Forms.Label spawnIdLabel = new System.Windows.Forms.Label() { Left = 50, Top = 170, Text = "Spawn ID" };
            TextBox spawnIdTextbox = new TextBox() { Left = 50, Top = 190, Width = 200 };
            System.Windows.Forms.Label layerLabel = new System.Windows.Forms.Label() { Left = 50, Top = 220, Text = "Layer" };
            TextBox layerTextbox = new TextBox() { Left = 50, Top = 240, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 280, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(nameTextbox);
            prompt.Controls.Add(stageTextbox);
            prompt.Controls.Add(roomIdTextbox);
            prompt.Controls.Add(spawnIdTextbox);
            prompt.Controls.Add(layerTextbox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(nameLabel);
            prompt.Controls.Add(stageLabel);
            prompt.Controls.Add(roomIdLabel);
            prompt.Controls.Add(spawnIdLabel);
            prompt.Controls.Add(layerLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? (nameTextbox.Text, new Stage("",
                                                                                         stageTextbox.Text,
                                                                                         0,
                                                                                         false,
                                                                                         Convert.ToByte(roomIdTextbox.Text),
                                                                                         Convert.ToByte(spawnIdTextbox.Text, 16),
                                                                                         Convert.ToByte(layerTextbox.Text, 16))) : ("", new Stage("","",0,false,0,0));
        }
    }
}
