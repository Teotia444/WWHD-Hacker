using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TCPGeckoAromaLibrary;
using WWHDHacker.Properties;

namespace WWHDHacker
{
    public partial class Form1: Form
    {

        float storedLinkX;
        float storedLinkY;
        float storedLinkZ;
        int storedLinkAngle;
        DateTime lastDpadRight;
        bool doorCancelFromMacro;

        unsafe int FloatToHex(float f)
        {
            var i = *((int*)&f);
            string s = "0x" + i.ToString("X8");
            return Convert.ToInt32(s, 16);
        }


        public static TCPGecko tcpGecko = new TCPGecko();

        public Form1()
        {
            InitializeComponent();

            mainFeaturesPanel.Visible = true;
            panel1.Visible = false;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = false;
            itemsManager.Visible = false;

            typeDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (string i in Enum.GetNames(typeof(TCPGecko.Datatype)))
            {
                typeDropdown.Items.Add(i);
            }
        }

        #region Top menu
        private void connect_Click(object sender, EventArgs e)
        {
            if (connect.Text == "Connect")
            {
                tcpGecko.Connect(ipTextBox.Text);
                timer1.Start();
                timer1.Interval = 50;
                CheckInv.Start();
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                connect.Text = "Disconnect";
            }
            else
            {
                tcpGecko.Disconnect();
                CheckInv.Stop();
                timer1.Stop();
                connect.Text = "Connect";
            }
        }

        private void mainFeatures_Click(object sender, EventArgs e)
        {
            mainFeaturesPanel.Visible = true;
            panel1.Visible = false;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = false;
            itemsManager.Visible = false;
        }

        private void miscFeatures_Click(object sender, EventArgs e)
        {
            mainFeaturesPanel.Visible = false;
            panel1.Visible = true;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = false;
            itemsManager.Visible = false;
        }

        private void dataViewer_Click(object sender, EventArgs e)
        {
            mainFeaturesPanel.Visible = false;
            panel1.Visible = false;
            dataViewerPanel.Visible = true;
            advancedPanel.Visible = false;
            itemsManager.Visible = false;
        }

        private void advanced_Click(object sender, EventArgs e)
        {
            mainFeaturesPanel.Visible = false;
            panel1.Visible = false;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = true;
            itemsManager.Visible = false;
        }

        private void itemManagerButton_Click(object sender, EventArgs e)
        {
            mainFeaturesPanel.Visible = false;
            panel1.Visible = false;
            dataViewerPanel.Visible = false;
            advancedPanel.Visible = false;
            itemsManager.Visible = true;
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

        #endregion

        #region Misc features
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
            tcpGecko.AdvanceExec();

        }

        private void pauseGame_Click(object sender, EventArgs e)
        {
            tcpGecko.PauseExec();
        }

        private void resumeGame_Click(object sender, EventArgs e)
        {
            tcpGecko.ResumeExec();
        }
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
                valueTextbox.Text = $"0x{fv:X}";
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

        #region Timers
        private void CheckInv_Tick(object sender, EventArgs e)
        {
            if (!autoupdateTracker.Checked) return;
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

            if (itemsManager.Visible != true)
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
            Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u32, 0x102F48A8), out int inputs);
            
