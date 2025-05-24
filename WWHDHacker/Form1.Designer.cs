using System.Drawing;
using System.Windows.Forms;

namespace WWHDHacker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.miscFeaturesPanel = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.infHealth = new System.Windows.Forms.CheckBox();
            this.infMagic = new System.Windows.Forms.CheckBox();
            this.infAir = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.removeTunic = new System.Windows.Forms.Button();
            this.giveTunic = new System.Windows.Forms.Button();
            this.refreshAS = new System.Windows.Forms.Button();
            this.animSet2 = new System.Windows.Forms.Button();
            this.animSet1 = new System.Windows.Forms.Button();
            this.currentAnimSet = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pauseGame = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.resumeGame = new System.Windows.Forms.Button();
            this.displayMacros = new System.Windows.Forms.CheckBox();
            this.warningRuns = new System.Windows.Forms.CheckBox();
            this.Levitate = new System.Windows.Forms.GroupBox();
            this.levitateMK = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.levitateCombo = new System.Windows.Forms.ComboBox();
            this.lToLevitateCheckbox = new System.Windows.Forms.CheckBox();
            this.DoorCancel = new System.Windows.Forms.GroupBox();
            this.doorCancelMK = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.doorCancelCombo = new System.Windows.Forms.ComboBox();
            this.doorCancelCheckbox = new System.Windows.Forms.CheckBox();
            this.Superspeed = new System.Windows.Forms.GroupBox();
            this.superswimMK = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.superswimCombo = new System.Windows.Forms.ComboBox();
            this.superswimCheckbox = new System.Windows.Forms.CheckBox();
            this.alternativeDpadRight = new System.Windows.Forms.CheckBox();
            this.Storage = new System.Windows.Forms.GroupBox();
            this.storageMK = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.storageCombo = new System.Windows.Forms.ComboBox();
            this.storageCheckbox = new System.Windows.Forms.CheckBox();
            this.WindDirection = new System.Windows.Forms.GroupBox();
            this.windDirectionMK = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.windDirectionCombo = new System.Windows.Forms.ComboBox();
            this.changeWindCheckbox = new System.Windows.Forms.CheckBox();
            this.MasterkeyGroup = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.masterkeyCombo = new System.Windows.Forms.ComboBox();
            this.masterkey = new System.Windows.Forms.CheckBox();
            this.SaveReloadPos = new System.Windows.Forms.GroupBox();
            this.saveReloadMK = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.storePositionCombo = new System.Windows.Forms.ComboBox();
            this.restorePositionCombo = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.alternativeMemfiles = new System.Windows.Forms.CheckBox();
            this.storeRestoreCheckbox = new System.Windows.Forms.CheckBox();
            this.ReloadRoom = new System.Windows.Forms.GroupBox();
            this.reloadRoomMK = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.reloadRoomCombo = new System.Windows.Forms.ComboBox();
            this.reloadRoomCheckbox = new System.Windows.Forms.CheckBox();
            this.RefillHealth = new System.Windows.Forms.GroupBox();
            this.refillHealthMK = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.refillHealthCombo = new System.Windows.Forms.ComboBox();
            this.refillHealthCheckbox = new System.Windows.Forms.CheckBox();
            this.RefillMagic = new System.Windows.Forms.GroupBox();
            this.refillMagicMK = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.refillMagicCombo = new System.Windows.Forms.ComboBox();
            this.refillMagicCheckbox = new System.Windows.Forms.CheckBox();
            this.RefillAmmo = new System.Windows.Forms.GroupBox();
            this.refillAmmoMK = new System.Windows.Forms.CheckBox();
            this.refillAmmoCombo = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.refillAmmoCheckbox = new System.Windows.Forms.CheckBox();
            this.fullCapacities = new System.Windows.Forms.Button();
            this.magic80 = new System.Windows.Forms.Button();
            this.fullHealth = new System.Windows.Forms.Button();
            this.infArrows = new System.Windows.Forms.Button();
            this.infBombs = new System.Windows.Forms.Button();
            this.allSongs = new System.Windows.Forms.Button();
            this.mainFeaturesPanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.fetchAllTeleport = new System.Windows.Forms.Button();
            this.fetchLayer = new System.Windows.Forms.Button();
            this.fetchSpawnId = new System.Windows.Forms.Button();
            this.fetchRoomId = new System.Windows.Forms.Button();
            this.fetchStage = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.layerLoader = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.spawnIdLoader = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.roomIdLoader = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.stageNameLoader = new System.Windows.Forms.TextBox();
            this.triggerLoadingButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fetchAllLink = new System.Windows.Forms.Button();
            this.fetchSA = new System.Windows.Forms.Button();
            this.fetchSpeed = new System.Windows.Forms.Button();
            this.fetchAngle = new System.Windows.Forms.Button();
            this.fetchZ = new System.Windows.Forms.Button();
            this.fetchY = new System.Windows.Forms.Button();
            this.fetchX = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.restorePositionButton = new System.Windows.Forms.Button();
            this.healthNumber = new System.Windows.Forms.NumericUpDown();
            this.setHealthButton = new System.Windows.Forms.Button();
            this.storePositionButton = new System.Windows.Forms.Button();
            this.magicNumber = new System.Windows.Forms.NumericUpDown();
            this.setMagicButton = new System.Windows.Forms.Button();
            this.angleNumber = new System.Windows.Forms.NumericUpDown();
            this.setAngleButton = new System.Windows.Forms.Button();
            this.xNumber = new System.Windows.Forms.NumericUpDown();
            this.speedAngleNumber = new System.Windows.Forms.NumericUpDown();
            this.setSAButton = new System.Windows.Forms.Button();
            this.yNumber = new System.Windows.Forms.NumericUpDown();
            this.zNumber = new System.Windows.Forms.NumericUpDown();
            this.setPositionButton = new System.Windows.Forms.Button();
            this.speedNumber = new System.Windows.Forms.NumericUpDown();
            this.setSpeedButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.refillArrowsButton = new System.Windows.Forms.Button();
            this.refillBombsButton = new System.Windows.Forms.Button();
            this.refillMagicButton = new System.Windows.Forms.Button();
            this.refillHealthButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.doorCancelButton = new System.Windows.Forms.Button();
            this.removeStorageButton = new System.Windows.Forms.Button();
            this.chestStorageButton = new System.Windows.Forms.Button();
            this.getStorageButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetCollisionButton = new System.Windows.Forms.Button();
            this.reloadMapButton = new System.Windows.Forms.Button();
            this.softResetButton = new System.Windows.Forms.Button();
            this.dataViewerPanel = new System.Windows.Forms.Panel();
            this.advancedPanel = new System.Windows.Forms.Panel();
            this.memViewer = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.ListBox();
            this.addItem = new System.Windows.Forms.Button();
            this.removeItem = new System.Windows.Forms.Button();
            this.slotList = new System.Windows.Forms.ListBox();
            this.peekButton = new System.Windows.Forms.Button();
            this.pokeButton = new System.Windows.Forms.Button();
            this.typeDropdown = new System.Windows.Forms.ComboBox();
            this.valueTextbox = new System.Windows.Forms.TextBox();
            this.memoryAddress = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.mainFeatures = new System.Windows.Forms.Button();
            this.miscFeatures = new System.Windows.Forms.Button();
            this.dataViewer = new System.Windows.Forms.Button();
            this.advanced = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.teleporter = new System.Windows.Forms.Button();
            this.detachDataViewer = new System.Windows.Forms.Button();
            this.memfilesManager = new System.Windows.Forms.Button();
            this.itemManagerButton = new System.Windows.Forms.Button();
            this.itemsManager = new System.Windows.Forms.Panel();
            this.autoupdateTracker = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.setHC = new System.Windows.Forms.Button();
            this.setHCValue = new System.Windows.Forms.NumericUpDown();
            this.giveAll = new System.Windows.Forms.Button();
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.nayrusPearlCheck = new WWHDHacker.CheckBoxImage();
            this.faroresPearlCheck = new WWHDHacker.CheckBoxImage();
            this.dinsPearlCheck = new WWHDHacker.CheckBoxImage();
            this.triforceCheck = new WWHDHacker.CheckBoxImage();
            this.quiverCheck = new WWHDHacker.CheckBoxImage();
            this.bombBagCheck = new WWHDHacker.CheckBoxImage();
            this.magicCheck = new WWHDHacker.CheckBoxImage();
            this.walletCheck = new WWHDHacker.CheckBoxImage();
            this.heroCharmCheck = new WWHDHacker.CheckBoxImage();
            this.songOfPassingCheck = new WWHDHacker.CheckBoxImage();
            this.windGodAriaCheck = new WWHDHacker.CheckBoxImage();
            this.earthGodLyricCheck = new WWHDHacker.CheckBoxImage();
            this.commandMelodyCheck = new WWHDHacker.CheckBoxImage();
            this.balladOfGalesCheck = new WWHDHacker.CheckBoxImage();
            this.windsRequiemCheck = new WWHDHacker.CheckBoxImage();
            this.bottleCheck = new WWHDHacker.CheckBoxImage();
            this.powerBraceletsCheck = new WWHDHacker.CheckBoxImage();
            this.skullHammerCheck = new WWHDHacker.CheckBoxImage();
            this.hookshotCheck = new WWHDHacker.CheckBoxImage();
            this.deliveryBagCheck = new WWHDHacker.CheckBoxImage();
            this.noteToMomCheck = new WWHDHacker.CheckBoxImage();
            this.moblinsLetterCheck = new WWHDHacker.CheckBoxImage();
            this.maggiesLetterCheck = new WWHDHacker.CheckBoxImage();
            this.cabanaDeedCheck = new WWHDHacker.CheckBoxImage();
            this.shieldCheck = new WWHDHacker.CheckBoxImage();
            this.bombsCheck = new WWHDHacker.CheckBoxImage();
            this.bowCheck = new WWHDHacker.CheckBoxImage();
            this.baitBagCheck = new WWHDHacker.CheckBoxImage();
            this.magicArmorCheck = new WWHDHacker.CheckBoxImage();
            this.ironBootsCheck = new WWHDHacker.CheckBoxImage();
            this.pictoboxCheck = new WWHDHacker.CheckBoxImage();
            this.tingleBottleCheck = new WWHDHacker.CheckBoxImage();
            this.swordCheck = new WWHDHacker.CheckBoxImage();
            this.leafCheck = new WWHDHacker.CheckBoxImage();
            this.boomerangCheck = new WWHDHacker.CheckBoxImage();
            this.spoilsBagCheck = new WWHDHacker.CheckBoxImage();
            this.grapplingHookCheck = new WWHDHacker.CheckBoxImage();
            this.windWakerCheck = new WWHDHacker.CheckBoxImage();
            this.sailCheck = new WWHDHacker.CheckBoxImage();
            this.telescopeCheck = new WWHDHacker.CheckBoxImage();
            this.itemsList = new System.Windows.Forms.ImageList(this.components);
            this.CheckInv = new System.Windows.Forms.Timer(this.components);
            this.memfilesPanel = new System.Windows.Forms.Panel();
            this.loadMemfile = new System.Windows.Forms.Button();
            this.createMemfile = new System.Windows.Forms.Button();
            this.teleporterPanel = new System.Windows.Forms.Panel();
            this.displayOnMap = new System.Windows.Forms.CheckBox();
            this.transparentLayer = new System.Windows.Forms.Panel();
            this.movingLink = new System.Windows.Forms.PictureBox();
            this.teleporterMap = new System.Windows.Forms.PictureBox();
            this.addedRemoved = new System.Windows.Forms.Label();
            this.teleporterToggleFavorites = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teleporterRoomId = new System.Windows.Forms.TextBox();
            this.teleporterLayer = new System.Windows.Forms.TextBox();
            this.teleporterSpawnId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLocationLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teleporterToggleHyrule = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subAreas = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.islandLabel = new System.Windows.Forms.Label();
            this.miscFeaturesPanel.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.Levitate.SuspendLayout();
            this.DoorCancel.SuspendLayout();
            this.Superspeed.SuspendLayout();
            this.Storage.SuspendLayout();
            this.WindDirection.SuspendLayout();
            this.MasterkeyGroup.SuspendLayout();
            this.SaveReloadPos.SuspendLayout();
            this.ReloadRoom.SuspendLayout();
            this.RefillHealth.SuspendLayout();
            this.RefillMagic.SuspendLayout();
            this.RefillAmmo.SuspendLayout();
            this.mainFeaturesPanel.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magicNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedAngleNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumber)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.advancedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memViewer)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.itemsManager.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setHCValue)).BeginInit();
            this.itemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nayrusPearlCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faroresPearlCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinsPearlCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triforceCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiverCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombBagCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magicCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroCharmCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songOfPassingCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windGodAriaCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earthGodLyricCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandMelodyCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balladOfGalesCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windsRequiemCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottleCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerBraceletsCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skullHammerCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hookshotCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBagCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteToMomCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moblinsLetterCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maggiesLetterCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabanaDeedCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombsCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baitBagCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magicArmorCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ironBootsCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictoboxCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tingleBottleCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leafCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomerangCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoilsBagCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapplingHookCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windWakerCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sailCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telescopeCheck)).BeginInit();
            this.memfilesPanel.SuspendLayout();
            this.teleporterPanel.SuspendLayout();
            this.transparentLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movingLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teleporterMap)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(56, 12);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(158, 20);
            this.ipTextBox.TabIndex = 1;
            this.ipTextBox.Text = "192.168.";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(220, 10);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wii U IP:";
            // 
            // miscFeaturesPanel
            // 
            this.miscFeaturesPanel.Controls.Add(this.groupBox11);
            this.miscFeaturesPanel.Controls.Add(this.groupBox10);
            this.miscFeaturesPanel.Controls.Add(this.groupBox9);
            this.miscFeaturesPanel.Controls.Add(this.displayMacros);
            this.miscFeaturesPanel.Controls.Add(this.warningRuns);
            this.miscFeaturesPanel.Controls.Add(this.Levitate);
            this.miscFeaturesPanel.Controls.Add(this.DoorCancel);
            this.miscFeaturesPanel.Controls.Add(this.Superspeed);
            this.miscFeaturesPanel.Controls.Add(this.Storage);
            this.miscFeaturesPanel.Controls.Add(this.WindDirection);
            this.miscFeaturesPanel.Controls.Add(this.MasterkeyGroup);
            this.miscFeaturesPanel.Controls.Add(this.SaveReloadPos);
            this.miscFeaturesPanel.Controls.Add(this.ReloadRoom);
            this.miscFeaturesPanel.Controls.Add(this.RefillHealth);
            this.miscFeaturesPanel.Controls.Add(this.RefillMagic);
            this.miscFeaturesPanel.Controls.Add(this.RefillAmmo);
            this.miscFeaturesPanel.Location = new System.Drawing.Point(7, 70);
            this.miscFeaturesPanel.Name = "miscFeaturesPanel";
            this.miscFeaturesPanel.Size = new System.Drawing.Size(803, 348);
            this.miscFeaturesPanel.TabIndex = 16;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.infHealth);
            this.groupBox11.Controls.Add(this.infMagic);
            this.groupBox11.Controls.Add(this.infAir);
            this.groupBox11.Location = new System.Drawing.Point(689, 251);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(105, 91);
            this.groupBox11.TabIndex = 58;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Infinite";
            // 
            // infHealth
            // 
            this.infHealth.AutoSize = true;
            this.infHealth.Location = new System.Drawing.Point(9, 22);
            this.infHealth.Name = "infHealth";
            this.infHealth.Size = new System.Drawing.Size(91, 17);
            this.infHealth.TabIndex = 34;
            this.infHealth.Text = "Infinite Health";
            this.infHealth.UseVisualStyleBackColor = true;
            // 
            // infMagic
            // 
            this.infMagic.AutoSize = true;
            this.infMagic.Location = new System.Drawing.Point(9, 45);
            this.infMagic.Name = "infMagic";
            this.infMagic.Size = new System.Drawing.Size(89, 17);
            this.infMagic.TabIndex = 35;
            this.infMagic.Text = "Infinite Magic";
            this.infMagic.UseVisualStyleBackColor = true;
            // 
            // infAir
            // 
            this.infAir.AutoSize = true;
            this.infAir.Location = new System.Drawing.Point(9, 69);
            this.infAir.Name = "infAir";
            this.infAir.Size = new System.Drawing.Size(72, 17);
            this.infAir.TabIndex = 36;
            this.infAir.Text = "Infinite Air";
            this.infAir.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.removeTunic);
            this.groupBox10.Controls.Add(this.giveTunic);
            this.groupBox10.Controls.Add(this.refreshAS);
            this.groupBox10.Controls.Add(this.animSet2);
            this.groupBox10.Controls.Add(this.animSet1);
            this.groupBox10.Controls.Add(this.currentAnimSet);
            this.groupBox10.Location = new System.Drawing.Point(510, 5);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(284, 117);
            this.groupBox10.TabIndex = 57;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Flags";
            // 
            // removeTunic
            // 
            this.removeTunic.Location = new System.Drawing.Point(147, 81);
            this.removeTunic.Name = "removeTunic";
            this.removeTunic.Size = new System.Drawing.Size(113, 23);
            this.removeTunic.TabIndex = 45;
            this.removeTunic.Text = "Remove Tunic";
            this.removeTunic.UseVisualStyleBackColor = true;
            this.removeTunic.Click += new System.EventHandler(this.removeTunic_Click);
            // 
            // giveTunic
            // 
            this.giveTunic.Location = new System.Drawing.Point(15, 81);
            this.giveTunic.Name = "giveTunic";
            this.giveTunic.Size = new System.Drawing.Size(113, 23);
            this.giveTunic.TabIndex = 43;
            this.giveTunic.Text = "Give Tunic";
            this.giveTunic.UseVisualStyleBackColor = true;
            this.giveTunic.Click += new System.EventHandler(this.giveTunic_Click);
            // 
            // refreshAS
            // 
            this.refreshAS.Location = new System.Drawing.Point(161, 24);
            this.refreshAS.Name = "refreshAS";
            this.refreshAS.Size = new System.Drawing.Size(99, 23);
            this.refreshAS.TabIndex = 42;
            this.refreshAS.Text = "Refresh anim set";
            this.refreshAS.UseVisualStyleBackColor = true;
            this.refreshAS.Click += new System.EventHandler(this.refreshAS_Click);
            // 
            // animSet2
            // 
            this.animSet2.Location = new System.Drawing.Point(147, 50);
            this.animSet2.Name = "animSet2";
            this.animSet2.Size = new System.Drawing.Size(113, 23);
            this.animSet2.TabIndex = 39;
            this.animSet2.Text = "Anim set 2";
            this.animSet2.UseVisualStyleBackColor = true;
            this.animSet2.Click += new System.EventHandler(this.animSet2_Click);
            // 
            // animSet1
            // 
            this.animSet1.Location = new System.Drawing.Point(15, 50);
            this.animSet1.Name = "animSet1";
            this.animSet1.Size = new System.Drawing.Size(113, 23);
            this.animSet1.TabIndex = 40;
            this.animSet1.Text = "Anim set 1";
            this.animSet1.UseVisualStyleBackColor = true;
            this.animSet1.Click += new System.EventHandler(this.animSet1_Click);
            // 
            // currentAnimSet
            // 
            this.currentAnimSet.AutoSize = true;
            this.currentAnimSet.Location = new System.Drawing.Point(12, 30);
            this.currentAnimSet.Name = "currentAnimSet";
            this.currentAnimSet.Size = new System.Drawing.Size(138, 13);
            this.currentAnimSet.TabIndex = 41;
            this.currentAnimSet.Text = "Current anim set : Unknown";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.pauseGame);
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Controls.Add(this.resumeGame);
            this.groupBox9.Location = new System.Drawing.Point(539, 246);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(141, 96);
            this.groupBox9.TabIndex = 56;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Frame advance";
            // 
            // pauseGame
            // 
            this.pauseGame.Location = new System.Drawing.Point(7, 17);
            this.pauseGame.Name = "pauseGame";
            this.pauseGame.Size = new System.Drawing.Size(123, 23);
            this.pauseGame.TabIndex = 38;
            this.pauseGame.Text = "Pause";
            this.pauseGame.UseVisualStyleBackColor = true;
            this.pauseGame.Click += new System.EventHandler(this.pauseGame_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "Advance one frame";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // resumeGame
            // 
            this.resumeGame.Location = new System.Drawing.Point(7, 44);
            this.resumeGame.Name = "resumeGame";
            this.resumeGame.Size = new System.Drawing.Size(123, 23);
            this.resumeGame.TabIndex = 37;
            this.resumeGame.Text = "Resume";
            this.resumeGame.UseVisualStyleBackColor = true;
            this.resumeGame.Click += new System.EventHandler(this.resumeGame_Click);
            // 
            // displayMacros
            // 
            this.displayMacros.AutoSize = true;
            this.displayMacros.Location = new System.Drawing.Point(689, 216);
            this.displayMacros.Name = "displayMacros";
            this.displayMacros.Size = new System.Drawing.Size(101, 30);
            this.displayMacros.TabIndex = 55;
            this.displayMacros.Text = "Display Macros \r\nused on screen";
            this.displayMacros.UseVisualStyleBackColor = true;
            this.displayMacros.CheckedChanged += new System.EventHandler(this.displayMacros_CheckedChanged);
            // 
            // warningRuns
            // 
            this.warningRuns.AutoSize = true;
            this.warningRuns.Location = new System.Drawing.Point(690, 186);
            this.warningRuns.Name = "warningRuns";
            this.warningRuns.Size = new System.Drawing.Size(102, 30);
            this.warningRuns.TabIndex = 54;
            this.warningRuns.Text = "Warning before \r\nstarting a run";
            this.warningRuns.UseVisualStyleBackColor = true;
            this.warningRuns.CheckedChanged += new System.EventHandler(this.warningRuns_CheckedChanged);
            // 
            // Levitate
            // 
            this.Levitate.Controls.Add(this.levitateMK);
            this.Levitate.Controls.Add(this.label21);
            this.Levitate.Controls.Add(this.levitateCombo);
            this.Levitate.Controls.Add(this.lToLevitateCheckbox);
            this.Levitate.Location = new System.Drawing.Point(5, 3);
            this.Levitate.Name = "Levitate";
            this.Levitate.Size = new System.Drawing.Size(178, 58);
            this.Levitate.TabIndex = 47;
            this.Levitate.TabStop = false;
            this.Levitate.Text = "Levitate";
            // 
            // levitateMK
            // 
            this.levitateMK.AutoSize = true;
            this.levitateMK.Checked = true;
            this.levitateMK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.levitateMK.Location = new System.Drawing.Point(101, 15);
            this.levitateMK.Name = "levitateMK";
            this.levitateMK.Size = new System.Drawing.Size(75, 17);
            this.levitateMK.TabIndex = 48;
            this.levitateMK.Text = "Masterkey";
            this.levitateMK.UseVisualStyleBackColor = true;
            this.levitateMK.CheckedChanged += new System.EventHandler(this.levitateMK_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Button";
            // 
            // levitateCombo
            // 
            this.levitateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levitateCombo.FormattingEnabled = true;
            this.levitateCombo.Location = new System.Drawing.Point(3, 33);
            this.levitateCombo.Name = "levitateCombo";
            this.levitateCombo.Size = new System.Drawing.Size(102, 21);
            this.levitateCombo.TabIndex = 46;
            this.levitateCombo.SelectedIndexChanged += new System.EventHandler(this.levitateCombo_SelectedIndexChanged);
            // 
            // lToLevitateCheckbox
            // 
            this.lToLevitateCheckbox.AutoSize = true;
            this.lToLevitateCheckbox.Checked = true;
            this.lToLevitateCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lToLevitateCheckbox.Location = new System.Drawing.Point(110, 39);
            this.lToLevitateCheckbox.Name = "lToLevitateCheckbox";
            this.lToLevitateCheckbox.Size = new System.Drawing.Size(65, 17);
            this.lToLevitateCheckbox.TabIndex = 23;
            this.lToLevitateCheckbox.Text = "Enabled";
            this.lToLevitateCheckbox.UseVisualStyleBackColor = true;
            this.lToLevitateCheckbox.CheckedChanged += new System.EventHandler(this.lToLevitateCheckbox_CheckedChanged);
            // 
            // DoorCancel
            // 
            this.DoorCancel.Controls.Add(this.doorCancelMK);
            this.DoorCancel.Controls.Add(this.label22);
            this.DoorCancel.Controls.Add(this.doorCancelCombo);
            this.DoorCancel.Controls.Add(this.doorCancelCheckbox);
            this.DoorCancel.Location = new System.Drawing.Point(5, 66);
            this.DoorCancel.Name = "DoorCancel";
            this.DoorCancel.Size = new System.Drawing.Size(178, 61);
            this.DoorCancel.TabIndex = 48;
            this.DoorCancel.TabStop = false;
            this.DoorCancel.Text = "Door Cancel";
            // 
            // doorCancelMK
            // 
            this.doorCancelMK.AutoSize = true;
            this.doorCancelMK.Checked = true;
            this.doorCancelMK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doorCancelMK.Location = new System.Drawing.Point(101, 13);
            this.doorCancelMK.Name = "doorCancelMK";
            this.doorCancelMK.Size = new System.Drawing.Size(75, 17);
            this.doorCancelMK.TabIndex = 49;
            this.doorCancelMK.Text = "Masterkey";
            this.doorCancelMK.UseVisualStyleBackColor = true;
            this.doorCancelMK.CheckedChanged += new System.EventHandler(this.doorCancelMK_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 47;
            this.label22.Text = "Button";
            // 
            // doorCancelCombo
            // 
            this.doorCancelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doorCancelCombo.FormattingEnabled = true;
            this.doorCancelCombo.Location = new System.Drawing.Point(3, 33);
            this.doorCancelCombo.Name = "doorCancelCombo";
            this.doorCancelCombo.Size = new System.Drawing.Size(102, 21);
            this.doorCancelCombo.TabIndex = 46;
            this.doorCancelCombo.SelectedIndexChanged += new System.EventHandler(this.doorCancelCombo_SelectedIndexChanged);
            // 
            // doorCancelCheckbox
            // 
            this.doorCancelCheckbox.AutoSize = true;
            this.doorCancelCheckbox.Checked = true;
            this.doorCancelCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doorCancelCheckbox.Location = new System.Drawing.Point(111, 36);
            this.doorCancelCheckbox.Name = "doorCancelCheckbox";
            this.doorCancelCheckbox.Size = new System.Drawing.Size(65, 17);
            this.doorCancelCheckbox.TabIndex = 24;
            this.doorCancelCheckbox.Text = "Enabled";
            this.doorCancelCheckbox.UseVisualStyleBackColor = true;
            this.doorCancelCheckbox.CheckedChanged += new System.EventHandler(this.doorCancelCheckbox_CheckedChanged);
            // 
            // Superspeed
            // 
            this.Superspeed.Controls.Add(this.superswimMK);
            this.Superspeed.Controls.Add(this.label23);
            this.Superspeed.Controls.Add(this.superswimCombo);
            this.Superspeed.Controls.Add(this.superswimCheckbox);
            this.Superspeed.Controls.Add(this.alternativeDpadRight);
            this.Superspeed.Location = new System.Drawing.Point(5, 134);
            this.Superspeed.Name = "Superspeed";
            this.Superspeed.Size = new System.Drawing.Size(178, 90);
            this.Superspeed.TabIndex = 49;
            this.Superspeed.TabStop = false;
            this.Superspeed.Text = "Superswim";
            // 
            // superswimMK
            // 
            this.superswimMK.AutoSize = true;
            this.superswimMK.Checked = true;
            this.superswimMK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.superswimMK.Location = new System.Drawing.Point(101, 13);
            this.superswimMK.Name = "superswimMK";
            this.superswimMK.Size = new System.Drawing.Size(75, 17);
            this.superswimMK.TabIndex = 50;
            this.superswimMK.Text = "Masterkey";
            this.superswimMK.UseVisualStyleBackColor = true;
            this.superswimMK.CheckedChanged += new System.EventHandler(this.superswimMK_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "Button";
            // 
            // superswimCombo
            // 
            this.superswimCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.superswimCombo.FormattingEnabled = true;
            this.superswimCombo.Location = new System.Drawing.Point(3, 33);
            this.superswimCombo.Name = "superswimCombo";
            this.superswimCombo.Size = new System.Drawing.Size(102, 21);
            this.superswimCombo.TabIndex = 46;
            this.superswimCombo.SelectedIndexChanged += new System.EventHandler(this.superspeedCombo_SelectedIndexChanged);
            // 
            // superswimCheckbox
            // 
            this.superswimCheckbox.AutoSize = true;
            this.superswimCheckbox.Checked = true;
            this.superswimCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.superswimCheckbox.Location = new System.Drawing.Point(111, 36);
            this.superswimCheckbox.Name = "superswimCheckbox";
            this.superswimCheckbox.Size = new System.Drawing.Size(65, 17);
            this.superswimCheckbox.TabIndex = 25;
            this.superswimCheckbox.Text = "Enabled";
            this.superswimCheckbox.UseVisualStyleBackColor = true;
            this.superswimCheckbox.CheckedChanged += new System.EventHandler(this.superswimCheckbox_CheckedChanged);
            // 
            // alternativeDpadRight
            // 
            this.alternativeDpadRight.AutoSize = true;
            this.alternativeDpadRight.Location = new System.Drawing.Point(3, 55);
            this.alternativeDpadRight.Name = "alternativeDpadRight";
            this.alternativeDpadRight.Size = new System.Drawing.Size(153, 30);
            this.alternativeDpadRight.TabIndex = 43;
            this.alternativeDpadRight.Text = "ZL to charge positive,\r\nnothing to charge negative";
            this.alternativeDpadRight.UseVisualStyleBackColor = true;
            this.alternativeDpadRight.CheckedChanged += new System.EventHandler(this.alternativeDpadRight_CheckedChanged);
            // 
            // Storage
            // 
            this.Storage.Controls.Add(this.storageMK);
            this.Storage.Controls.Add(this.label24);
            this.Storage.Controls.Add(this.storageCombo);
            this.Storage.Controls.Add(this.storageCheckbox);
            this.Storage.Location = new System.Drawing.Point(5, 228);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(178, 58);
            this.Storage.TabIndex = 50;
            this.Storage.TabStop = false;
            this.Storage.Text = "Storage";
            // 
            // storageMK
            // 
            this.storageMK.AutoSize = true;
            this.storageMK.Checked = true;
            this.storageMK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.storageMK.Location = new System.Drawing.Point(101, 12);
            this.storageMK.Name = "storageMK";
            this.storageMK.Size = new System.Drawing.Size(75, 17);
            this.storageMK.TabIndex = 51;
            this.storageMK.Text = "Masterkey";
            this.storageMK.UseVisualStyleBackColor = true;
            this.storageMK.CheckedChanged += new System.EventHandler(this.storageMK_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 47;
            this.label24.Text = "Button";
            // 
            // storageCombo
            // 
            this.storageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storageCombo.FormattingEnabled = true;
            this.storageCombo.Location = new System.Drawing.Point(3, 33);
            this.storageCombo.Name = "storageCombo";
            this.storageCombo.Size = new System.Drawing.Size(102, 21);
            this.storageCombo.TabIndex = 46;
            this.storageCombo.SelectedIndexChanged += new System.EventHandler(this.storageCombo_SelectedIndexChanged);
            // 
            // storageCheckbox
            // 
            this.storageCheckbox.AutoSize = true;
            this.storageCheckbox.Checked = true;
            this.storageCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.storageCheckbox.Location = new System.Drawing.Point(110, 35);
            this.storageCheckbox.Name = "storageCheckbox";
            this.storageCheckbox.Size = new System.Drawing.Size(65, 17);
            this.storageCheckbox.TabIndex = 31;
            this.storageCheckbox.Text = "Enabled";
            this.storageCheckbox.UseVisualStyleBackColor = true;
            this.storageCheckbox.CheckedChanged += new System.EventHandler(this.storageCheckbox_CheckedChanged);
            // 
            // WindDirection
            // 
            this.WindDirection.Controls.Add(this.windDirectionMK);
            this.WindDirection.Controls.Add(this.label30);
            this.WindDirection.Controls.Add(this.windDirectionCombo);
            this.WindDirection.Controls.Add(this.changeWindCheckbox);
            this.WindDirection.Location = new System.Drawing.Point(5, 288);
            this.WindDirection.Name = "WindDirection";
            this.WindDirection.Size = new System.Drawing.Size(178, 58);
            this.WindDirection.TabIndex = 51;
            this.WindDirection.TabStop = false;
            this.WindDirection.Text = "Change wind direction";
            // 
            // windDirectionMK
            // 
            this.windDirectionMK.AutoSize = true;
            this.windDirectionMK.Checked = true;
            this.windDirectionMK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.windDirectionMK.Location = new System.Drawing.Point(101, 16);
            this.windDirectionMK.Name = "windDirectionMK";
            this.windDirectionMK.Size = new System.Drawing.Size(75, 17);
            this.windDirectionMK.TabIndex = 52;
            this.windDirectionMK.Text = "Masterkey";
            this.windDirectionMK.UseVisualStyleBackColor = true;
            this.windDirectionMK.CheckedChanged += new System.EventHandler(this.windDirectionMK_CheckedChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 20);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 13);
            this.label30.TabIndex = 47;
            this.label30.Text = "Button";
            // 
            // windDirectionCombo
            // 
            this.windDirectionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.windDirectionCombo.FormattingEnabled = true;
            this.windDirectionCombo.Location = new System.Drawing.Point(3, 33);
            this.windDirectionCombo.Name = "windDirectionCombo";
            this.windDirectionCombo.Size = new System.Drawing.Size(102, 21);
            this.windDirectionCombo.TabIndex = 46;
            this.windDirectionCombo.SelectedIndexChanged += new System.EventHandler(this.windDirectionCombo_SelectedIndexChanged);
            // 
            // changeWindCheckbox
            // 
            this.changeWindCheckbox.AutoSize = true;
            this.changeWindCheckbox.Checked = true;
            this.changeWindCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.changeWindCheckbox.Location = new System.Drawing.Point(110, 36);
            this.changeWindCheckbox.Name = "changeWindCheckbox";
            this.changeWindCheckbox.Size = new System.Drawing.Size(65, 17);
            this.changeWindCheckbox.TabIndex = 45;
            this.changeWindCheckbox.Text = "Enabled";
            this.changeWindCheckbox.UseVisualStyleBackColor = true;
            this.changeWindCheckbox.CheckedChanged += new System.EventHandler(this.changeWindCheckbox_CheckedChanged);
            // 
            // MasterkeyGroup
            // 
            this.MasterkeyGroup.Controls.Add(this.label25);
            this.MasterkeyGroup.Controls.Add(this.masterkeyCombo);
            this.MasterkeyGroup.Controls.Add(this.masterkey);
            this.MasterkeyGroup.Location = new System.Drawing.Point(202, 3);
            this.MasterkeyGroup.Name = "MasterkeyGroup";
            this.MasterkeyGroup.Size = new System.Drawing.Size(178, 58);
            this.MasterkeyGroup.TabIndex = 51;
            this.MasterkeyGroup.TabStop = false;
            this.MasterkeyGroup.Text = "Masterkey";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 47;
            this.label25.Text = "Button";
            // 
            // masterkeyCombo
            // 
            this.masterkeyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.masterkeyCombo.FormattingEnabled = true;
            this.masterkeyCombo.Location = new System.Drawing.Point(3, 33);
            this.masterkeyCombo.Name = "masterkeyCombo";
            this.masterkeyCombo.Size = new System.Drawing.Size(102, 21);
            this.masterkeyCombo.TabIndex = 46;
            this.masterkeyCombo.SelectedIndexChanged += new System.EventHandler(this.masterkeyCombo_SelectedIndexChanged);
            // 
            // masterkey
            // 
            this.masterkey.AutoSize = true;
            this.masterkey.Checked = true;
            this.masterkey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.masterkey.Location = new System.Drawing.Point(110, 35);
            this.masterkey.Name = "masterkey";
            this.masterkey.Size = new System.Drawing.Size(65, 17);
            this.masterkey.TabIndex = 21;
            this.masterkey.Text = "Enabled";
            this.masterkey.UseVisualStyleBackColor = true;
            this.masterkey.CheckedChanged += new System.EventHandler(this.masterkey_CheckedChanged);
            // 
            // SaveReloadPos
            // 
            this.SaveReloadPos.Controls.Add(this.saveReloadMK);
            this.SaveReloadPos.Controls.Add(this.label32);
            this.SaveReloadPos.Controls.Add(this.storePositionCombo);
            this.SaveReloadPos.Controls.Add(this.restorePositionCombo);
            this.SaveReloadPos.Controls.Add(this.label26);
            this.SaveReloadPos.Controls.Add(this.alternativeMemfiles);
            this.SaveReloadPos.Controls.Add(this.storeRestoreCheckbox);
            this.SaveReloadPos.Location = new System.Drawing.Point(202, 68);
            this.SaveReloadPos.Name = "SaveReloadPos";
            this.SaveReloadPos.Size = new System.Drawing.Size(289, 96);
            this.SaveReloadPos.TabIndex = 52;
            this.SaveReloadPos.TabStop = false;
            this.SaveReloadPos.Text = "Save/Reload position";
            // 
            // saveReloadMK
            // 
            this.saveReloadMK.AutoSize = true;
            this.saveReloadMK.Checked = true;
            this.saveReloadMK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveReloadMK.Location = new System.Drawing.Point(190, 33);
            this.saveReloadMK.Name = "saveReloadMK";
            this.saveReloadMK.Size = new System.Drawing.Size(75, 17);
            this.saveReloadMK.TabIndex = 48;
            this.saveReloadMK.Text = "Masterkey";
            this.saveReloadMK.UseVisualStyleBackColor = true;
            this.saveReloadMK.CheckedChanged += new System.EventHandler(this.saveReloadMK_CheckedChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 55);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(75, 13);
            this.label32.TabIndex = 49;
            this.label32.Text = "Reload Button";
            // 
            // storePositionCombo
            // 
            this.storePositionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.storePositionCombo.FormattingEnabled = true;
            this.storePositionCombo.Location = new System.Drawing.Point(6, 31);
            this.storePositionCombo.Name = "storePositionCombo";
            this.storePositionCombo.Size = new System.Drawing.Size(102, 21);
            this.storePositionCombo.TabIndex = 46;
            this.storePositionCombo.SelectedIndexChanged += new System.EventHandler(this.savePosCombo_SelectedIndexChanged);
            // 
            // restorePositionCombo
            // 
            this.restorePositionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restorePositionCombo.FormattingEnabled = true;
            this.restorePositionCombo.Location = new System.Drawing.Point(6, 68);
            this.restorePositionCombo.Name = "restorePositionCombo";
            this.restorePositionCombo.Size = new System.Drawing.Size(102, 21);
            this.restorePositionCombo.TabIndex = 48;
            this.restorePositionCombo.SelectedIndexChanged += new System.EventHandler(this.reloadPosCombo_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "Save Button";
            // 
            // alternativeMemfiles
            // 
            this.alternativeMemfiles.AutoSize = true;
            this.alternativeMemfiles.Location = new System.Drawing.Point(113, 64);
            this.alternativeMemfiles.Name = "alternativeMemfiles";
            this.alternativeMemfiles.Size = new System.Drawing.Size(173, 30);
            this.alternativeMemfiles.TabIndex = 44;
            this.alternativeMemfiles.Text = "Switch for save temporary \r\nmemfile / load selected memfile\r\n";
            this.alternativeMemfiles.UseVisualStyleBackColor = true;
            this.alternativeMemfiles.CheckedChanged += new System.EventHandler(this.alternativeMemfiles_CheckedChanged);
            // 
            // storeRestoreCheckbox
            // 
            this.storeRestoreCheckbox.AutoSize = true;
            this.storeRestoreCheckbox.Checked = true;
            this.storeRestoreCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.storeRestoreCheckbox.Location = new System.Drawing.Point(114, 33);
            this.storeRestoreCheckbox.Name = "storeRestoreCheckbox";
            this.storeRestoreCheckbox.Size = new System.Drawing.Size(65, 17);
            this.storeRestoreCheckbox.TabIndex = 22;
            this.storeRestoreCheckbox.Text = "Enabled";
            this.storeRestoreCheckbox.UseVisualStyleBackColor = true;
            this.storeRestoreCheckbox.CheckedChanged += new System.EventHandler(this.storeRestoreCheckbox_CheckedChanged);
            // 
            // ReloadRoom
            // 
            this.ReloadRoom.Controls.Add(this.reloadRoomMK);
            this.ReloadRoom.Controls.Add(this.label27);
            this.ReloadRoom.Controls.Add(this.reloadRoomCombo);
            this.ReloadRoom.Controls.Add(this.reloadRoomCheckbox);
            this.ReloadRoom.Location = new System.Drawing.Point(202, 165);
            this.ReloadRoom.Name = "ReloadRoom";
            this.ReloadRoom.Size = new System.Drawing.Size(178, 58);
            this.ReloadRoom.TabIndex = 51;
            this.ReloadRoom.TabStop = false;
            this.ReloadRoom.Text = "Reload Room";
            // 
            // reloadRoomMK
            // 
            this.reloadRoomMK.AutoSize = true;
            this.reloadRoomMK.Checked = true;
            this.reloadRoomMK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reloadRoomMK.Location = new System.Drawing.Point(100, 16);
            this.reloadRoomMK.Name = "reloadRoomMK";
            this.reloadRoomMK.Size = new System.Drawing.Size(75, 17);
            this.reloadRoomMK.TabIndex = 48;
            this.reloadRoomMK.Text = "Masterkey";
            this.reloadRoomMK.UseVisualStyleBackColor = true;
            this.reloadRoomMK.CheckedChanged += new System.EventHandler(this.reloadRoomMK_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 13);
            this.label27.TabIndex = 47;
            this.label27.Text = "Button";
            // 
            // reloadRoomCombo
            // 
            this.reloadRoomCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reloadRoomCombo.FormattingEnabled = true;
            this.reloadRoomCombo.Location = new System.Drawing.Point(3, 33);
            this.reloadRoomCombo.Name = "reloadRoomCombo";
            this.reloadRoomCombo.Size = new System.Drawing.Size(102, 21);
            this.reloadRoomCombo.TabIndex = 46;
            this.reloadRoomCombo.SelectedIndexChanged += new System.EventHandler(this.reloadRoomCombo_SelectedIndexChanged);
            // 
            // reloadRoomCheckbox
            // 
            this.reloadRoomCheckbox.AutoSize = true;
            this.reloadRoomCheckbox.Checked = true;
            this.reloadRoomCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reloadRoomCheckbox.Location = new System.Drawing.Point(110, 35);
            this.reloadRoomCheckbox.Name = "reloadRoomCheckbox";
            this.reloadRoomCheckbox.Size = new System.Drawing.Size(65, 17);
            this.reloadRoomCheckbox.TabIndex = 26;
            this.reloadRoomCheckbox.Text = "Enabled";
            this.reloadRoomCheckbox.UseVisualStyleBackColor = true;
            this.reloadRoomCheckbox.CheckedChanged += new System.EventHandler(this.reloadRoomCheckbox_CheckedChanged);
            // 
            // RefillHealth
            // 
            this.RefillHealth.Controls.Add(this.refillHealthMK);
            this.RefillHealth.Controls.Add(this.label28);
            this.RefillHealth.Controls.Add(this.refillHealthCombo);
            this.RefillHealth.Controls.Add(this.refillHealthCheckbox);
            this.RefillHealth.Location = new System.Drawing.Point(202, 224);
            this.RefillHealth.Name = "RefillHealth";
            this.RefillHealth.Size = new System.Drawing.Size(178, 58);
            this.RefillHealth.TabIndex = 51;
            this.RefillHealth.TabStop = false;
            this.RefillHealth.Text = "Refill Health";
            // 
            // refillHealthMK
            // 
            this.refillHealthMK.AutoSize = true;
            this.refillHealthMK.Checked = true;
            this.refillHealthMK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.refillHealthMK.Location = new System.Drawing.Point(100, 16);
            this.refillHealthMK.Name = "refillHealthMK";
            this.refillHealthMK.Size = new System.Drawing.Size(75, 17);
            this.refillHealthMK.TabIndex = 49;
            this.refillHealthMK.Text = "Masterkey";
            this.refillHealthMK.UseVisualStyleBackColor = true;
            this.refillHealthMK.CheckedChanged += new System.EventHandler(this.refillHealthMK_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 20);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 13);
            this.label28.TabIndex = 47;
            this.label28.Text = "Button";
            // 
            // refillHealthCombo
            // 
            this.refillHealthCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.refillHealthCombo.FormattingEnabled = true;
            this.refillHealthCombo.Location = new System.Drawing.Point(3, 33);
            this.refillHealthCombo.Name = "refillHealthCombo";
            this.refillHealthCombo.Size = new System.Drawing.Size(102, 21);
            this.refillHealthCombo.TabIndex = 46;
            this.refillHealthCombo.SelectedIndexChanged += new System.EventHandler(this.refillHealthCombo_SelectedIndexChanged);
            // 
            // refillHealthCheckbox
            // 
            this.refillHealthCheckbox.AutoSize = true;
            this.refillHealthCheckbox.Checked = true;
            this.refillHealthCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.refillHealthCheckbox.Location = new System.Drawing.Point(110, 35);
            this.refillHealthCheckbox.Name = "refillHealthCheckbox";
            this.refillHealthCheckbox.Size = new System.Drawing.Size(65, 17);
            this.refillHealthCheckbox.TabIndex = 28;
            this.refillHealthCheckbox.Text = "Enabled";
            this.refillHealthCheckbox.UseVisualStyleBackColor = true;
            this.refillHealthCheckbox.CheckedChanged += new System.EventHandler(this.refillHealthCheckbox_CheckedChanged);
            // 
            // RefillMagic
            // 
            this.RefillMagic.Controls.Add(this.refillMagicMK);
            this.RefillMagic.Controls.Add(this.label31);
            this.RefillMagic.Controls.Add(this.refillMagicCombo);
            this.RefillMagic.Controls.Add(this.refillMagicCheckbox);
            this.RefillMagic.Location = new System.Drawing.Point(392, 168);
            this.RefillMagic.Name = "RefillMagic";
            this.RefillMagic.Size = new System.Drawing.Size(178, 58);
            this.RefillMagic.TabIndex = 53;
            this.RefillMagic.TabStop = false;
            this.RefillMagic.Text = "Refill Magic";
            // 
            // refillMagicMK
            // 
            this.refillMagicMK.AutoSize = true;
            this.refillMagicMK.Checked = true;
            this.refillMagicMK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.refillMagicMK.Location = new System.Drawing.Point(101, 16);
            this.refillMagicMK.Name = "refillMagicMK";
            this.refillMagicMK.Size = new System.Drawing.Size(75, 17);
            this.refillMagicMK.TabIndex = 51;
            this.refillMagicMK.Text = "Masterkey";
            this.refillMagicMK.UseVisualStyleBackColor = true;
            this.refillMagicMK.CheckedChanged += new System.EventHandler(this.refillMagicMK_CheckedChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(38, 13);
            this.label31.TabIndex = 47;
            this.label31.Text = "Button";
            // 
            // refillMagicCombo
            // 
            this.refillMagicCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.refillMagicCombo.FormattingEnabled = true;
            this.refillMagicCombo.Location = new System.Drawing.Point(3, 33);
            this.refillMagicCombo.Name = "refillMagicCombo";
            this.refillMagicCombo.Size = new System.Drawing.Size(102, 21);
            this.refillMagicCombo.TabIndex = 46;
            this.refillMagicCombo.SelectedIndexChanged += new System.EventHandler(this.refillMagicCombo_SelectedIndexChanged);
            // 
            // refillMagicCheckbox
            // 
            this.refillMagicCheckbox.AutoSize = true;
            this.refillMagicCheckbox.Checked = true;
            this.refillMagicCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.refillMagicCheckbox.Location = new System.Drawing.Point(111, 35);
            this.refillMagicCheckbox.Name = "refillMagicCheckbox";
            this.refillMagicCheckbox.Size = new System.Drawing.Size(65, 17);
            this.refillMagicCheckbox.TabIndex = 27;
            this.refillMagicCheckbox.Text = "Enabled";
            this.refillMagicCheckbox.UseVisualStyleBackColor = true;
            this.refillMagicCheckbox.CheckedChanged += new System.EventHandler(this.refillMagicCheckbox_CheckedChanged);
            // 
            // RefillAmmo
            // 
            this.RefillAmmo.Controls.Add(this.refillAmmoMK);
            this.RefillAmmo.Controls.Add(this.refillAmmoCombo);
            this.RefillAmmo.Controls.Add(this.label29);
            this.RefillAmmo.Controls.Add(this.refillAmmoCheckbox);
            this.RefillAmmo.Location = new System.Drawing.Point(202, 288);
            this.RefillAmmo.Name = "RefillAmmo";
            this.RefillAmmo.Size = new System.Drawing.Size(178, 58);
            this.RefillAmmo.TabIndex = 51;
            this.RefillAmmo.TabStop = false;
            this.RefillAmmo.Text = "Refill Ammo";
            // 
            // refillAmmoMK
            // 
            this.refillAmmoMK.AutoSize = true;
            this.refillAmmoMK.Checked = true;
            this.refillAmmoMK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.refillAmmoMK.Location = new System.Drawing.Point(100, 13);
            this.refillAmmoMK.Name = "refillAmmoMK";
            this.refillAmmoMK.Size = new System.Drawing.Size(75, 17);
            this.refillAmmoMK.TabIndex = 50;
            this.refillAmmoMK.Text = "Masterkey";
            this.refillAmmoMK.UseVisualStyleBackColor = true;
            this.refillAmmoMK.CheckedChanged += new System.EventHandler(this.refillAmmoMK_CheckedChanged);
            // 
            // refillAmmoCombo
            // 
            this.refillAmmoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.refillAmmoCombo.FormattingEnabled = true;
            this.refillAmmoCombo.Location = new System.Drawing.Point(3, 33);
            this.refillAmmoCombo.Name = "refillAmmoCombo";
            this.refillAmmoCombo.Size = new System.Drawing.Size(102, 21);
            this.refillAmmoCombo.TabIndex = 48;
            this.refillAmmoCombo.SelectedIndexChanged += new System.EventHandler(this.refillAmmoCombo_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 20);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(38, 13);
            this.label29.TabIndex = 47;
            this.label29.Text = "Button";
            // 
            // refillAmmoCheckbox
            // 
            this.refillAmmoCheckbox.AutoSize = true;
            this.refillAmmoCheckbox.Checked = true;
            this.refillAmmoCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.refillAmmoCheckbox.Location = new System.Drawing.Point(110, 35);
            this.refillAmmoCheckbox.Name = "refillAmmoCheckbox";
            this.refillAmmoCheckbox.Size = new System.Drawing.Size(65, 17);
            this.refillAmmoCheckbox.TabIndex = 29;
            this.refillAmmoCheckbox.Text = "Enabled";
            this.refillAmmoCheckbox.UseVisualStyleBackColor = true;
            this.refillAmmoCheckbox.CheckedChanged += new System.EventHandler(this.refillAmmoCheckbox_CheckedChanged);
            // 
            // fullCapacities
            // 
            this.fullCapacities.Location = new System.Drawing.Point(700, 282);
            this.fullCapacities.Name = "fullCapacities";
            this.fullCapacities.Size = new System.Drawing.Size(92, 23);
            this.fullCapacities.TabIndex = 21;
            this.fullCapacities.Text = "Full Capacities";
            this.fullCapacities.UseVisualStyleBackColor = true;
            this.fullCapacities.Click += new System.EventHandler(this.fullCapacities_Click);
            // 
            // magic80
            // 
            this.magic80.Location = new System.Drawing.Point(502, 311);
            this.magic80.Name = "magic80";
            this.magic80.Size = new System.Drawing.Size(94, 23);
            this.magic80.TabIndex = 33;
            this.magic80.Text = "80x Magic";
            this.magic80.UseVisualStyleBackColor = true;
            this.magic80.Click += new System.EventHandler(this.magic80_Click);
            // 
            // fullHealth
            // 
            this.fullHealth.Location = new System.Drawing.Point(602, 311);
            this.fullHealth.Name = "fullHealth";
            this.fullHealth.Size = new System.Drawing.Size(92, 23);
            this.fullHealth.TabIndex = 20;
            this.fullHealth.Text = "20 hearts";
            this.fullHealth.UseVisualStyleBackColor = true;
            this.fullHealth.Click += new System.EventHandler(this.fullHealth_Click);
            // 
            // infArrows
            // 
            this.infArrows.Location = new System.Drawing.Point(603, 282);
            this.infArrows.Name = "infArrows";
            this.infArrows.Size = new System.Drawing.Size(91, 23);
            this.infArrows.TabIndex = 32;
            this.infArrows.Text = "255 Max Arrows";
            this.infArrows.UseVisualStyleBackColor = true;
            this.infArrows.Click += new System.EventHandler(this.infArrows_Click);
            // 
            // infBombs
            // 
            this.infBombs.Location = new System.Drawing.Point(503, 282);
            this.infBombs.Name = "infBombs";
            this.infBombs.Size = new System.Drawing.Size(94, 23);
            this.infBombs.TabIndex = 14;
            this.infBombs.Text = "255 Max Bombs";
            this.infBombs.UseVisualStyleBackColor = true;
            this.infBombs.Click += new System.EventHandler(this.infBombs_Click);
            // 
            // allSongs
            // 
            this.allSongs.Location = new System.Drawing.Point(700, 311);
            this.allSongs.Name = "allSongs";
            this.allSongs.Size = new System.Drawing.Size(92, 23);
            this.allSongs.TabIndex = 16;
            this.allSongs.Text = "Give All Songs";
            this.allSongs.UseVisualStyleBackColor = true;
            this.allSongs.Click += new System.EventHandler(this.giveAllSongs_Click);
            // 
            // mainFeaturesPanel
            // 
            this.mainFeaturesPanel.Controls.Add(this.label16);
            this.mainFeaturesPanel.Controls.Add(this.groupBox7);
            this.mainFeaturesPanel.Controls.Add(this.groupBox5);
            this.mainFeaturesPanel.Controls.Add(this.groupBox4);
            this.mainFeaturesPanel.Controls.Add(this.groupBox2);
            this.mainFeaturesPanel.Controls.Add(this.groupBox1);
            this.mainFeaturesPanel.Location = new System.Drawing.Point(7, 70);
            this.mainFeaturesPanel.Name = "mainFeaturesPanel";
            this.mainFeaturesPanel.Size = new System.Drawing.Size(803, 348);
            this.mainFeaturesPanel.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(686, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 39);
            this.label16.TabIndex = 10;
            this.label16.Text = "Made by Teotia444\r\nThanks to the WWHD\r\ncommunity and friends";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.fetchAllTeleport);
            this.groupBox7.Controls.Add(this.fetchLayer);
            this.groupBox7.Controls.Add(this.fetchSpawnId);
            this.groupBox7.Controls.Add(this.fetchRoomId);
            this.groupBox7.Controls.Add(this.fetchStage);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.layerLoader);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.spawnIdLoader);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.roomIdLoader);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.stageNameLoader);
            this.groupBox7.Controls.Add(this.triggerLoadingButton);
            this.groupBox7.Location = new System.Drawing.Point(628, 14);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(161, 260);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Teleport";
            // 
            // fetchAllTeleport
            // 
            this.fetchAllTeleport.Location = new System.Drawing.Point(37, 187);
            this.fetchAllTeleport.Name = "fetchAllTeleport";
            this.fetchAllTeleport.Size = new System.Drawing.Size(84, 20);
            this.fetchAllTeleport.TabIndex = 32;
            this.fetchAllTeleport.Text = "Fetch all";
            this.fetchAllTeleport.UseVisualStyleBackColor = true;
            this.fetchAllTeleport.Click += new System.EventHandler(this.fetchAllTeleport_Click);
            // 
            // fetchLayer
            // 
            this.fetchLayer.Location = new System.Drawing.Point(99, 141);
            this.fetchLayer.Name = "fetchLayer";
            this.fetchLayer.Size = new System.Drawing.Size(47, 20);
            this.fetchLayer.TabIndex = 31;
            this.fetchLayer.Text = "Fetch";
            this.fetchLayer.UseVisualStyleBackColor = true;
            this.fetchLayer.Click += new System.EventHandler(this.fetchLayer_Click);
            // 
            // fetchSpawnId
            // 
            this.fetchSpawnId.Location = new System.Drawing.Point(99, 99);
            this.fetchSpawnId.Name = "fetchSpawnId";
            this.fetchSpawnId.Size = new System.Drawing.Size(47, 20);
            this.fetchSpawnId.TabIndex = 30;
            this.fetchSpawnId.Text = "Fetch";
            this.fetchSpawnId.UseVisualStyleBackColor = true;
            this.fetchSpawnId.Click += new System.EventHandler(this.fetchSpawnId_Click);
            // 
            // fetchRoomId
            // 
            this.fetchRoomId.Location = new System.Drawing.Point(99, 58);
            this.fetchRoomId.Name = "fetchRoomId";
            this.fetchRoomId.Size = new System.Drawing.Size(47, 20);
            this.fetchRoomId.TabIndex = 29;
            this.fetchRoomId.Text = "Fetch";
            this.fetchRoomId.UseVisualStyleBackColor = true;
            this.fetchRoomId.Click += new System.EventHandler(this.fetchRoomId_Click);
            // 
            // fetchStage
            // 
            this.fetchStage.Location = new System.Drawing.Point(99, 15);
            this.fetchStage.Name = "fetchStage";
            this.fetchStage.Size = new System.Drawing.Size(47, 20);
            this.fetchStage.TabIndex = 28;
            this.fetchStage.Text = "Fetch";
            this.fetchStage.UseVisualStyleBackColor = true;
            this.fetchStage.Click += new System.EventHandler(this.fetchStage_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Layer";
            // 
            // layerLoader
            // 
            this.layerLoader.Location = new System.Drawing.Point(6, 161);
            this.layerLoader.Name = "layerLoader";
            this.layerLoader.Size = new System.Drawing.Size(140, 20);
            this.layerLoader.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Spawn ID";
            // 
            // spawnIdLoader
            // 
            this.spawnIdLoader.Location = new System.Drawing.Point(6, 119);
            this.spawnIdLoader.Name = "spawnIdLoader";
            this.spawnIdLoader.Size = new System.Drawing.Size(140, 20);
            this.spawnIdLoader.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Room ID";
            // 
            // roomIdLoader
            // 
            this.roomIdLoader.Location = new System.Drawing.Point(6, 78);
            this.roomIdLoader.Name = "roomIdLoader";
            this.roomIdLoader.Size = new System.Drawing.Size(140, 20);
            this.roomIdLoader.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Stage name";
            // 
            // stageNameLoader
            // 
            this.stageNameLoader.Location = new System.Drawing.Point(6, 35);
            this.stageNameLoader.Name = "stageNameLoader";
            this.stageNameLoader.Size = new System.Drawing.Size(140, 20);
            this.stageNameLoader.TabIndex = 2;
            // 
            // triggerLoadingButton
            // 
            this.triggerLoadingButton.Location = new System.Drawing.Point(9, 228);
            this.triggerLoadingButton.Name = "triggerLoadingButton";
            this.triggerLoadingButton.Size = new System.Drawing.Size(140, 23);
            this.triggerLoadingButton.TabIndex = 0;
            this.triggerLoadingButton.Text = "Trigger loading";
            this.triggerLoadingButton.UseVisualStyleBackColor = true;
            this.triggerLoadingButton.Click += new System.EventHandler(this.triggerLoadingButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fetchAllLink);
            this.groupBox5.Controls.Add(this.fetchSA);
            this.groupBox5.Controls.Add(this.fetchSpeed);
            this.groupBox5.Controls.Add(this.fetchAngle);
            this.groupBox5.Controls.Add(this.fetchZ);
            this.groupBox5.Controls.Add(this.fetchY);
            this.groupBox5.Controls.Add(this.fetchX);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.restorePositionButton);
            this.groupBox5.Controls.Add(this.healthNumber);
            this.groupBox5.Controls.Add(this.setHealthButton);
            this.groupBox5.Controls.Add(this.storePositionButton);
            this.groupBox5.Controls.Add(this.magicNumber);
            this.groupBox5.Controls.Add(this.setMagicButton);
            this.groupBox5.Controls.Add(this.angleNumber);
            this.groupBox5.Controls.Add(this.setAngleButton);
            this.groupBox5.Controls.Add(this.xNumber);
            this.groupBox5.Controls.Add(this.speedAngleNumber);
            this.groupBox5.Controls.Add(this.setSAButton);
            this.groupBox5.Controls.Add(this.yNumber);
            this.groupBox5.Controls.Add(this.zNumber);
            this.groupBox5.Controls.Add(this.setPositionButton);
            this.groupBox5.Controls.Add(this.speedNumber);
            this.groupBox5.Controls.Add(this.setSpeedButton);
            this.groupBox5.Location = new System.Drawing.Point(306, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 328);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Link";
            // 
            // fetchAllLink
            // 
            this.fetchAllLink.Location = new System.Drawing.Point(116, 270);
            this.fetchAllLink.Name = "fetchAllLink";
            this.fetchAllLink.Size = new System.Drawing.Size(83, 20);
            this.fetchAllLink.TabIndex = 28;
            this.fetchAllLink.Text = "Fetch all";
            this.fetchAllLink.UseVisualStyleBackColor = true;
            this.fetchAllLink.Click += new System.EventHandler(this.fetchAllLink_Click);
            // 
            // fetchSA
            // 
            this.fetchSA.Location = new System.Drawing.Point(244, 158);
            this.fetchSA.Name = "fetchSA";
            this.fetchSA.Size = new System.Drawing.Size(47, 20);
            this.fetchSA.TabIndex = 27;
            this.fetchSA.Text = "Fetch";
            this.fetchSA.UseVisualStyleBackColor = true;
            this.fetchSA.Click += new System.EventHandler(this.fetchSA_Click);
            // 
            // fetchSpeed
            // 
            this.fetchSpeed.Location = new System.Drawing.Point(244, 131);
            this.fetchSpeed.Name = "fetchSpeed";
            this.fetchSpeed.Size = new System.Drawing.Size(47, 20);
            this.fetchSpeed.TabIndex = 26;
            this.fetchSpeed.Text = "Fetch";
            this.fetchSpeed.UseVisualStyleBackColor = true;
            this.fetchSpeed.Click += new System.EventHandler(this.fetchSpeed_Click);
            // 
            // fetchAngle
            // 
            this.fetchAngle.Location = new System.Drawing.Point(244, 104);
            this.fetchAngle.Name = "fetchAngle";
            this.fetchAngle.Size = new System.Drawing.Size(47, 20);
            this.fetchAngle.TabIndex = 25;
            this.fetchAngle.Text = "Fetch";
            this.fetchAngle.UseVisualStyleBackColor = true;
            this.fetchAngle.Click += new System.EventHandler(this.fetchAngle_Click);
            // 
            // fetchZ
            // 
            this.fetchZ.Location = new System.Drawing.Point(243, 217);
            this.fetchZ.Name = "fetchZ";
            this.fetchZ.Size = new System.Drawing.Size(47, 20);
            this.fetchZ.TabIndex = 24;
            this.fetchZ.Text = "Fetch";
            this.fetchZ.UseVisualStyleBackColor = true;
            this.fetchZ.Click += new System.EventHandler(this.fetchZ_Click);
            // 
            // fetchY
            // 
            this.fetchY.Location = new System.Drawing.Point(152, 217);
            this.fetchY.Name = "fetchY";
            this.fetchY.Size = new System.Drawing.Size(47, 20);
            this.fetchY.TabIndex = 23;
            this.fetchY.Text = "Fetch";
            this.fetchY.UseVisualStyleBackColor = true;
            this.fetchY.Click += new System.EventHandler(this.fetchY_Click);
            // 
            // fetchX
            // 
            this.fetchX.Location = new System.Drawing.Point(51, 217);
            this.fetchX.Name = "fetchX";
            this.fetchX.Size = new System.Drawing.Size(47, 20);
            this.fetchX.TabIndex = 22;
            this.fetchX.Text = "Fetch";
            this.fetchX.UseVisualStyleBackColor = true;
            this.fetchX.Click += new System.EventHandler(this.fetchX_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(208, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Z";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(113, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "X";
            // 
            // restorePositionButton
            // 
            this.restorePositionButton.Location = new System.Drawing.Point(165, 297);
            this.restorePositionButton.Name = "restorePositionButton";
            this.restorePositionButton.Size = new System.Drawing.Size(114, 23);
            this.restorePositionButton.TabIndex = 1;
            this.restorePositionButton.Text = "Restore Position";
            this.restorePositionButton.UseVisualStyleBackColor = true;
            this.restorePositionButton.Click += new System.EventHandler(this.restorePositionButton_Click);
            // 
            // healthNumber
            // 
            this.healthNumber.Location = new System.Drawing.Point(142, 26);
            this.healthNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.healthNumber.Name = "healthNumber";
            this.healthNumber.Size = new System.Drawing.Size(135, 20);
            this.healthNumber.TabIndex = 19;
            // 
            // setHealthButton
            // 
            this.setHealthButton.Location = new System.Drawing.Point(11, 24);
            this.setHealthButton.Name = "setHealthButton";
            this.setHealthButton.Size = new System.Drawing.Size(107, 23);
            this.setHealthButton.TabIndex = 18;
            this.setHealthButton.Text = "Set Health";
            this.setHealthButton.UseVisualStyleBackColor = true;
            this.setHealthButton.Click += new System.EventHandler(this.setHealthButton_Click);
            // 
            // storePositionButton
            // 
            this.storePositionButton.Location = new System.Drawing.Point(13, 297);
            this.storePositionButton.Name = "storePositionButton";
            this.storePositionButton.Size = new System.Drawing.Size(116, 23);
            this.storePositionButton.TabIndex = 0;
            this.storePositionButton.Text = "Store Position";
            this.storePositionButton.UseVisualStyleBackColor = true;
            this.storePositionButton.Click += new System.EventHandler(this.storePositionButton_Click);
            // 
            // magicNumber
            // 
            this.magicNumber.Location = new System.Drawing.Point(142, 55);
            this.magicNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.magicNumber.Name = "magicNumber";
            this.magicNumber.Size = new System.Drawing.Size(135, 20);
            this.magicNumber.TabIndex = 17;
            // 
            // setMagicButton
            // 
            this.setMagicButton.Location = new System.Drawing.Point(11, 53);
            this.setMagicButton.Name = "setMagicButton";
            this.setMagicButton.Size = new System.Drawing.Size(107, 23);
            this.setMagicButton.TabIndex = 16;
            this.setMagicButton.Text = "Set Magic";
            this.setMagicButton.UseVisualStyleBackColor = true;
            this.setMagicButton.Click += new System.EventHandler(this.setMagicButton_Click);
            // 
            // angleNumber
            // 
            this.angleNumber.Location = new System.Drawing.Point(124, 103);
            this.angleNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.angleNumber.Name = "angleNumber";
            this.angleNumber.Size = new System.Drawing.Size(117, 20);
            this.angleNumber.TabIndex = 15;
            // 
            // setAngleButton
            // 
            this.setAngleButton.Location = new System.Drawing.Point(11, 103);
            this.setAngleButton.Name = "setAngleButton";
            this.setAngleButton.Size = new System.Drawing.Size(107, 23);
            this.setAngleButton.TabIndex = 14;
            this.setAngleButton.Text = "Set Angle";
            this.setAngleButton.UseVisualStyleBackColor = true;
            this.setAngleButton.Click += new System.EventHandler(this.setAngleButton_Click);
            // 
            // xNumber
            // 
            this.xNumber.DecimalPlaces = 5;
            this.xNumber.Location = new System.Drawing.Point(19, 237);
            this.xNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.xNumber.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.xNumber.Name = "xNumber";
            this.xNumber.Size = new System.Drawing.Size(81, 20);
            this.xNumber.TabIndex = 11;
            // 
            // speedAngleNumber
            // 
            this.speedAngleNumber.DecimalPlaces = 5;
            this.speedAngleNumber.Location = new System.Drawing.Point(124, 157);
            this.speedAngleNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.speedAngleNumber.Name = "speedAngleNumber";
            this.speedAngleNumber.Size = new System.Drawing.Size(117, 20);
            this.speedAngleNumber.TabIndex = 9;
            // 
            // setSAButton
            // 
            this.setSAButton.Location = new System.Drawing.Point(11, 157);
            this.setSAButton.Name = "setSAButton";
            this.setSAButton.Size = new System.Drawing.Size(107, 23);
            this.setSAButton.TabIndex = 8;
            this.setSAButton.Text = "Set Speed Angle";
            this.setSAButton.UseVisualStyleBackColor = true;
            this.setSAButton.Click += new System.EventHandler(this.setSAButton_Click);
            // 
            // yNumber
            // 
            this.yNumber.DecimalPlaces = 5;
            this.yNumber.Location = new System.Drawing.Point(116, 237);
            this.yNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.yNumber.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.yNumber.Name = "yNumber";
            this.yNumber.Size = new System.Drawing.Size(80, 20);
            this.yNumber.TabIndex = 7;
            // 
            // zNumber
            // 
            this.zNumber.DecimalPlaces = 5;
            this.zNumber.Location = new System.Drawing.Point(211, 237);
            this.zNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.zNumber.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.zNumber.Name = "zNumber";
            this.zNumber.Size = new System.Drawing.Size(79, 20);
            this.zNumber.TabIndex = 5;
            // 
            // setPositionButton
            // 
            this.setPositionButton.Location = new System.Drawing.Point(99, 183);
            this.setPositionButton.Name = "setPositionButton";
            this.setPositionButton.Size = new System.Drawing.Size(107, 23);
            this.setPositionButton.TabIndex = 4;
            this.setPositionButton.Text = "Set Position";
            this.setPositionButton.UseVisualStyleBackColor = true;
            this.setPositionButton.Click += new System.EventHandler(this.setPositionButton_Click);
            // 
            // speedNumber
            // 
            this.speedNumber.DecimalPlaces = 5;
            this.speedNumber.Location = new System.Drawing.Point(124, 131);
            this.speedNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.speedNumber.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.speedNumber.Name = "speedNumber";
            this.speedNumber.Size = new System.Drawing.Size(117, 20);
            this.speedNumber.TabIndex = 3;
            // 
            // setSpeedButton
            // 
            this.setSpeedButton.Location = new System.Drawing.Point(11, 130);
            this.setSpeedButton.Name = "setSpeedButton";
            this.setSpeedButton.Size = new System.Drawing.Size(107, 23);
            this.setSpeedButton.TabIndex = 0;
            this.setSpeedButton.Text = "Set Speed";
            this.setSpeedButton.UseVisualStyleBackColor = true;
            this.setSpeedButton.Click += new System.EventHandler(this.setSpeedButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.refillArrowsButton);
            this.groupBox4.Controls.Add(this.refillBombsButton);
            this.groupBox4.Controls.Add(this.refillMagicButton);
            this.groupBox4.Controls.Add(this.refillHealthButton);
            this.groupBox4.Location = new System.Drawing.Point(11, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 91);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amounts";
            // 
            // refillArrowsButton
            // 
            this.refillArrowsButton.Location = new System.Drawing.Point(139, 51);
            this.refillArrowsButton.Name = "refillArrowsButton";
            this.refillArrowsButton.Size = new System.Drawing.Size(132, 23);
            this.refillArrowsButton.TabIndex = 3;
            this.refillArrowsButton.Text = "Refill Arrows";
            this.refillArrowsButton.UseVisualStyleBackColor = true;
            this.refillArrowsButton.Click += new System.EventHandler(this.refillArrowsButton_Click);
            // 
            // refillBombsButton
            // 
            this.refillBombsButton.Location = new System.Drawing.Point(16, 51);
            this.refillBombsButton.Name = "refillBombsButton";
            this.refillBombsButton.Size = new System.Drawing.Size(117, 23);
            this.refillBombsButton.TabIndex = 2;
            this.refillBombsButton.Text = "Refill Bombs";
            this.refillBombsButton.UseVisualStyleBackColor = true;
            this.refillBombsButton.Click += new System.EventHandler(this.refillBombsButton_Click);
            // 
            // refillMagicButton
            // 
            this.refillMagicButton.Location = new System.Drawing.Point(139, 22);
            this.refillMagicButton.Name = "refillMagicButton";
            this.refillMagicButton.Size = new System.Drawing.Size(132, 23);
            this.refillMagicButton.TabIndex = 1;
            this.refillMagicButton.Text = "Refill Magic";
            this.refillMagicButton.UseVisualStyleBackColor = true;
            this.refillMagicButton.Click += new System.EventHandler(this.refillMagicButton_Click);
            // 
            // refillHealthButton
            // 
            this.refillHealthButton.Location = new System.Drawing.Point(16, 22);
            this.refillHealthButton.Name = "refillHealthButton";
            this.refillHealthButton.Size = new System.Drawing.Size(117, 23);
            this.refillHealthButton.TabIndex = 0;
            this.refillHealthButton.Text = "Refill Health";
            this.refillHealthButton.UseVisualStyleBackColor = true;
            this.refillHealthButton.Click += new System.EventHandler(this.refillHealthButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.doorCancelButton);
            this.groupBox2.Controls.Add(this.removeStorageButton);
            this.groupBox2.Controls.Add(this.chestStorageButton);
            this.groupBox2.Controls.Add(this.getStorageButton);
            this.groupBox2.Location = new System.Drawing.Point(11, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 89);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Storage";
            // 
            // doorCancelButton
            // 
            this.doorCancelButton.Location = new System.Drawing.Point(139, 51);
            this.doorCancelButton.Name = "doorCancelButton";
            this.doorCancelButton.Size = new System.Drawing.Size(132, 23);
            this.doorCancelButton.TabIndex = 3;
            this.doorCancelButton.Text = "Door Cancel";
            this.doorCancelButton.UseVisualStyleBackColor = true;
            this.doorCancelButton.Click += new System.EventHandler(this.doorCancelButton_Click);
            // 
            // removeStorageButton
            // 
            this.removeStorageButton.Location = new System.Drawing.Point(16, 51);
            this.removeStorageButton.Name = "removeStorageButton";
            this.removeStorageButton.Size = new System.Drawing.Size(117, 23);
            this.removeStorageButton.TabIndex = 2;
            this.removeStorageButton.Text = "Remove storage";
            this.removeStorageButton.UseVisualStyleBackColor = true;
            this.removeStorageButton.Click += new System.EventHandler(this.removeStorageButton_Click);
            // 
            // chestStorageButton
            // 
            this.chestStorageButton.Location = new System.Drawing.Point(139, 22);
            this.chestStorageButton.Name = "chestStorageButton";
            this.chestStorageButton.Size = new System.Drawing.Size(132, 23);
            this.chestStorageButton.TabIndex = 1;
            this.chestStorageButton.Text = "Chest storage";
            this.chestStorageButton.UseVisualStyleBackColor = true;
            this.chestStorageButton.Click += new System.EventHandler(this.chestStorageButton_Click);
            // 
            // getStorageButton
            // 
            this.getStorageButton.Location = new System.Drawing.Point(16, 22);
            this.getStorageButton.Name = "getStorageButton";
            this.getStorageButton.Size = new System.Drawing.Size(117, 23);
            this.getStorageButton.TabIndex = 0;
            this.getStorageButton.Text = "Get storage";
            this.getStorageButton.UseVisualStyleBackColor = true;
            this.getStorageButton.Click += new System.EventHandler(this.getStorageButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetCollisionButton);
            this.groupBox1.Controls.Add(this.reloadMapButton);
            this.groupBox1.Controls.Add(this.softResetButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            // 
            // resetCollisionButton
            // 
            this.resetCollisionButton.Location = new System.Drawing.Point(178, 22);
            this.resetCollisionButton.Name = "resetCollisionButton";
            this.resetCollisionButton.Size = new System.Drawing.Size(93, 23);
            this.resetCollisionButton.TabIndex = 2;
            this.resetCollisionButton.Text = "Reset Collisions";
            this.resetCollisionButton.UseVisualStyleBackColor = true;
            this.resetCollisionButton.Click += new System.EventHandler(this.resetCollisionButton_Click);
            // 
            // reloadMapButton
            // 
            this.reloadMapButton.Location = new System.Drawing.Point(97, 22);
            this.reloadMapButton.Name = "reloadMapButton";
            this.reloadMapButton.Size = new System.Drawing.Size(75, 23);
            this.reloadMapButton.TabIndex = 1;
            this.reloadMapButton.Text = "Reload map";
            this.reloadMapButton.UseVisualStyleBackColor = true;
            this.reloadMapButton.Click += new System.EventHandler(this.reloadMapButton_Click);
            // 
            // softResetButton
            // 
            this.softResetButton.Location = new System.Drawing.Point(16, 22);
            this.softResetButton.Name = "softResetButton";
            this.softResetButton.Size = new System.Drawing.Size(75, 23);
            this.softResetButton.TabIndex = 0;
            this.softResetButton.Text = "Soft reset";
            this.softResetButton.UseVisualStyleBackColor = true;
            this.softResetButton.Click += new System.EventHandler(this.softResetButton_Click);
            // 
            // dataViewerPanel
            // 
            this.dataViewerPanel.Location = new System.Drawing.Point(7, 70);
            this.dataViewerPanel.Name = "dataViewerPanel";
            this.dataViewerPanel.Size = new System.Drawing.Size(803, 348);
            this.dataViewerPanel.TabIndex = 31;
            // 
            // advancedPanel
            // 
            this.advancedPanel.Controls.Add(this.memViewer);
            this.advancedPanel.Controls.Add(this.groupBox6);
            this.advancedPanel.Controls.Add(this.peekButton);
            this.advancedPanel.Controls.Add(this.pokeButton);
            this.advancedPanel.Controls.Add(this.typeDropdown);
            this.advancedPanel.Controls.Add(this.valueTextbox);
            this.advancedPanel.Controls.Add(this.memoryAddress);
            this.advancedPanel.Controls.Add(this.label20);
            this.advancedPanel.Controls.Add(this.label19);
            this.advancedPanel.Controls.Add(this.label18);
            this.advancedPanel.Location = new System.Drawing.Point(7, 70);
            this.advancedPanel.Name = "advancedPanel";
            this.advancedPanel.Size = new System.Drawing.Size(803, 348);
            this.advancedPanel.TabIndex = 32;
            // 
            // memViewer
            // 
            this.memViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memViewer.Location = new System.Drawing.Point(14, 128);
            this.memViewer.Name = "memViewer";
            this.memViewer.Size = new System.Drawing.Size(565, 209);
            this.memViewer.TabIndex = 19;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.itemList);
            this.groupBox6.Controls.Add(this.addItem);
            this.groupBox6.Controls.Add(this.removeItem);
            this.groupBox6.Controls.Add(this.slotList);
            this.groupBox6.Location = new System.Drawing.Point(603, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(197, 325);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Item Modifier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Will go into slot...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Item ...";
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Location = new System.Drawing.Point(8, 32);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(324, 95);
            this.itemList.TabIndex = 14;
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(8, 255);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(92, 23);
            this.addItem.TabIndex = 6;
            this.addItem.Text = "Add";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // removeItem
            // 
            this.removeItem.Location = new System.Drawing.Point(245, 255);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(87, 23);
            this.removeItem.TabIndex = 9;
            this.removeItem.Text = "Remove";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // slotList
            // 
            this.slotList.FormattingEnabled = true;
            this.slotList.Location = new System.Drawing.Point(8, 148);
            this.slotList.Name = "slotList";
            this.slotList.Size = new System.Drawing.Size(324, 95);
            this.slotList.TabIndex = 15;
            // 
            // peekButton
            // 
            this.peekButton.Location = new System.Drawing.Point(211, 86);
            this.peekButton.Name = "peekButton";
            this.peekButton.Size = new System.Drawing.Size(75, 23);
            this.peekButton.TabIndex = 7;
            this.peekButton.Text = "Peek";
            this.peekButton.UseVisualStyleBackColor = true;
            this.peekButton.Click += new System.EventHandler(this.peekButton_Click);
            // 
            // pokeButton
            // 
            this.pokeButton.Location = new System.Drawing.Point(292, 86);
            this.pokeButton.Name = "pokeButton";
            this.pokeButton.Size = new System.Drawing.Size(75, 23);
            this.pokeButton.TabIndex = 6;
            this.pokeButton.Text = "Poke";
            this.pokeButton.UseVisualStyleBackColor = true;
            this.pokeButton.Click += new System.EventHandler(this.pokeButton_Click);
            // 
            // typeDropdown
            // 
            this.typeDropdown.FormattingEnabled = true;
            this.typeDropdown.Location = new System.Drawing.Point(5, 80);
            this.typeDropdown.Name = "typeDropdown";
            this.typeDropdown.Size = new System.Drawing.Size(121, 21);
            this.typeDropdown.TabIndex = 5;
            // 
            // valueTextbox
            // 
            this.valueTextbox.Location = new System.Drawing.Point(211, 26);
            this.valueTextbox.Name = "valueTextbox";
            this.valueTextbox.Size = new System.Drawing.Size(100, 20);
            this.valueTextbox.TabIndex = 4;
            // 
            // memoryAddress
            // 
            this.memoryAddress.Location = new System.Drawing.Point(5, 29);
            this.memoryAddress.Name = "memoryAddress";
            this.memoryAddress.Size = new System.Drawing.Size(100, 20);
            this.memoryAddress.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Type";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(210, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Value (Hex/float)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Memory address (Hex)";
            // 
            // mainFeatures
            // 
            this.mainFeatures.Location = new System.Drawing.Point(331, 10);
            this.mainFeatures.Name = "mainFeatures";
            this.mainFeatures.Size = new System.Drawing.Size(123, 23);
            this.mainFeatures.TabIndex = 17;
            this.mainFeatures.Text = "Main features";
            this.mainFeatures.UseVisualStyleBackColor = true;
            this.mainFeatures.Click += new System.EventHandler(this.mainFeatures_Click);
            // 
            // miscFeatures
            // 
            this.miscFeatures.Location = new System.Drawing.Point(463, 10);
            this.miscFeatures.Name = "miscFeatures";
            this.miscFeatures.Size = new System.Drawing.Size(123, 23);
            this.miscFeatures.TabIndex = 18;
            this.miscFeatures.Text = "Misc features";
            this.miscFeatures.UseVisualStyleBackColor = true;
            this.miscFeatures.Click += new System.EventHandler(this.miscFeatures_Click);
            // 
            // dataViewer
            // 
            this.dataViewer.Location = new System.Drawing.Point(592, 10);
            this.dataViewer.Name = "dataViewer";
            this.dataViewer.Size = new System.Drawing.Size(123, 23);
            this.dataViewer.TabIndex = 19;
            this.dataViewer.Text = "Data Viewer";
            this.dataViewer.UseVisualStyleBackColor = true;
            this.dataViewer.Click += new System.EventHandler(this.dataViewer_Click);
            // 
            // advanced
            // 
            this.advanced.Location = new System.Drawing.Point(721, 10);
            this.advanced.Name = "advanced";
            this.advanced.Size = new System.Drawing.Size(89, 23);
            this.advanced.TabIndex = 20;
            this.advanced.Text = "Advanced";
            this.advanced.UseVisualStyleBackColor = true;
            this.advanced.Click += new System.EventHandler(this.advanced_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // teleporter
            // 
            this.teleporter.Location = new System.Drawing.Point(721, 39);
            this.teleporter.Name = "teleporter";
            this.teleporter.Size = new System.Drawing.Size(89, 23);
            this.teleporter.TabIndex = 36;
            this.teleporter.Text = "Teleporter";
            this.teleporter.UseVisualStyleBackColor = true;
            this.teleporter.Click += new System.EventHandler(this.teleporter_Click);
            // 
            // detachDataViewer
            // 
            this.detachDataViewer.Location = new System.Drawing.Point(592, 39);
            this.detachDataViewer.Name = "detachDataViewer";
            this.detachDataViewer.Size = new System.Drawing.Size(123, 23);
            this.detachDataViewer.TabIndex = 35;
            this.detachDataViewer.Text = "Detached Data Viewer";
            this.detachDataViewer.UseVisualStyleBackColor = true;
            this.detachDataViewer.Click += new System.EventHandler(this.detachDataViewer_Click);
            // 
            // memfilesManager
            // 
            this.memfilesManager.Location = new System.Drawing.Point(463, 39);
            this.memfilesManager.Name = "memfilesManager";
            this.memfilesManager.Size = new System.Drawing.Size(123, 23);
            this.memfilesManager.TabIndex = 34;
            this.memfilesManager.Text = "Memfiles manager";
            this.memfilesManager.UseVisualStyleBackColor = true;
            this.memfilesManager.Click += new System.EventHandler(this.memfilesManager_Click);
            // 
            // itemManagerButton
            // 
            this.itemManagerButton.Location = new System.Drawing.Point(331, 39);
            this.itemManagerButton.Name = "itemManagerButton";
            this.itemManagerButton.Size = new System.Drawing.Size(123, 23);
            this.itemManagerButton.TabIndex = 33;
            this.itemManagerButton.Text = "Items Manager";
            this.itemManagerButton.UseVisualStyleBackColor = true;
            this.itemManagerButton.Click += new System.EventHandler(this.itemManagerButton_Click);
            // 
            // itemsManager
            // 
            this.itemsManager.Controls.Add(this.autoupdateTracker);
            this.itemsManager.Controls.Add(this.groupBox3);
            this.itemsManager.Controls.Add(this.giveAll);
            this.itemsManager.Controls.Add(this.itemsPanel);
            this.itemsManager.Controls.Add(this.infBombs);
            this.itemsManager.Controls.Add(this.infArrows);
            this.itemsManager.Controls.Add(this.fullHealth);
            this.itemsManager.Controls.Add(this.magic80);
            this.itemsManager.Controls.Add(this.allSongs);
            this.itemsManager.Controls.Add(this.fullCapacities);
            this.itemsManager.Location = new System.Drawing.Point(7, 70);
            this.itemsManager.Name = "itemsManager";
            this.itemsManager.Size = new System.Drawing.Size(803, 348);
            this.itemsManager.TabIndex = 34;
            // 
            // autoupdateTracker
            // 
            this.autoupdateTracker.AutoSize = true;
            this.autoupdateTracker.Location = new System.Drawing.Point(622, 16);
            this.autoupdateTracker.Name = "autoupdateTracker";
            this.autoupdateTracker.Size = new System.Drawing.Size(84, 17);
            this.autoupdateTracker.TabIndex = 45;
            this.autoupdateTracker.Text = "Auto update";
            this.autoupdateTracker.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.setHC);
            this.groupBox3.Controls.Add(this.setHCValue);
            this.groupBox3.Location = new System.Drawing.Point(483, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 65);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Heart container";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Value:";
            // 
            // setHC
            // 
            this.setHC.Location = new System.Drawing.Point(13, 32);
            this.setHC.Name = "setHC";
            this.setHC.Size = new System.Drawing.Size(114, 23);
            this.setHC.TabIndex = 41;
            this.setHC.Text = "Set heart container";
            this.setHC.UseVisualStyleBackColor = true;
            this.setHC.Click += new System.EventHandler(this.setHC_Click);
            // 
            // setHCValue
            // 
            this.setHCValue.Location = new System.Drawing.Point(139, 34);
            this.setHCValue.Name = "setHCValue";
            this.setHCValue.Size = new System.Drawing.Size(120, 20);
            this.setHCValue.TabIndex = 43;
            this.setHCValue.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // giveAll
            // 
            this.giveAll.Location = new System.Drawing.Point(483, 13);
            this.giveAll.Name = "giveAll";
            this.giveAll.Size = new System.Drawing.Size(75, 23);
            this.giveAll.TabIndex = 40;
            this.giveAll.Text = "Give all";
            this.giveAll.UseVisualStyleBackColor = true;
            this.giveAll.Click += new System.EventHandler(this.giveAll_Click);
            // 
            // itemsPanel
            // 
            this.itemsPanel.BackgroundImage = global::WWHDHacker.Properties.Resources.trackerbg;
            this.itemsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemsPanel.Controls.Add(this.nayrusPearlCheck);
            this.itemsPanel.Controls.Add(this.faroresPearlCheck);
            this.itemsPanel.Controls.Add(this.dinsPearlCheck);
            this.itemsPanel.Controls.Add(this.triforceCheck);
            this.itemsPanel.Controls.Add(this.quiverCheck);
            this.itemsPanel.Controls.Add(this.bombBagCheck);
            this.itemsPanel.Controls.Add(this.magicCheck);
            this.itemsPanel.Controls.Add(this.walletCheck);
            this.itemsPanel.Controls.Add(this.heroCharmCheck);
            this.itemsPanel.Controls.Add(this.songOfPassingCheck);
            this.itemsPanel.Controls.Add(this.windGodAriaCheck);
            this.itemsPanel.Controls.Add(this.earthGodLyricCheck);
            this.itemsPanel.Controls.Add(this.commandMelodyCheck);
            this.itemsPanel.Controls.Add(this.balladOfGalesCheck);
            this.itemsPanel.Controls.Add(this.windsRequiemCheck);
            this.itemsPanel.Controls.Add(this.bottleCheck);
            this.itemsPanel.Controls.Add(this.powerBraceletsCheck);
            this.itemsPanel.Controls.Add(this.skullHammerCheck);
            this.itemsPanel.Controls.Add(this.hookshotCheck);
            this.itemsPanel.Controls.Add(this.deliveryBagCheck);
            this.itemsPanel.Controls.Add(this.noteToMomCheck);
            this.itemsPanel.Controls.Add(this.moblinsLetterCheck);
            this.itemsPanel.Controls.Add(this.maggiesLetterCheck);
            this.itemsPanel.Controls.Add(this.cabanaDeedCheck);
            this.itemsPanel.Controls.Add(this.shieldCheck);
            this.itemsPanel.Controls.Add(this.bombsCheck);
            this.itemsPanel.Controls.Add(this.bowCheck);
            this.itemsPanel.Controls.Add(this.baitBagCheck);
            this.itemsPanel.Controls.Add(this.magicArmorCheck);
            this.itemsPanel.Controls.Add(this.ironBootsCheck);
            this.itemsPanel.Controls.Add(this.pictoboxCheck);
            this.itemsPanel.Controls.Add(this.tingleBottleCheck);
            this.itemsPanel.Controls.Add(this.swordCheck);
            this.itemsPanel.Controls.Add(this.leafCheck);
            this.itemsPanel.Controls.Add(this.boomerangCheck);
            this.itemsPanel.Controls.Add(this.spoilsBagCheck);
            this.itemsPanel.Controls.Add(this.grapplingHookCheck);
            this.itemsPanel.Controls.Add(this.windWakerCheck);
            this.itemsPanel.Controls.Add(this.sailCheck);
            this.itemsPanel.Controls.Add(this.telescopeCheck);
            this.itemsPanel.Location = new System.Drawing.Point(11, 9);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(450, 332);
            this.itemsPanel.TabIndex = 39;
            // 
            // nayrusPearlCheck
            // 
            this.nayrusPearlCheck.BackColor = System.Drawing.Color.Transparent;
            this.nayrusPearlCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nayrusPearlCheck.Image = ((System.Drawing.Image)(resources.GetObject("nayrusPearlCheck.Image")));
            this.nayrusPearlCheck.Index = 0;
            this.nayrusPearlCheck.Location = new System.Drawing.Point(34, 228);
            this.nayrusPearlCheck.Max = 1;
            this.nayrusPearlCheck.Name = "nayrusPearlCheck";
            this.nayrusPearlCheck.SelectedItem = WWHDHacker.ItemEnum.NayrusPearl;
            this.nayrusPearlCheck.Size = new System.Drawing.Size(48, 48);
            this.nayrusPearlCheck.TabIndex = 39;
            this.nayrusPearlCheck.TabStop = false;
            // 
            // faroresPearlCheck
            // 
            this.faroresPearlCheck.BackColor = System.Drawing.Color.Transparent;
            this.faroresPearlCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.faroresPearlCheck.Image = ((System.Drawing.Image)(resources.GetObject("faroresPearlCheck.Image")));
            this.faroresPearlCheck.Index = 0;
            this.faroresPearlCheck.Location = new System.Drawing.Point(61, 271);
            this.faroresPearlCheck.Max = 1;
            this.faroresPearlCheck.Name = "faroresPearlCheck";
            this.faroresPearlCheck.SelectedItem = WWHDHacker.ItemEnum.FaroresPearl;
            this.faroresPearlCheck.Size = new System.Drawing.Size(48, 48);
            this.faroresPearlCheck.TabIndex = 38;
            this.faroresPearlCheck.TabStop = false;
            // 
            // dinsPearlCheck
            // 
            this.dinsPearlCheck.BackColor = System.Drawing.Color.Transparent;
            this.dinsPearlCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dinsPearlCheck.Image = ((System.Drawing.Image)(resources.GetObject("dinsPearlCheck.Image")));
            this.dinsPearlCheck.Index = 0;
            this.dinsPearlCheck.Location = new System.Drawing.Point(7, 271);
            this.dinsPearlCheck.Max = 1;
            this.dinsPearlCheck.Name = "dinsPearlCheck";
            this.dinsPearlCheck.SelectedItem = WWHDHacker.ItemEnum.DinsPearl;
            this.dinsPearlCheck.Size = new System.Drawing.Size(48, 48);
            this.dinsPearlCheck.TabIndex = 37;
            this.dinsPearlCheck.TabStop = false;
            // 
            // triforceCheck
            // 
            this.triforceCheck.BackColor = System.Drawing.Color.Transparent;
            this.triforceCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triforceCheck.Image = ((System.Drawing.Image)(resources.GetObject("triforceCheck.Image")));
            this.triforceCheck.Index = 0;
            this.triforceCheck.Location = new System.Drawing.Point(116, 230);
            this.triforceCheck.Max = 1;
            this.triforceCheck.Name = "triforceCheck";
            this.triforceCheck.SelectedItem = WWHDHacker.ItemEnum.Triforce;
            this.triforceCheck.Size = new System.Drawing.Size(101, 89);
            this.triforceCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.triforceCheck.TabIndex = 36;
            this.triforceCheck.TabStop = false;
            // 
            // quiverCheck
            // 
            this.quiverCheck.BackColor = System.Drawing.Color.Transparent;
            this.quiverCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quiverCheck.Image = ((System.Drawing.Image)(resources.GetObject("quiverCheck.Image")));
            this.quiverCheck.Index = 0;
            this.quiverCheck.Location = new System.Drawing.Point(277, 229);
            this.quiverCheck.Max = 2;
            this.quiverCheck.Name = "quiverCheck";
            this.quiverCheck.SelectedItem = WWHDHacker.ItemEnum.Quiver;
            this.quiverCheck.Size = new System.Drawing.Size(48, 48);
            this.quiverCheck.TabIndex = 35;
            this.quiverCheck.TabStop = false;
            // 
            // bombBagCheck
            // 
            this.bombBagCheck.BackColor = System.Drawing.Color.Transparent;
            this.bombBagCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bombBagCheck.Image = ((System.Drawing.Image)(resources.GetObject("bombBagCheck.Image")));
            this.bombBagCheck.Index = 0;
            this.bombBagCheck.Location = new System.Drawing.Point(223, 229);
            this.bombBagCheck.Max = 2;
            this.bombBagCheck.Name = "bombBagCheck";
            this.bombBagCheck.SelectedItem = WWHDHacker.ItemEnum.BombBag;
            this.bombBagCheck.Size = new System.Drawing.Size(48, 48);
            this.bombBagCheck.TabIndex = 34;
            this.bombBagCheck.TabStop = false;
            // 
            // magicCheck
            // 
            this.magicCheck.BackColor = System.Drawing.Color.Transparent;
            this.magicCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicCheck.Image = ((System.Drawing.Image)(resources.GetObject("magicCheck.Image")));
            this.magicCheck.Index = 0;
            this.magicCheck.Location = new System.Drawing.Point(390, 230);
            this.magicCheck.Max = 2;
            this.magicCheck.Name = "magicCheck";
            this.magicCheck.SelectedItem = WWHDHacker.ItemEnum.MagicMeter;
            this.magicCheck.Size = new System.Drawing.Size(48, 48);
            this.magicCheck.TabIndex = 33;
            this.magicCheck.TabStop = false;
            // 
            // walletCheck
            // 
            this.walletCheck.BackColor = System.Drawing.Color.Transparent;
            this.walletCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.walletCheck.Image = ((System.Drawing.Image)(resources.GetObject("walletCheck.Image")));
            this.walletCheck.Index = 0;
            this.walletCheck.Location = new System.Drawing.Point(336, 230);
            this.walletCheck.Max = 2;
            this.walletCheck.Name = "walletCheck";
            this.walletCheck.SelectedItem = WWHDHacker.ItemEnum.Wallet;
            this.walletCheck.Size = new System.Drawing.Size(48, 48);
            this.walletCheck.TabIndex = 32;
            this.walletCheck.TabStop = false;
            // 
            // heroCharmCheck
            // 
            this.heroCharmCheck.BackColor = System.Drawing.Color.Transparent;
            this.heroCharmCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.heroCharmCheck.Image = ((System.Drawing.Image)(resources.GetObject("heroCharmCheck.Image")));
            this.heroCharmCheck.Index = 0;
            this.heroCharmCheck.Location = new System.Drawing.Point(390, 173);
            this.heroCharmCheck.Max = 1;
            this.heroCharmCheck.Name = "heroCharmCheck";
            this.heroCharmCheck.SelectedItem = WWHDHacker.ItemEnum.HeroCharm;
            this.heroCharmCheck.Size = new System.Drawing.Size(48, 48);
            this.heroCharmCheck.TabIndex = 31;
            this.heroCharmCheck.TabStop = false;
            // 
            // songOfPassingCheck
            // 
            this.songOfPassingCheck.BackColor = System.Drawing.Color.Transparent;
            this.songOfPassingCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songOfPassingCheck.Image = ((System.Drawing.Image)(resources.GetObject("songOfPassingCheck.Image")));
            this.songOfPassingCheck.Index = 0;
            this.songOfPassingCheck.Location = new System.Drawing.Point(336, 173);
            this.songOfPassingCheck.Max = 1;
            this.songOfPassingCheck.Name = "songOfPassingCheck";
            this.songOfPassingCheck.SelectedItem = WWHDHacker.ItemEnum.SongOfPassing;
            this.songOfPassingCheck.Size = new System.Drawing.Size(48, 48);
            this.songOfPassingCheck.TabIndex = 30;
            this.songOfPassingCheck.TabStop = false;
            // 
            // windGodAriaCheck
            // 
            this.windGodAriaCheck.BackColor = System.Drawing.Color.Transparent;
            this.windGodAriaCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windGodAriaCheck.Image = ((System.Drawing.Image)(resources.GetObject("windGodAriaCheck.Image")));
            this.windGodAriaCheck.Index = 0;
            this.windGodAriaCheck.Location = new System.Drawing.Point(282, 173);
            this.windGodAriaCheck.Max = 1;
            this.windGodAriaCheck.Name = "windGodAriaCheck";
            this.windGodAriaCheck.SelectedItem = WWHDHacker.ItemEnum.WindGodAria;
            this.windGodAriaCheck.Size = new System.Drawing.Size(48, 48);
            this.windGodAriaCheck.TabIndex = 29;
            this.windGodAriaCheck.TabStop = false;
            // 
            // earthGodLyricCheck
            // 
            this.earthGodLyricCheck.BackColor = System.Drawing.Color.Transparent;
            this.earthGodLyricCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.earthGodLyricCheck.Image = ((System.Drawing.Image)(resources.GetObject("earthGodLyricCheck.Image")));
            this.earthGodLyricCheck.Index = 0;
            this.earthGodLyricCheck.Location = new System.Drawing.Point(228, 173);
            this.earthGodLyricCheck.Max = 1;
            this.earthGodLyricCheck.Name = "earthGodLyricCheck";
            this.earthGodLyricCheck.SelectedItem = WWHDHacker.ItemEnum.EarthGodLyric;
            this.earthGodLyricCheck.Size = new System.Drawing.Size(48, 48);
            this.earthGodLyricCheck.TabIndex = 28;
            this.earthGodLyricCheck.TabStop = false;
            // 
            // commandMelodyCheck
            // 
            this.commandMelodyCheck.BackColor = System.Drawing.Color.Transparent;
            this.commandMelodyCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commandMelodyCheck.Image = ((System.Drawing.Image)(resources.GetObject("commandMelodyCheck.Image")));
            this.commandMelodyCheck.Index = 0;
            this.commandMelodyCheck.Location = new System.Drawing.Point(174, 173);
            this.commandMelodyCheck.Max = 1;
            this.commandMelodyCheck.Name = "commandMelodyCheck";
            this.commandMelodyCheck.SelectedItem = WWHDHacker.ItemEnum.CommandMelody;
            this.commandMelodyCheck.Size = new System.Drawing.Size(48, 48);
            this.commandMelodyCheck.TabIndex = 27;
            this.commandMelodyCheck.TabStop = false;
            // 
            // balladOfGalesCheck
            // 
            this.balladOfGalesCheck.BackColor = System.Drawing.Color.Transparent;
            this.balladOfGalesCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.balladOfGalesCheck.Image = ((System.Drawing.Image)(resources.GetObject("balladOfGalesCheck.Image")));
            this.balladOfGalesCheck.Index = 0;
            this.balladOfGalesCheck.Location = new System.Drawing.Point(120, 173);
            this.balladOfGalesCheck.Max = 1;
            this.balladOfGalesCheck.Name = "balladOfGalesCheck";
            this.balladOfGalesCheck.SelectedItem = WWHDHacker.ItemEnum.BalladOfGales;
            this.balladOfGalesCheck.Size = new System.Drawing.Size(48, 48);
            this.balladOfGalesCheck.TabIndex = 26;
            this.balladOfGalesCheck.TabStop = false;
            // 
            // windsRequiemCheck
            // 
            this.windsRequiemCheck.BackColor = System.Drawing.Color.Transparent;
            this.windsRequiemCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windsRequiemCheck.Image = ((System.Drawing.Image)(resources.GetObject("windsRequiemCheck.Image")));
            this.windsRequiemCheck.Index = 0;
            this.windsRequiemCheck.Location = new System.Drawing.Point(66, 173);
            this.windsRequiemCheck.Max = 1;
            this.windsRequiemCheck.Name = "windsRequiemCheck";
            this.windsRequiemCheck.SelectedItem = WWHDHacker.ItemEnum.WindsRequiem;
            this.windsRequiemCheck.Size = new System.Drawing.Size(48, 48);
            this.windsRequiemCheck.TabIndex = 25;
            this.windsRequiemCheck.TabStop = false;
            // 
            // bottleCheck
            // 
            this.bottleCheck.BackColor = System.Drawing.Color.Transparent;
            this.bottleCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottleCheck.Image = ((System.Drawing.Image)(resources.GetObject("bottleCheck.Image")));
            this.bottleCheck.Index = 0;
            this.bottleCheck.Location = new System.Drawing.Point(12, 174);
            this.bottleCheck.Max = 1;
            this.bottleCheck.Name = "bottleCheck";
            this.bottleCheck.SelectedItem = WWHDHacker.ItemEnum.Bottle;
            this.bottleCheck.Size = new System.Drawing.Size(48, 48);
            this.bottleCheck.TabIndex = 24;
            this.bottleCheck.TabStop = false;
            // 
            // powerBraceletsCheck
            // 
            this.powerBraceletsCheck.BackColor = System.Drawing.Color.Transparent;
            this.powerBraceletsCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.powerBraceletsCheck.Image = ((System.Drawing.Image)(resources.GetObject("powerBraceletsCheck.Image")));
            this.powerBraceletsCheck.Index = 0;
            this.powerBraceletsCheck.Location = new System.Drawing.Point(391, 119);
            this.powerBraceletsCheck.Max = 1;
            this.powerBraceletsCheck.Name = "powerBraceletsCheck";
            this.powerBraceletsCheck.SelectedItem = WWHDHacker.ItemEnum.PowerBracelets;
            this.powerBraceletsCheck.Size = new System.Drawing.Size(48, 48);
            this.powerBraceletsCheck.TabIndex = 23;
            this.powerBraceletsCheck.TabStop = false;
            // 
            // skullHammerCheck
            // 
            this.skullHammerCheck.BackColor = System.Drawing.Color.Transparent;
            this.skullHammerCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skullHammerCheck.Image = ((System.Drawing.Image)(resources.GetObject("skullHammerCheck.Image")));
            this.skullHammerCheck.Index = 0;
            this.skullHammerCheck.Location = new System.Drawing.Point(337, 119);
            this.skullHammerCheck.Max = 1;
            this.skullHammerCheck.Name = "skullHammerCheck";
            this.skullHammerCheck.SelectedItem = WWHDHacker.ItemEnum.Hammer;
            this.skullHammerCheck.Size = new System.Drawing.Size(48, 48);
            this.skullHammerCheck.TabIndex = 22;
            this.skullHammerCheck.TabStop = false;
            // 
            // hookshotCheck
            // 
            this.hookshotCheck.BackColor = System.Drawing.Color.Transparent;
            this.hookshotCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hookshotCheck.Image = ((System.Drawing.Image)(resources.GetObject("hookshotCheck.Image")));
            this.hookshotCheck.Index = 0;
            this.hookshotCheck.Location = new System.Drawing.Point(283, 119);
            this.hookshotCheck.Max = 1;
            this.hookshotCheck.Name = "hookshotCheck";
            this.hookshotCheck.SelectedItem = WWHDHacker.ItemEnum.Hookshot;
            this.hookshotCheck.Size = new System.Drawing.Size(48, 48);
            this.hookshotCheck.TabIndex = 21;
            this.hookshotCheck.TabStop = false;
            // 
            // deliveryBagCheck
            // 
            this.deliveryBagCheck.BackColor = System.Drawing.Color.Transparent;
            this.deliveryBagCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deliveryBagCheck.Image = ((System.Drawing.Image)(resources.GetObject("deliveryBagCheck.Image")));
            this.deliveryBagCheck.Index = 0;
            this.deliveryBagCheck.Location = new System.Drawing.Point(229, 119);
            this.deliveryBagCheck.Max = 1;
            this.deliveryBagCheck.Name = "deliveryBagCheck";
            this.deliveryBagCheck.SelectedItem = WWHDHacker.ItemEnum.DeliveryBag;
            this.deliveryBagCheck.Size = new System.Drawing.Size(48, 48);
            this.deliveryBagCheck.TabIndex = 20;
            this.deliveryBagCheck.TabStop = false;
            // 
            // noteToMomCheck
            // 
            this.noteToMomCheck.BackColor = System.Drawing.Color.Transparent;
            this.noteToMomCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noteToMomCheck.Image = ((System.Drawing.Image)(resources.GetObject("noteToMomCheck.Image")));
            this.noteToMomCheck.Index = 0;
            this.noteToMomCheck.Location = new System.Drawing.Point(175, 119);
            this.noteToMomCheck.Max = 1;
            this.noteToMomCheck.Name = "noteToMomCheck";
            this.noteToMomCheck.SelectedItem = WWHDHacker.ItemEnum.NoteToMom;
            this.noteToMomCheck.Size = new System.Drawing.Size(48, 48);
            this.noteToMomCheck.TabIndex = 19;
            this.noteToMomCheck.TabStop = false;
            // 
            // moblinsLetterCheck
            // 
            this.moblinsLetterCheck.BackColor = System.Drawing.Color.Transparent;
            this.moblinsLetterCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moblinsLetterCheck.Image = ((System.Drawing.Image)(resources.GetObject("moblinsLetterCheck.Image")));
            this.moblinsLetterCheck.Index = 0;
            this.moblinsLetterCheck.Location = new System.Drawing.Point(121, 119);
            this.moblinsLetterCheck.Max = 1;
            this.moblinsLetterCheck.Name = "moblinsLetterCheck";
            this.moblinsLetterCheck.SelectedItem = WWHDHacker.ItemEnum.MoblinsLetter;
            this.moblinsLetterCheck.Size = new System.Drawing.Size(48, 48);
            this.moblinsLetterCheck.TabIndex = 18;
            this.moblinsLetterCheck.TabStop = false;
            // 
            // maggiesLetterCheck
            // 
            this.maggiesLetterCheck.BackColor = System.Drawing.Color.Transparent;
            this.maggiesLetterCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maggiesLetterCheck.Image = ((System.Drawing.Image)(resources.GetObject("maggiesLetterCheck.Image")));
            this.maggiesLetterCheck.Index = 0;
            this.maggiesLetterCheck.Location = new System.Drawing.Point(67, 119);
            this.maggiesLetterCheck.Max = 1;
            this.maggiesLetterCheck.Name = "maggiesLetterCheck";
            this.maggiesLetterCheck.SelectedItem = WWHDHacker.ItemEnum.MaggiesLetter;
            this.maggiesLetterCheck.Size = new System.Drawing.Size(48, 48);
            this.maggiesLetterCheck.TabIndex = 17;
            this.maggiesLetterCheck.TabStop = false;
            // 
            // cabanaDeedCheck
            // 
            this.cabanaDeedCheck.BackColor = System.Drawing.Color.Transparent;
            this.cabanaDeedCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cabanaDeedCheck.Image = ((System.Drawing.Image)(resources.GetObject("cabanaDeedCheck.Image")));
            this.cabanaDeedCheck.Index = 0;
            this.cabanaDeedCheck.Location = new System.Drawing.Point(13, 120);
            this.cabanaDeedCheck.Max = 1;
            this.cabanaDeedCheck.Name = "cabanaDeedCheck";
            this.cabanaDeedCheck.SelectedItem = WWHDHacker.ItemEnum.CabanaDeed;
            this.cabanaDeedCheck.Size = new System.Drawing.Size(48, 48);
            this.cabanaDeedCheck.TabIndex = 16;
            this.cabanaDeedCheck.TabStop = false;
            // 
            // shieldCheck
            // 
            this.shieldCheck.BackColor = System.Drawing.Color.Transparent;
            this.shieldCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shieldCheck.Image = ((System.Drawing.Image)(resources.GetObject("shieldCheck.Image")));
            this.shieldCheck.Index = 0;
            this.shieldCheck.Location = new System.Drawing.Point(391, 65);
            this.shieldCheck.Max = 2;
            this.shieldCheck.Name = "shieldCheck";
            this.shieldCheck.SelectedItem = WWHDHacker.ItemEnum.Shield;
            this.shieldCheck.Size = new System.Drawing.Size(48, 48);
            this.shieldCheck.TabIndex = 15;
            this.shieldCheck.TabStop = false;
            // 
            // bombsCheck
            // 
            this.bombsCheck.BackColor = System.Drawing.Color.Transparent;
            this.bombsCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bombsCheck.Image = ((System.Drawing.Image)(resources.GetObject("bombsCheck.Image")));
            this.bombsCheck.Index = 0;
            this.bombsCheck.Location = new System.Drawing.Point(337, 65);
            this.bombsCheck.Max = 1;
            this.bombsCheck.Name = "bombsCheck";
            this.bombsCheck.SelectedItem = WWHDHacker.ItemEnum.Bombs;
            this.bombsCheck.Size = new System.Drawing.Size(48, 48);
            this.bombsCheck.TabIndex = 14;
            this.bombsCheck.TabStop = false;
            // 
            // bowCheck
            // 
            this.bowCheck.BackColor = System.Drawing.Color.Transparent;
            this.bowCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bowCheck.Image = ((System.Drawing.Image)(resources.GetObject("bowCheck.Image")));
            this.bowCheck.Index = 0;
            this.bowCheck.Location = new System.Drawing.Point(283, 65);
            this.bowCheck.Max = 3;
            this.bowCheck.Name = "bowCheck";
            this.bowCheck.SelectedItem = WWHDHacker.ItemEnum.Bow;
            this.bowCheck.Size = new System.Drawing.Size(48, 48);
            this.bowCheck.TabIndex = 13;
            this.bowCheck.TabStop = false;
            // 
            // baitBagCheck
            // 
            this.baitBagCheck.BackColor = System.Drawing.Color.Transparent;
            this.baitBagCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baitBagCheck.Image = ((System.Drawing.Image)(resources.GetObject("baitBagCheck.Image")));
            this.baitBagCheck.Index = 0;
            this.baitBagCheck.Location = new System.Drawing.Point(229, 65);
            this.baitBagCheck.Max = 1;
            this.baitBagCheck.Name = "baitBagCheck";
            this.baitBagCheck.SelectedItem = WWHDHacker.ItemEnum.BaitBag;
            this.baitBagCheck.Size = new System.Drawing.Size(48, 48);
            this.baitBagCheck.TabIndex = 12;
            this.baitBagCheck.TabStop = false;
            // 
            // magicArmorCheck
            // 
            this.magicArmorCheck.BackColor = System.Drawing.Color.Transparent;
            this.magicArmorCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicArmorCheck.Image = ((System.Drawing.Image)(resources.GetObject("magicArmorCheck.Image")));
            this.magicArmorCheck.Index = 0;
            this.magicArmorCheck.Location = new System.Drawing.Point(175, 65);
            this.magicArmorCheck.Max = 1;
            this.magicArmorCheck.Name = "magicArmorCheck";
            this.magicArmorCheck.SelectedItem = WWHDHacker.ItemEnum.MagicArmor;
            this.magicArmorCheck.Size = new System.Drawing.Size(48, 48);
            this.magicArmorCheck.TabIndex = 11;
            this.magicArmorCheck.TabStop = false;
            // 
            // ironBootsCheck
            // 
            this.ironBootsCheck.BackColor = System.Drawing.Color.Transparent;
            this.ironBootsCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ironBootsCheck.Image = ((System.Drawing.Image)(resources.GetObject("ironBootsCheck.Image")));
            this.ironBootsCheck.Index = 0;
            this.ironBootsCheck.Location = new System.Drawing.Point(121, 65);
            this.ironBootsCheck.Max = 1;
            this.ironBootsCheck.Name = "ironBootsCheck";
            this.ironBootsCheck.SelectedItem = WWHDHacker.ItemEnum.IronBoots;
            this.ironBootsCheck.Size = new System.Drawing.Size(48, 48);
            this.ironBootsCheck.TabIndex = 10;
            this.ironBootsCheck.TabStop = false;
            // 
            // pictoboxCheck
            // 
            this.pictoboxCheck.BackColor = System.Drawing.Color.Transparent;
            this.pictoboxCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictoboxCheck.Image = ((System.Drawing.Image)(resources.GetObject("pictoboxCheck.Image")));
            this.pictoboxCheck.Index = 0;
            this.pictoboxCheck.Location = new System.Drawing.Point(67, 65);
            this.pictoboxCheck.Max = 2;
            this.pictoboxCheck.Name = "pictoboxCheck";
            this.pictoboxCheck.SelectedItem = WWHDHacker.ItemEnum.Pictobox;
            this.pictoboxCheck.Size = new System.Drawing.Size(48, 48);
            this.pictoboxCheck.TabIndex = 9;
            this.pictoboxCheck.TabStop = false;
            // 
            // tingleBottleCheck
            // 
            this.tingleBottleCheck.BackColor = System.Drawing.Color.Transparent;
            this.tingleBottleCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tingleBottleCheck.Image = ((System.Drawing.Image)(resources.GetObject("tingleBottleCheck.Image")));
            this.tingleBottleCheck.Index = 0;
            this.tingleBottleCheck.Location = new System.Drawing.Point(13, 66);
            this.tingleBottleCheck.Max = 1;
            this.tingleBottleCheck.Name = "tingleBottleCheck";
            this.tingleBottleCheck.SelectedItem = WWHDHacker.ItemEnum.TingleBottle;
            this.tingleBottleCheck.Size = new System.Drawing.Size(48, 48);
            this.tingleBottleCheck.TabIndex = 8;
            this.tingleBottleCheck.TabStop = false;
            // 
            // swordCheck
            // 
            this.swordCheck.BackColor = System.Drawing.Color.Transparent;
            this.swordCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swordCheck.Image = ((System.Drawing.Image)(resources.GetObject("swordCheck.Image")));
            this.swordCheck.Index = 0;
            this.swordCheck.Location = new System.Drawing.Point(390, 11);
            this.swordCheck.Max = 4;
            this.swordCheck.Name = "swordCheck";
            this.swordCheck.SelectedItem = WWHDHacker.ItemEnum.Sword;
            this.swordCheck.Size = new System.Drawing.Size(48, 48);
            this.swordCheck.TabIndex = 7;
            this.swordCheck.TabStop = false;
            // 
            // leafCheck
            // 
            this.leafCheck.BackColor = System.Drawing.Color.Transparent;
            this.leafCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leafCheck.Image = ((System.Drawing.Image)(resources.GetObject("leafCheck.Image")));
            this.leafCheck.Index = 0;
            this.leafCheck.Location = new System.Drawing.Point(336, 11);
            this.leafCheck.Max = 1;
            this.leafCheck.Name = "leafCheck";
            this.leafCheck.SelectedItem = WWHDHacker.ItemEnum.Leaf;
            this.leafCheck.Size = new System.Drawing.Size(48, 48);
            this.leafCheck.TabIndex = 6;
            this.leafCheck.TabStop = false;
            // 
            // boomerangCheck
            // 
            this.boomerangCheck.BackColor = System.Drawing.Color.Transparent;
            this.boomerangCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boomerangCheck.Image = ((System.Drawing.Image)(resources.GetObject("boomerangCheck.Image")));
            this.boomerangCheck.Index = 0;
            this.boomerangCheck.Location = new System.Drawing.Point(282, 11);
            this.boomerangCheck.Max = 1;
            this.boomerangCheck.Name = "boomerangCheck";
            this.boomerangCheck.SelectedItem = WWHDHacker.ItemEnum.Boomerang;
            this.boomerangCheck.Size = new System.Drawing.Size(48, 48);
            this.boomerangCheck.TabIndex = 5;
            this.boomerangCheck.TabStop = false;
            // 
            // spoilsBagCheck
            // 
            this.spoilsBagCheck.BackColor = System.Drawing.Color.Transparent;
            this.spoilsBagCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spoilsBagCheck.Image = ((System.Drawing.Image)(resources.GetObject("spoilsBagCheck.Image")));
            this.spoilsBagCheck.Index = 0;
            this.spoilsBagCheck.Location = new System.Drawing.Point(228, 11);
            this.spoilsBagCheck.Max = 1;
            this.spoilsBagCheck.Name = "spoilsBagCheck";
            this.spoilsBagCheck.SelectedItem = WWHDHacker.ItemEnum.SpoilsBag;
            this.spoilsBagCheck.Size = new System.Drawing.Size(48, 48);
            this.spoilsBagCheck.TabIndex = 4;
            this.spoilsBagCheck.TabStop = false;
            // 
            // grapplingHookCheck
            // 
            this.grapplingHookCheck.BackColor = System.Drawing.Color.Transparent;
            this.grapplingHookCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grapplingHookCheck.Image = ((System.Drawing.Image)(resources.GetObject("grapplingHookCheck.Image")));
            this.grapplingHookCheck.Index = 0;
            this.grapplingHookCheck.Location = new System.Drawing.Point(174, 11);
            this.grapplingHookCheck.Max = 1;
            this.grapplingHookCheck.Name = "grapplingHookCheck";
            this.grapplingHookCheck.SelectedItem = WWHDHacker.ItemEnum.GrapplingHook;
            this.grapplingHookCheck.Size = new System.Drawing.Size(48, 48);
            this.grapplingHookCheck.TabIndex = 3;
            this.grapplingHookCheck.TabStop = false;
            // 
            // windWakerCheck
            // 
            this.windWakerCheck.BackColor = System.Drawing.Color.Transparent;
            this.windWakerCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windWakerCheck.Image = ((System.Drawing.Image)(resources.GetObject("windWakerCheck.Image")));
            this.windWakerCheck.Index = 0;
            this.windWakerCheck.Location = new System.Drawing.Point(120, 11);
            this.windWakerCheck.Max = 1;
            this.windWakerCheck.Name = "windWakerCheck";
            this.windWakerCheck.SelectedItem = WWHDHacker.ItemEnum.WindWaker;
            this.windWakerCheck.Size = new System.Drawing.Size(48, 48);
            this.windWakerCheck.TabIndex = 2;
            this.windWakerCheck.TabStop = false;
            // 
            // sailCheck
            // 
            this.sailCheck.BackColor = System.Drawing.Color.Transparent;
            this.sailCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sailCheck.Image = ((System.Drawing.Image)(resources.GetObject("sailCheck.Image")));
            this.sailCheck.Index = 0;
            this.sailCheck.Location = new System.Drawing.Point(66, 11);
            this.sailCheck.Max = 2;
            this.sailCheck.Name = "sailCheck";
            this.sailCheck.SelectedItem = WWHDHacker.ItemEnum.Sail;
            this.sailCheck.Size = new System.Drawing.Size(48, 48);
            this.sailCheck.TabIndex = 1;
            this.sailCheck.TabStop = false;
            // 
            // telescopeCheck
            // 
            this.telescopeCheck.BackColor = System.Drawing.Color.Transparent;
            this.telescopeCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.telescopeCheck.Image = ((System.Drawing.Image)(resources.GetObject("telescopeCheck.Image")));
            this.telescopeCheck.Index = 0;
            this.telescopeCheck.Location = new System.Drawing.Point(12, 12);
            this.telescopeCheck.Max = 1;
            this.telescopeCheck.Name = "telescopeCheck";
            this.telescopeCheck.SelectedItem = WWHDHacker.ItemEnum.Telescope;
            this.telescopeCheck.Size = new System.Drawing.Size(48, 48);
            this.telescopeCheck.TabIndex = 0;
            this.telescopeCheck.TabStop = false;
            // 
            // itemsList
            // 
            this.itemsList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.itemsList.ImageSize = new System.Drawing.Size(16, 16);
            this.itemsList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // CheckInv
            // 
            this.CheckInv.Interval = 1000;
            this.CheckInv.Tick += new System.EventHandler(this.CheckInv_Tick);
            // 
            // memfilesPanel
            // 
            this.memfilesPanel.Controls.Add(this.loadMemfile);
            this.memfilesPanel.Controls.Add(this.createMemfile);
            this.memfilesPanel.Location = new System.Drawing.Point(7, 70);
            this.memfilesPanel.Name = "memfilesPanel";
            this.memfilesPanel.Size = new System.Drawing.Size(803, 348);
            this.memfilesPanel.TabIndex = 32;
            // 
            // loadMemfile
            // 
            this.loadMemfile.Location = new System.Drawing.Point(23, 66);
            this.loadMemfile.Name = "loadMemfile";
            this.loadMemfile.Size = new System.Drawing.Size(97, 23);
            this.loadMemfile.TabIndex = 1;
            this.loadMemfile.Text = "Load Memfile";
            this.loadMemfile.UseVisualStyleBackColor = true;
            this.loadMemfile.Click += new System.EventHandler(this.loadMemfile_Click);
            // 
            // createMemfile
            // 
            this.createMemfile.Location = new System.Drawing.Point(23, 23);
            this.createMemfile.Name = "createMemfile";
            this.createMemfile.Size = new System.Drawing.Size(97, 23);
            this.createMemfile.TabIndex = 0;
            this.createMemfile.Text = "Create memfile";
            this.createMemfile.UseVisualStyleBackColor = true;
            this.createMemfile.Click += new System.EventHandler(this.createMemfile_Click);
            // 
            // teleporterPanel
            // 
            this.teleporterPanel.Controls.Add(this.displayOnMap);
            this.teleporterPanel.Controls.Add(this.transparentLayer);
            this.teleporterPanel.Controls.Add(this.addedRemoved);
            this.teleporterPanel.Controls.Add(this.teleporterToggleFavorites);
            this.teleporterPanel.Controls.Add(this.groupBox8);
            this.teleporterPanel.Controls.Add(this.linkLocationLabel);
            this.teleporterPanel.Controls.Add(this.pictureBox1);
            this.teleporterPanel.Controls.Add(this.teleporterToggleHyrule);
            this.teleporterPanel.Controls.Add(this.panel2);
            this.teleporterPanel.Controls.Add(this.islandLabel);
            this.teleporterPanel.Location = new System.Drawing.Point(7, 70);
            this.teleporterPanel.Name = "teleporterPanel";
            this.teleporterPanel.Size = new System.Drawing.Size(803, 348);
            this.teleporterPanel.TabIndex = 33;
            // 
            // displayOnMap
            // 
            this.displayOnMap.AutoSize = true;
            this.displayOnMap.Location = new System.Drawing.Point(665, 265);
            this.displayOnMap.Name = "displayOnMap";
            this.displayOnMap.Size = new System.Drawing.Size(98, 17);
            this.displayOnMap.TabIndex = 19;
            this.displayOnMap.Text = "Display on map";
            this.displayOnMap.UseVisualStyleBackColor = true;
            // 
            // transparentLayer
            // 
            this.transparentLayer.BackgroundImage = global::WWHDHacker.Properties.Resources.legend_of_zelda_wind_waker_map_17;
            this.transparentLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transparentLayer.Controls.Add(this.movingLink);
            this.transparentLayer.Controls.Add(this.teleporterMap);
            this.transparentLayer.Location = new System.Drawing.Point(23, 26);
            this.transparentLayer.Name = "transparentLayer";
            this.transparentLayer.Size = new System.Drawing.Size(306, 302);
            this.transparentLayer.TabIndex = 18;
            // 
            // movingLink
            // 
            this.movingLink.BackColor = System.Drawing.Color.Transparent;
            this.movingLink.Enabled = false;
            this.movingLink.Image = global::WWHDHacker.Properties.Resources.MapLinkS_00_l_bflim;
            this.movingLink.Location = new System.Drawing.Point(0, 0);
            this.movingLink.Name = "movingLink";
            this.movingLink.Size = new System.Drawing.Size(35, 33);
            this.movingLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.movingLink.TabIndex = 19;
            this.movingLink.TabStop = false;
            // 
            // teleporterMap
            // 
            this.teleporterMap.BackColor = System.Drawing.Color.Transparent;
            this.teleporterMap.Location = new System.Drawing.Point(0, 0);
            this.teleporterMap.Name = "teleporterMap";
            this.teleporterMap.Size = new System.Drawing.Size(306, 302);
            this.teleporterMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teleporterMap.TabIndex = 0;
            this.teleporterMap.TabStop = false;
            this.teleporterMap.Click += new System.EventHandler(this.teleporterMap_Click);
            this.teleporterMap.MouseLeave += new System.EventHandler(this.teleporterMap_MouseLeave);
            this.teleporterMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.teleporterMap_MouseMove);
            // 
            // addedRemoved
            // 
            this.addedRemoved.AutoSize = true;
            this.addedRemoved.Location = new System.Drawing.Point(349, 331);
            this.addedRemoved.Name = "addedRemoved";
            this.addedRemoved.Size = new System.Drawing.Size(0, 13);
            this.addedRemoved.TabIndex = 17;
            // 
            // teleporterToggleFavorites
            // 
            this.teleporterToggleFavorites.Location = new System.Drawing.Point(662, 291);
            this.teleporterToggleFavorites.Name = "teleporterToggleFavorites";
            this.teleporterToggleFavorites.Size = new System.Drawing.Size(100, 23);
            this.teleporterToggleFavorites.TabIndex = 5;
            this.teleporterToggleFavorites.Text = "Favorites";
            this.teleporterToggleFavorites.UseVisualStyleBackColor = true;
            this.teleporterToggleFavorites.Click += new System.EventHandler(this.teleporterToggleFavorites_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.teleporterRoomId);
            this.groupBox8.Controls.Add(this.teleporterLayer);
            this.groupBox8.Controls.Add(this.teleporterSpawnId);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Location = new System.Drawing.Point(665, 68);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(122, 156);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Advanced (leave default if unsure)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Room ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Layer";
            // 
            // teleporterRoomId
            // 
            this.teleporterRoomId.Location = new System.Drawing.Point(6, 47);
            this.teleporterRoomId.Name = "teleporterRoomId";
            this.teleporterRoomId.Size = new System.Drawing.Size(87, 20);
            this.teleporterRoomId.TabIndex = 10;
            this.teleporterRoomId.Text = "00";
            // 
            // teleporterLayer
            // 
            this.teleporterLayer.Location = new System.Drawing.Point(6, 130);
            this.teleporterLayer.Name = "teleporterLayer";
            this.teleporterLayer.Size = new System.Drawing.Size(87, 20);
            this.teleporterLayer.TabIndex = 14;
            this.teleporterLayer.Text = "ff";
            // 
            // teleporterSpawnId
            // 
            this.teleporterSpawnId.Location = new System.Drawing.Point(6, 88);
            this.teleporterSpawnId.Name = "teleporterSpawnId";
            this.teleporterSpawnId.Size = new System.Drawing.Size(87, 20);
            this.teleporterSpawnId.TabIndex = 12;
            this.teleporterSpawnId.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Spawn ID";
            // 
            // linkLocationLabel
            // 
            this.linkLocationLabel.AutoSize = true;
            this.linkLocationLabel.Location = new System.Drawing.Point(703, 233);
            this.linkLocationLabel.MaximumSize = new System.Drawing.Size(92, 60);
            this.linkLocationLabel.Name = "linkLocationLabel";
            this.linkLocationLabel.Size = new System.Drawing.Size(59, 13);
            this.linkLocationLabel.TabIndex = 7;
            this.linkLocationLabel.Text = ": Unknown";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WWHDHacker.Properties.Resources.MapLinkS_00_l_bflim;
            this.pictureBox1.Location = new System.Drawing.Point(662, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // teleporterToggleHyrule
            // 
            this.teleporterToggleHyrule.Location = new System.Drawing.Point(662, 314);
            this.teleporterToggleHyrule.Name = "teleporterToggleHyrule";
            this.teleporterToggleHyrule.Size = new System.Drawing.Size(101, 23);
            this.teleporterToggleHyrule.TabIndex = 5;
            this.teleporterToggleHyrule.Text = "Hyrule zones";
            this.teleporterToggleHyrule.UseVisualStyleBackColor = true;
            this.teleporterToggleHyrule.Click += new System.EventHandler(this.teleporterToggleHyrule_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WWHDHacker.Properties.Resources.area_empty;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.subAreas);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(352, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 302);
            this.panel2.TabIndex = 4;
            // 
            // subAreas
            // 
            this.subAreas.BackColor = System.Drawing.Color.Transparent;
            this.subAreas.Location = new System.Drawing.Point(14, 19);
            this.subAreas.Name = "subAreas";
            this.subAreas.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.subAreas.Size = new System.Drawing.Size(279, 273);
            this.subAreas.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(17, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Island : ";
            // 
            // islandLabel
            // 
            this.islandLabel.AutoSize = true;
            this.islandLabel.Location = new System.Drawing.Point(28, 328);
            this.islandLabel.Name = "islandLabel";
            this.islandLabel.Size = new System.Drawing.Size(44, 13);
            this.islandLabel.TabIndex = 1;
            this.islandLabel.Text = "Island : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 430);
            this.Controls.Add(this.teleporter);
            this.Controls.Add(this.detachDataViewer);
            this.Controls.Add(this.memfilesManager);
            this.Controls.Add(this.itemManagerButton);
            this.Controls.Add(this.advanced);
            this.Controls.Add(this.dataViewer);
            this.Controls.Add(this.miscFeatures);
            this.Controls.Add(this.mainFeatures);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.memfilesPanel);
            this.Controls.Add(this.dataViewerPanel);
            this.Controls.Add(this.mainFeaturesPanel);
            this.Controls.Add(this.itemsManager);
            this.Controls.Add(this.miscFeaturesPanel);
            this.Controls.Add(this.advancedPanel);
            this.Controls.Add(this.teleporterPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.miscFeaturesPanel.ResumeLayout(false);
            this.miscFeaturesPanel.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.Levitate.ResumeLayout(false);
            this.Levitate.PerformLayout();
            this.DoorCancel.ResumeLayout(false);
            this.DoorCancel.PerformLayout();
            this.Superspeed.ResumeLayout(false);
            this.Superspeed.PerformLayout();
            this.Storage.ResumeLayout(false);
            this.Storage.PerformLayout();
            this.WindDirection.ResumeLayout(false);
            this.WindDirection.PerformLayout();
            this.MasterkeyGroup.ResumeLayout(false);
            this.MasterkeyGroup.PerformLayout();
            this.SaveReloadPos.ResumeLayout(false);
            this.SaveReloadPos.PerformLayout();
            this.ReloadRoom.ResumeLayout(false);
            this.ReloadRoom.PerformLayout();
            this.RefillHealth.ResumeLayout(false);
            this.RefillHealth.PerformLayout();
            this.RefillMagic.ResumeLayout(false);
            this.RefillMagic.PerformLayout();
            this.RefillAmmo.ResumeLayout(false);
            this.RefillAmmo.PerformLayout();
            this.mainFeaturesPanel.ResumeLayout(false);
            this.mainFeaturesPanel.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magicNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedAngleNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumber)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.advancedPanel.ResumeLayout(false);
            this.advancedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memViewer)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.itemsManager.ResumeLayout(false);
            this.itemsManager.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setHCValue)).EndInit();
            this.itemsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nayrusPearlCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faroresPearlCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinsPearlCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triforceCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiverCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombBagCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magicCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroCharmCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songOfPassingCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windGodAriaCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earthGodLyricCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandMelodyCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balladOfGalesCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windsRequiemCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottleCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerBraceletsCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skullHammerCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hookshotCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBagCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteToMomCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moblinsLetterCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maggiesLetterCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabanaDeedCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shieldCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombsCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baitBagCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magicArmorCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ironBootsCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictoboxCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tingleBottleCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leafCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boomerangCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spoilsBagCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grapplingHookCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windWakerCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sailCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telescopeCheck)).EndInit();
            this.memfilesPanel.ResumeLayout(false);
            this.teleporterPanel.ResumeLayout(false);
            this.teleporterPanel.PerformLayout();
            this.transparentLayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movingLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teleporterMap)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel miscFeaturesPanel;
        private System.Windows.Forms.Button mainFeatures;
        private System.Windows.Forms.Button miscFeatures;
        private System.Windows.Forms.Button dataViewer;
        private System.Windows.Forms.Button advanced;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button allSongs;
        private System.Windows.Forms.CheckBox masterkey;
        private System.Windows.Forms.CheckBox storeRestoreCheckbox;
        private System.Windows.Forms.CheckBox lToLevitateCheckbox;
        private System.Windows.Forms.CheckBox superswimCheckbox;
        private System.Windows.Forms.CheckBox doorCancelCheckbox;
        private System.Windows.Forms.CheckBox refillAmmoCheckbox;
        private System.Windows.Forms.CheckBox refillHealthCheckbox;
        private System.Windows.Forms.CheckBox refillMagicCheckbox;
        private System.Windows.Forms.CheckBox reloadRoomCheckbox;
        private System.Windows.Forms.Panel mainFeaturesPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetCollisionButton;
        private System.Windows.Forms.Button reloadMapButton;
        private System.Windows.Forms.Button softResetButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button doorCancelButton;
        private System.Windows.Forms.Button removeStorageButton;
        private System.Windows.Forms.Button chestStorageButton;
        private System.Windows.Forms.Button getStorageButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button refillArrowsButton;
        private System.Windows.Forms.Button refillBombsButton;
        private System.Windows.Forms.Button refillMagicButton;
        private System.Windows.Forms.Button refillHealthButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown xNumber;
        private System.Windows.Forms.NumericUpDown speedAngleNumber;
        private System.Windows.Forms.Button setSAButton;
        private System.Windows.Forms.NumericUpDown yNumber;
        private System.Windows.Forms.NumericUpDown zNumber;
        private System.Windows.Forms.Button setPositionButton;
        private System.Windows.Forms.NumericUpDown speedNumber;
        private System.Windows.Forms.Button restorePositionButton;
        private System.Windows.Forms.Button storePositionButton;
        private System.Windows.Forms.NumericUpDown healthNumber;
        private System.Windows.Forms.Button setHealthButton;
        private System.Windows.Forms.NumericUpDown magicNumber;
        private System.Windows.Forms.Button setMagicButton;
        private System.Windows.Forms.NumericUpDown angleNumber;
        private System.Windows.Forms.Button setAngleButton;
        private System.Windows.Forms.Button setSpeedButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox layerLoader;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox spawnIdLoader;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox roomIdLoader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stageNameLoader;
        private System.Windows.Forms.Button triggerLoadingButton;
        private System.Windows.Forms.CheckBox storageCheckbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button magic80;
        private System.Windows.Forms.Button infArrows;
        private System.Windows.Forms.Button infBombs;
        private System.Windows.Forms.Panel dataViewerPanel;
        private System.Windows.Forms.Panel advancedPanel;
        private System.Windows.Forms.Button peekButton;
        private System.Windows.Forms.Button pokeButton;
        private System.Windows.Forms.ComboBox typeDropdown;
        private System.Windows.Forms.TextBox valueTextbox;
        private System.Windows.Forms.TextBox memoryAddress;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button fullCapacities;
        private System.Windows.Forms.Button fullHealth;
        private System.Windows.Forms.Button teleporter;
        private System.Windows.Forms.Button detachDataViewer;
        private System.Windows.Forms.Button memfilesManager;
        private System.Windows.Forms.Button itemManagerButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.ListBox slotList;
        private System.Windows.Forms.Panel itemsManager;
        private System.Windows.Forms.Panel itemsPanel;
        private System.Windows.Forms.ImageList itemsList;
        private CheckBoxImage telescopeCheck;
        private CheckBoxImage leafCheck;
        private CheckBoxImage boomerangCheck;
        private CheckBoxImage spoilsBagCheck;
        private CheckBoxImage grapplingHookCheck;
        private CheckBoxImage windWakerCheck;
        private CheckBoxImage sailCheck;
        private CheckBoxImage swordCheck;
        private CheckBoxImage shieldCheck;
        private CheckBoxImage bombsCheck;
        private CheckBoxImage bowCheck;
        private CheckBoxImage baitBagCheck;
        private CheckBoxImage magicArmorCheck;
        private CheckBoxImage ironBootsCheck;
        private CheckBoxImage pictoboxCheck;
        private CheckBoxImage tingleBottleCheck;
        private CheckBoxImage powerBraceletsCheck;
        private CheckBoxImage skullHammerCheck;
        private CheckBoxImage hookshotCheck;
        private CheckBoxImage deliveryBagCheck;
        private CheckBoxImage noteToMomCheck;
        private CheckBoxImage moblinsLetterCheck;
        private CheckBoxImage maggiesLetterCheck;
        private CheckBoxImage cabanaDeedCheck;
        private CheckBoxImage heroCharmCheck;
        private CheckBoxImage songOfPassingCheck;
        private CheckBoxImage windGodAriaCheck;
        private CheckBoxImage earthGodLyricCheck;
        private CheckBoxImage commandMelodyCheck;
        private CheckBoxImage balladOfGalesCheck;
        private CheckBoxImage windsRequiemCheck;
        private CheckBoxImage bottleCheck;
        private CheckBoxImage nayrusPearlCheck;
        private CheckBoxImage faroresPearlCheck;
        private CheckBoxImage dinsPearlCheck;
        private CheckBoxImage triforceCheck;
        private CheckBoxImage quiverCheck;
        private CheckBoxImage bombBagCheck;
        private CheckBoxImage magicCheck;
        private CheckBoxImage walletCheck;
        private System.Windows.Forms.Button giveAll;
        private System.Windows.Forms.Timer CheckInv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button setHC;
        private System.Windows.Forms.NumericUpDown setHCValue;
        private System.Windows.Forms.CheckBox infMagic;
        private System.Windows.Forms.CheckBox infHealth;
        private System.Windows.Forms.CheckBox infAir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button resumeGame;
        private System.Windows.Forms.Button pauseGame;
        private System.Windows.Forms.CheckBox autoupdateTracker;
        private System.Windows.Forms.Button refreshAS;
        private System.Windows.Forms.Label currentAnimSet;
        private System.Windows.Forms.Button animSet1;
        private System.Windows.Forms.Button animSet2;
        private Panel memfilesPanel;
        private Panel teleporterPanel;
        private PictureBox teleporterMap;
        private Label islandLabel;
        private Panel panel2;
        private Label label6;
        private FlowLayoutPanel subAreas;
        private CheckBox changeWindCheckbox;
        private CheckBox alternativeMemfiles;
        private CheckBox alternativeDpadRight;
        private Button teleporterToggleHyrule;
        private PictureBox pictureBox1;
        private Label linkLocationLabel;
        private GroupBox groupBox8;
        private Label label17;
        private Label label7;
        private TextBox teleporterRoomId;
        private TextBox teleporterLayer;
        private TextBox teleporterSpawnId;
        private Label label8;
        private Button teleporterToggleFavorites;
        private Label addedRemoved;
        private Button fetchX;
        private Button fetchSA;
        private Button fetchSpeed;
        private Button fetchAngle;
        private Button fetchZ;
        private Button fetchY;
        private Button fetchLayer;
        private Button fetchSpawnId;
        private Button fetchRoomId;
        private Button fetchStage;
        private Button fetchAllTeleport;
        private Button fetchAllLink;
        private Panel transparentLayer;
        private PictureBox movingLink;
        private CheckBox displayOnMap;
        private ComboBox levitateCombo;
        private GroupBox MasterkeyGroup;
        private Label label25;
        private ComboBox masterkeyCombo;
        private GroupBox Storage;
        private Label label24;
        private ComboBox storageCombo;
        private GroupBox Superspeed;
        private Label label23;
        private ComboBox superswimCombo;
        private GroupBox DoorCancel;
        private Label label22;
        private ComboBox doorCancelCombo;
        private GroupBox Levitate;
        private Label label21;
        private GroupBox RefillAmmo;
        private Label label29;
        private GroupBox RefillHealth;
        private Label label28;
        private ComboBox refillHealthCombo;
        private GroupBox ReloadRoom;
        private Label label27;
        private ComboBox reloadRoomCombo;
        private GroupBox WindDirection;
        private Label label30;
        private ComboBox windDirectionCombo;
        private GroupBox SaveReloadPos;
        private Label label26;
        private ComboBox storePositionCombo;
        private GroupBox RefillMagic;
        private Label label31;
        private ComboBox refillMagicCombo;
        private Label label32;
        private ComboBox restorePositionCombo;
        private ComboBox refillAmmoCombo;
        private CheckBox levitateMK;
        private CheckBox doorCancelMK;
        private CheckBox superswimMK;
        private CheckBox storageMK;
        private CheckBox windDirectionMK;
        private CheckBox saveReloadMK;
        private CheckBox reloadRoomMK;
        private CheckBox refillHealthMK;
        private CheckBox refillMagicMK;
        private CheckBox refillAmmoMK;
        private DataGridView memViewer;
        private CheckBox displayMacros;
        private CheckBox warningRuns;
        private GroupBox groupBox10;
        private GroupBox groupBox9;
        private GroupBox groupBox11;
        private Button removeTunic;
        private Button giveTunic;
        private Button loadMemfile;
        private Button createMemfile;
    }
}

