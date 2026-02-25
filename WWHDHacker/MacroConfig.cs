using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWHDHacker
{
    public partial class MacroConfig : Form
    {

        public MacroConfig(string settingsDir)
        {
            InitializeComponent();
            ConfigObject.config = JsonConvert.DeserializeObject<ConfigObject>(File.ReadAllText(settingsDir + "\\config.json"));
            ConfigObject.config.FillConfig();

            levitateMK.Checked = ConfigObject.config.macros["levitate"].masterkey;
            doorCancelMK.Checked = ConfigObject.config.macros["doorCancel"].masterkey;
            superswimMK.Checked = ConfigObject.config.macros["superswim"].masterkey;
            
            Console.WriteLine(ConfigObject.config.macros["storage"].masterkey);
            storageMK.Checked = ConfigObject.config.macros["storage"].masterkey;

            saveReloadMK.Checked = ConfigObject.config.macros["storePosition"].masterkey;
            reloadRoomMK.Checked = ConfigObject.config.macros["reloadRoom"].masterkey;
            refillHealthMK.Checked = ConfigObject.config.macros["refillMagic"].masterkey;
            refillMagicMK.Checked = ConfigObject.config.macros["refillHealth"].masterkey;
            refillAmmoMK.Checked = ConfigObject.config.macros["refillAmmo"].masterkey;
            windDirectionMK.Checked = ConfigObject.config.macros["windDirection"].masterkey;

            levitateHeight.Value = (decimal)ConfigObject.config.macros["levitate"].value;
            superswimSpeed.Value = (decimal)ConfigObject.config.macros["superswim"].value;

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

            foreach (GroupBox gb in this.Controls.OfType<GroupBox>())
            {
                foreach (ComboBox item in gb.Controls.OfType<ComboBox>())
                {
                    foreach (InputEnum e in Enum.GetValues(typeof(InputEnum)).Cast<InputEnum>().ToArray())
                    {
                        item.Items.Add(e);
                    }
                    item.SelectedIndex = ConfigObject.config.macros[item.Name.Substring(0, item.Name.LastIndexOf("Combo") == -1 ? 0 : item.Name.LastIndexOf("Combo")) == "" ? "storage" : item.Name.Substring(0, item.Name.LastIndexOf("Combo"))].input;
                }
            }
        }

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

        private void superswimCombo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void storePositionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["storePosition"].input = storePositionCombo.SelectedIndex;
            ConfigObject.config.macros["storePosition"].masterkey = saveReloadMK.Checked;

        }

        private void restorePositionCombo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["softReset"].input = softResetCombo.SelectedIndex;
            ConfigObject.config.macros["softReset"].masterkey = softResetCheckbox.Checked;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["reloadMemfile"].input = softResetCombo.SelectedIndex;
            ConfigObject.config.macros["reloadMemfile"].masterkey = softResetCheckbox.Checked;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["softReset"].masterkey = softResetMK.Checked;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["softReset"].enabled = softResetCheckbox.Checked;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["reloadMemfile"].masterkey = reloadMemfileMK.Checked;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["reloadMemfile"].enabled = reloadMemfileCheckbox.Checked;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void levitateHeight_ValueChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["levitate"].value = (float)levitateHeight.Value;
        }

        private void superswimSpeed_ValueChanged(object sender, EventArgs e)
        {
            ConfigObject.config.macros["superswim"].value = (float)superswimSpeed.Value;
        }

        private void MacroConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