            //l
            if (Inputs.isPressed(inputs, Inputs.lButton) && Inputs.isNotPressed(inputs, Inputs.zrButton) && lToLevitateCheckbox.Checked)
            {
                Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u32, 0x10976ab4), out int hoverAddress);
                tcpGecko.Poke(TCPGecko.Datatype.u32, hoverAddress + 0x340, 0x42800000);
            }

            //left dpad
            if (Inputs.isPressed(inputs, Inputs.dpadLeftButton) && Inputs.isNotPressed(inputs, Inputs.zrButton) && doorCancelCheckbox.Checked)
            {
                Cheats.DoorCancel(tcpGecko, true);
                doorCancelFromMacro = true;
            }
            else if (doorCancelFromMacro)
            {
                Cheats.DoorCancel(tcpGecko, false);
                doorCancelFromMacro = false;
            }

            //l3
            if (Inputs.isPressed(inputs, Inputs.l3Button))
            {
                Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u16, 0x1096ef12), out int angle);
                uint wind = (UInt16)((-angle - 0xC000));
                wind += 0x1000;
                wind /= 0x2000;
                wind *= 0x2000;
                tcpGecko.Poke(TCPGecko.Datatype.u16, 0x1097868E, (int)wind);
            }

            //right dpad
            if (Inputs.isPressed(inputs, Inputs.dpadRightButton) && Inputs.isNotPressed(inputs, Inputs.zrButton) && superswimCheckbox.Checked && lastDpadRight + TimeSpan.FromMilliseconds(100) < DateTime.Now)
            {
                float speedToApply = 0f;
                Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u32, 0x10976de4), out int link_ptr);
                float.TryParse(tcpGecko.Peek(TCPGecko.Datatype.f32, link_ptr + 27156), out speedToApply);
                bool flag = speedToApply < 0f;
                speedToApply = (speedToApply > 50f && !flag) ? (speedToApply + 500f) : ((speedToApply < -50f && flag) ? (speedToApply - 500f) : ((!(speedToApply < 50f) || flag) ? (speedToApply - 100f) : (speedToApply + 100f)));
                tcpGecko.Poke(TCPGecko.Datatype.f32, link_ptr + 27156, FloatToHex(speedToApply));
                tcpGecko.Poke(TCPGecko.Datatype.u16, 0x10976dfe, 900);
                lastDpadRight = DateTime.Now;
            }
            
            //down dpad 
            if (Inputs.isPressed(inputs, Inputs.dpadDownButton) && Inputs.isNotPressed(inputs, Inputs.zrButton) && storageCheckbox.Checked)
            {
                tcpGecko.Poke(TCPGecko.Datatype.u8, 0x10976543, 0x1);
            }

            //Masterkey
            if (Inputs.isPressed(inputs, Inputs.zrButton) && masterkey.Checked)
            {
                //l + zr
                if (Inputs.isPressed(inputs, Inputs.lButton) && refillHealthCheckbox.Checked)
                {
                    Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b501), out int maxHealth);
                    if (maxHealth != 0)
                    {
                        tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b503, maxHealth);
                    }
                }
                
                //r + zr
                if (Inputs.isPressed(inputs, Inputs.rButton) && refillMagicCheckbox.Checked)
                {
                    Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u8, 0x1506b513), out int maxMagic);
                    if (maxMagic != 0)
                    {
                        tcpGecko.Poke(TCPGecko.Datatype.u8, 0x1506b514, maxMagic);
                    }
                }
                
                //dpad up + zr
                if (Inputs.isPressed(inputs, Inputs.dpadUpButton) && refillAmmoCheckbox.Checked)
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
                if (Inputs.isPressed(inputs, Inputs.dpadDownButton) && reloadRoomCheckbox.Checked)
                {
                    tcpGecko.Poke(TCPGecko.Datatype.u8, 0x109763fc, 0x1);
                }
                
                //dpad left + zr
                if (Inputs.isPressed(inputs, Inputs.dpadLeftButton) && (storedLinkX != 0 || storedLinkY != 0 || storedLinkZ != 0) && storeRestoreCheckbox.Checked)
                {
                    Cheats.DoorCancel(tcpGecko, true);
                    tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef48, FloatToHex(storedLinkX));
                    tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef4c, FloatToHex(storedLinkY));
                    tcpGecko.Poke(TCPGecko.Datatype.f32, 0x1096ef50, FloatToHex(storedLinkZ));
                    tcpGecko.Poke(TCPGecko.Datatype.u16, 0x1096ef12, storedLinkAngle);
                    Cheats.DoorCancel(tcpGecko, false);
                }
                
                //dpad right + zr
                else if (Inputs.isPressed(inputs, Inputs.dpadRightButton) && storeRestoreCheckbox.Checked)
                {
                    float.TryParse(tcpGecko.Peek(TCPGecko.Datatype.f32, 0x1096ef48), out storedLinkX);
                    float.TryParse(tcpGecko.Peek(TCPGecko.Datatype.f32, 0x1096ef4c), out storedLinkY);
                    float.TryParse(tcpGecko.Peek(TCPGecko.Datatype.f32, 0x1096ef50), out storedLinkZ);
                    Int32.TryParse(tcpGecko.Peek(TCPGecko.Datatype.u16, 0x1096ef12), out storedLinkAngle);
                }
                
                else
                {
                    Cheats.RestoreCollision(tcpGecko);
                }
            }
            else if (Inputs.isNotPressed(inputs, Inputs.dpadLeftButton) && doorCancelFromMacro)
            {
                Cheats.RestoreCollision(tcpGecko);
                doorCancelFromMacro = false;
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
