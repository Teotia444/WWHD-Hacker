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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("b");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("a", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.miscFeaturesPanel = new System.Windows.Forms.Panel();
            this.accuratePositionRestore = new System.Windows.Forms.CheckBox();
            this.macrosPausedCheckBox = new System.Windows.Forms.CheckBox();
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
            this.levitateHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
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
            this.superswimSpeed = new System.Windows.Forms.NumericUpDown();
            this.superswimMK = new System.Windows.Forms.CheckBox();
            this.label34 = new System.Windows.Forms.Label();
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
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label33 = new System.Windows.Forms.Label();
            this.setKey = new System.Windows.Forms.Button();
            this.keyNumber = new System.Windows.Forms.NumericUpDown();
            this.autoupdateTracker = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.setHC = new System.Windows.Forms.Button();
            this.setHCValue = new System.Windows.Forms.NumericUpDown();
            this.giveAll = new System.Windows.Forms.Button();
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.checkBoxImage40 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage39 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage38 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage37 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage33 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage34 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage35 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage36 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage25 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage26 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage27 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage28 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage29 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage30 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage31 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage32 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage17 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage18 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage19 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage20 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage21 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage22 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage23 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage24 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage9 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage10 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage11 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage12 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage13 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage14 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage15 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage16 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage8 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage7 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage6 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage5 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage4 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage3 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage2 = new WWHDHacker.CheckBoxImage();
            this.checkBoxImage1 = new WWHDHacker.CheckBoxImage();
            this.itemsList = new System.Windows.Forms.ImageList(this.components);
            this.CheckInv = new System.Windows.Forms.Timer(this.components);
            this.memfilesPanel = new System.Windows.Forms.Panel();
            this.SavefileIndicator = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.memfilesViewer = new System.Windows.Forms.TreeView();
            this.deleteMemfile = new System.Windows.Forms.Button();
            this.openMemfileFolder = new System.Windows.Forms.Button();
            this.loadMemfile = new System.Windows.Forms.Button();
            this.createMemfile = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.openSFDir = new System.Windows.Forms.Button();
            this.dumpSF = new System.Windows.Forms.Button();
            this.loadSF = new System.Windows.Forms.Button();
            this.fileRep = new System.Windows.Forms.ListView();
            this.Save = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teleporterPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.subAreas = new System.Windows.Forms.FlowLayoutPanel();
            this.addCustomFavorite = new System.Windows.Forms.Button();
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
            this.islandLabel = new System.Windows.Forms.Label();
            this.miscFeaturesPanel.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.Levitate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levitateHeight)).BeginInit();
            this.DoorCancel.SuspendLayout();
            this.Superspeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superswimSpeed)).BeginInit();
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
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyNumber)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setHCValue)).BeginInit();
            this.itemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage1)).BeginInit();
            this.memfilesPanel.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.teleporterPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.transparentLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movingLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teleporterMap)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.miscFeaturesPanel.Controls.Add(this.accuratePositionRestore);
            this.miscFeaturesPanel.Controls.Add(this.macrosPausedCheckBox);
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
            // accuratePositionRestore
            // 
            this.accuratePositionRestore.AutoSize = true;
            this.accuratePositionRestore.Location = new System.Drawing.Point(400, 45);
            this.accuratePositionRestore.Name = "accuratePositionRestore";
            this.accuratePositionRestore.Size = new System.Drawing.Size(119, 43);
            this.accuratePositionRestore.TabIndex = 60;
            this.accuratePositionRestore.Text = "Use more accurate \r\nposition restoring\r\n(might lag)\r\n";
            this.accuratePositionRestore.UseVisualStyleBackColor = true;
            this.accuratePositionRestore.CheckedChanged += new System.EventHandler(this.accuratePositionRestore_CheckedChanged);
            // 
            // macrosPausedCheckBox
            // 
            this.macrosPausedCheckBox.AutoSize = true;
            this.macrosPausedCheckBox.Location = new System.Drawing.Point(400, 12);
            this.macrosPausedCheckBox.Name = "macrosPausedCheckBox";
            this.macrosPausedCheckBox.Size = new System.Drawing.Size(102, 30);
            this.macrosPausedCheckBox.TabIndex = 59;
            this.macrosPausedCheckBox.Text = "Disable Macros \r\nwhen paused";
            this.macrosPausedCheckBox.UseVisualStyleBackColor = true;
            this.macrosPausedCheckBox.CheckedChanged += new System.EventHandler(this.macrosPausedCheckBox_CheckedChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.infHealth);
            this.groupBox11.Controls.Add(this.infMagic);
            this.groupBox11.Controls.Add(this.infAir);
            this.groupBox11.Location = new System.Drawing.Point(689, 124);
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
            this.groupBox10.Location = new System.Drawing.Point(530, 5);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(264, 117);
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
            this.groupBox9.Location = new System.Drawing.Point(653, 248);
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
            this.displayMacros.Location = new System.Drawing.Point(578, 159);
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
            this.warningRuns.Location = new System.Drawing.Point(578, 126);
            this.warningRuns.Name = "warningRuns";
            this.warningRuns.Size = new System.Drawing.Size(102, 30);
            this.warningRuns.TabIndex = 54;
            this.warningRuns.Text = "Warning before \r\nstarting a run";
            this.warningRuns.UseVisualStyleBackColor = true;
            this.warningRuns.CheckedChanged += new System.EventHandler(this.warningRuns_CheckedChanged);
            // 
            // Levitate
            // 
            this.Levitate.Controls.Add(this.levitateHeight);
            this.Levitate.Controls.Add(this.label5);
            this.Levitate.Controls.Add(this.levitateMK);
            this.Levitate.Controls.Add(this.label21);
            this.Levitate.Controls.Add(this.levitateCombo);
            this.Levitate.Controls.Add(this.lToLevitateCheckbox);
            this.Levitate.Location = new System.Drawing.Point(8, 195);
            this.Levitate.Name = "Levitate";
            this.Levitate.Size = new System.Drawing.Size(244, 58);
            this.Levitate.TabIndex = 47;
            this.Levitate.TabStop = false;
            this.Levitate.Text = "Levitate";
            // 
            // levitateHeight
            // 
            this.levitateHeight.Location = new System.Drawing.Point(187, 33);
            this.levitateHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.levitateHeight.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.levitateHeight.Name = "levitateHeight";
            this.levitateHeight.Size = new System.Drawing.Size(49, 20);
            this.levitateHeight.TabIndex = 50;
            this.levitateHeight.ValueChanged += new System.EventHandler(this.levitateHeight_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Height";
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
            this.DoorCancel.Location = new System.Drawing.Point(8, 69);
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
            this.Superspeed.Controls.Add(this.superswimSpeed);
            this.Superspeed.Controls.Add(this.superswimMK);
            this.Superspeed.Controls.Add(this.label34);
            this.Superspeed.Controls.Add(this.label23);
            this.Superspeed.Controls.Add(this.superswimCombo);
            this.Superspeed.Controls.Add(this.superswimCheckbox);
            this.Superspeed.Controls.Add(this.alternativeDpadRight);
            this.Superspeed.Location = new System.Drawing.Point(8, 254);
            this.Superspeed.Name = "Superspeed";
            this.Superspeed.Size = new System.Drawing.Size(244, 90);
            this.Superspeed.TabIndex = 49;
            this.Superspeed.TabStop = false;
            this.Superspeed.Text = "Superswim";
            // 
            // superswimSpeed
            // 
            this.superswimSpeed.Location = new System.Drawing.Point(188, 62);
            this.superswimSpeed.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.superswimSpeed.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.superswimSpeed.Name = "superswimSpeed";
            this.superswimSpeed.Size = new System.Drawing.Size(49, 20);
            this.superswimSpeed.TabIndex = 52;
            this.superswimSpeed.ValueChanged += new System.EventHandler(this.superswimSpeed_ValueChanged);
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
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(185, 46);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(38, 13);
            this.label34.TabIndex = 51;
            this.label34.Text = "Speed";
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
            this.Storage.Location = new System.Drawing.Point(196, 13);
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
            this.WindDirection.Location = new System.Drawing.Point(8, 129);
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
            this.MasterkeyGroup.Location = new System.Drawing.Point(8, 9);
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
            this.SaveReloadPos.Location = new System.Drawing.Point(196, 90);
            this.SaveReloadPos.Name = "SaveReloadPos";
            this.SaveReloadPos.Size = new System.Drawing.Size(294, 96);
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
            this.ReloadRoom.Location = new System.Drawing.Point(264, 223);
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
            this.RefillHealth.Location = new System.Drawing.Point(264, 285);
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
            this.RefillMagic.Location = new System.Drawing.Point(458, 284);
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
            this.RefillAmmo.Location = new System.Drawing.Point(458, 226);
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
            this.groupBox6.Visible = false;
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
            this.itemsManager.Controls.Add(this.groupBox14);
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
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label33);
            this.groupBox14.Controls.Add(this.setKey);
            this.groupBox14.Controls.Add(this.keyNumber);
            this.groupBox14.Location = new System.Drawing.Point(483, 124);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(263, 65);
            this.groupBox14.TabIndex = 45;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Key counter (works in dungeons only)";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(136, 18);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(37, 13);
            this.label33.TabIndex = 44;
            this.label33.Text = "Value:";
            // 
            // setKey
            // 
            this.setKey.Location = new System.Drawing.Point(13, 32);
            this.setKey.Name = "setKey";
            this.setKey.Size = new System.Drawing.Size(114, 23);
            this.setKey.TabIndex = 41;
            this.setKey.Text = "Set key counter";
            this.setKey.UseVisualStyleBackColor = true;
            this.setKey.Click += new System.EventHandler(this.setKey_Click);
            // 
            // keyNumber
            // 
            this.keyNumber.Location = new System.Drawing.Point(139, 34);
            this.keyNumber.Name = "keyNumber";
            this.keyNumber.Size = new System.Drawing.Size(120, 20);
            this.keyNumber.TabIndex = 43;
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
            this.itemsPanel.Controls.Add(this.checkBoxImage40);
            this.itemsPanel.Controls.Add(this.checkBoxImage39);
            this.itemsPanel.Controls.Add(this.checkBoxImage38);
            this.itemsPanel.Controls.Add(this.checkBoxImage37);
            this.itemsPanel.Controls.Add(this.checkBoxImage33);
            this.itemsPanel.Controls.Add(this.checkBoxImage34);
            this.itemsPanel.Controls.Add(this.checkBoxImage35);
            this.itemsPanel.Controls.Add(this.checkBoxImage36);
            this.itemsPanel.Controls.Add(this.checkBoxImage25);
            this.itemsPanel.Controls.Add(this.checkBoxImage26);
            this.itemsPanel.Controls.Add(this.checkBoxImage27);
            this.itemsPanel.Controls.Add(this.checkBoxImage28);
            this.itemsPanel.Controls.Add(this.checkBoxImage29);
            this.itemsPanel.Controls.Add(this.checkBoxImage30);
            this.itemsPanel.Controls.Add(this.checkBoxImage31);
            this.itemsPanel.Controls.Add(this.checkBoxImage32);
            this.itemsPanel.Controls.Add(this.checkBoxImage17);
            this.itemsPanel.Controls.Add(this.checkBoxImage18);
            this.itemsPanel.Controls.Add(this.checkBoxImage19);
            this.itemsPanel.Controls.Add(this.checkBoxImage20);
            this.itemsPanel.Controls.Add(this.checkBoxImage21);
            this.itemsPanel.Controls.Add(this.checkBoxImage22);
            this.itemsPanel.Controls.Add(this.checkBoxImage23);
            this.itemsPanel.Controls.Add(this.checkBoxImage24);
            this.itemsPanel.Controls.Add(this.checkBoxImage9);
            this.itemsPanel.Controls.Add(this.checkBoxImage10);
            this.itemsPanel.Controls.Add(this.checkBoxImage11);
            this.itemsPanel.Controls.Add(this.checkBoxImage12);
            this.itemsPanel.Controls.Add(this.checkBoxImage13);
            this.itemsPanel.Controls.Add(this.checkBoxImage14);
            this.itemsPanel.Controls.Add(this.checkBoxImage15);
            this.itemsPanel.Controls.Add(this.checkBoxImage16);
            this.itemsPanel.Controls.Add(this.checkBoxImage8);
            this.itemsPanel.Controls.Add(this.checkBoxImage7);
            this.itemsPanel.Controls.Add(this.checkBoxImage6);
            this.itemsPanel.Controls.Add(this.checkBoxImage5);
            this.itemsPanel.Controls.Add(this.checkBoxImage4);
            this.itemsPanel.Controls.Add(this.checkBoxImage3);
            this.itemsPanel.Controls.Add(this.checkBoxImage2);
            this.itemsPanel.Controls.Add(this.checkBoxImage1);
            this.itemsPanel.Location = new System.Drawing.Point(11, 9);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(450, 332);
            this.itemsPanel.TabIndex = 39;
            // 
            // checkBoxImage40
            // 
            this.checkBoxImage40.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage40.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage40.Image")));
            this.checkBoxImage40.Index = 0;
            this.checkBoxImage40.Location = new System.Drawing.Point(38, 227);
            this.checkBoxImage40.Max = 1;
            this.checkBoxImage40.Name = "checkBoxImage40";
            this.checkBoxImage40.SelectedItem = WWHDHacker.ItemEnum.NayrusPearl;
            this.checkBoxImage40.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage40.TabIndex = 39;
            this.checkBoxImage40.TabStop = false;
            // 
            // checkBoxImage39
            // 
            this.checkBoxImage39.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage39.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage39.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage39.Image")));
            this.checkBoxImage39.Index = 0;
            this.checkBoxImage39.Location = new System.Drawing.Point(65, 275);
            this.checkBoxImage39.Max = 1;
            this.checkBoxImage39.Name = "checkBoxImage39";
            this.checkBoxImage39.SelectedItem = WWHDHacker.ItemEnum.FaroresPearl;
            this.checkBoxImage39.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage39.TabIndex = 38;
            this.checkBoxImage39.TabStop = false;
            // 
            // checkBoxImage38
            // 
            this.checkBoxImage38.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage38.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage38.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage38.Image")));
            this.checkBoxImage38.Index = 0;
            this.checkBoxImage38.Location = new System.Drawing.Point(11, 275);
            this.checkBoxImage38.Max = 1;
            this.checkBoxImage38.Name = "checkBoxImage38";
            this.checkBoxImage38.SelectedItem = WWHDHacker.ItemEnum.DinsPearl;
            this.checkBoxImage38.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage38.TabIndex = 37;
            this.checkBoxImage38.TabStop = false;
            // 
            // checkBoxImage37
            // 
            this.checkBoxImage37.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage37.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage37.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage37.Image")));
            this.checkBoxImage37.Index = 0;
            this.checkBoxImage37.Location = new System.Drawing.Point(115, 230);
            this.checkBoxImage37.Max = 1;
            this.checkBoxImage37.Name = "checkBoxImage37";
            this.checkBoxImage37.SelectedItem = WWHDHacker.ItemEnum.Triforce;
            this.checkBoxImage37.Size = new System.Drawing.Size(110, 102);
            this.checkBoxImage37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.checkBoxImage37.TabIndex = 36;
            this.checkBoxImage37.TabStop = false;
            // 
            // checkBoxImage33
            // 
            this.checkBoxImage33.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage33.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage33.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage33.Image")));
            this.checkBoxImage33.Index = 0;
            this.checkBoxImage33.Location = new System.Drawing.Point(283, 235);
            this.checkBoxImage33.Max = 2;
            this.checkBoxImage33.Name = "checkBoxImage33";
            this.checkBoxImage33.SelectedItem = WWHDHacker.ItemEnum.Quiver;
            this.checkBoxImage33.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage33.TabIndex = 35;
            this.checkBoxImage33.TabStop = false;
            // 
            // checkBoxImage34
            // 
            this.checkBoxImage34.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage34.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage34.Image")));
            this.checkBoxImage34.Index = 0;
            this.checkBoxImage34.Location = new System.Drawing.Point(338, 235);
            this.checkBoxImage34.Max = 2;
            this.checkBoxImage34.Name = "checkBoxImage34";
            this.checkBoxImage34.SelectedItem = WWHDHacker.ItemEnum.Wallet;
            this.checkBoxImage34.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage34.TabIndex = 34;
            this.checkBoxImage34.TabStop = false;
            // 
            // checkBoxImage35
            // 
            this.checkBoxImage35.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage35.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage35.Image")));
            this.checkBoxImage35.Index = 0;
            this.checkBoxImage35.Location = new System.Drawing.Point(390, 234);
            this.checkBoxImage35.Max = 2;
            this.checkBoxImage35.Name = "checkBoxImage35";
            this.checkBoxImage35.SelectedItem = WWHDHacker.ItemEnum.MagicMeter;
            this.checkBoxImage35.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage35.TabIndex = 33;
            this.checkBoxImage35.TabStop = false;
            // 
            // checkBoxImage36
            // 
            this.checkBoxImage36.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage36.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage36.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage36.Image")));
            this.checkBoxImage36.Index = 0;
            this.checkBoxImage36.Location = new System.Drawing.Point(227, 235);
            this.checkBoxImage36.Max = 2;
            this.checkBoxImage36.Name = "checkBoxImage36";
            this.checkBoxImage36.SelectedItem = WWHDHacker.ItemEnum.BombBag;
            this.checkBoxImage36.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage36.TabIndex = 32;
            this.checkBoxImage36.TabStop = false;
            // 
            // checkBoxImage25
            // 
            this.checkBoxImage25.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage25.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage25.Image")));
            this.checkBoxImage25.Index = 0;
            this.checkBoxImage25.Location = new System.Drawing.Point(283, 176);
            this.checkBoxImage25.Max = 1;
            this.checkBoxImage25.Name = "checkBoxImage25";
            this.checkBoxImage25.SelectedItem = WWHDHacker.ItemEnum.WindGodAria;
            this.checkBoxImage25.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage25.TabIndex = 31;
            this.checkBoxImage25.TabStop = false;
            // 
            // checkBoxImage26
            // 
            this.checkBoxImage26.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage26.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage26.Image")));
            this.checkBoxImage26.Index = 0;
            this.checkBoxImage26.Location = new System.Drawing.Point(338, 176);
            this.checkBoxImage26.Max = 1;
            this.checkBoxImage26.Name = "checkBoxImage26";
            this.checkBoxImage26.SelectedItem = WWHDHacker.ItemEnum.SongOfPassing;
            this.checkBoxImage26.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage26.TabIndex = 30;
            this.checkBoxImage26.TabStop = false;
            // 
            // checkBoxImage27
            // 
            this.checkBoxImage27.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage27.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage27.Image")));
            this.checkBoxImage27.Index = 0;
            this.checkBoxImage27.Location = new System.Drawing.Point(390, 175);
            this.checkBoxImage27.Max = 1;
            this.checkBoxImage27.Name = "checkBoxImage27";
            this.checkBoxImage27.SelectedItem = WWHDHacker.ItemEnum.HeroCharm;
            this.checkBoxImage27.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage27.TabIndex = 29;
            this.checkBoxImage27.TabStop = false;
            // 
            // checkBoxImage28
            // 
            this.checkBoxImage28.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage28.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage28.Image")));
            this.checkBoxImage28.Index = 0;
            this.checkBoxImage28.Location = new System.Drawing.Point(227, 176);
            this.checkBoxImage28.Max = 1;
            this.checkBoxImage28.Name = "checkBoxImage28";
            this.checkBoxImage28.SelectedItem = WWHDHacker.ItemEnum.EarthGodLyric;
            this.checkBoxImage28.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage28.TabIndex = 28;
            this.checkBoxImage28.TabStop = false;
            // 
            // checkBoxImage29
            // 
            this.checkBoxImage29.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage29.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage29.Image")));
            this.checkBoxImage29.Index = 0;
            this.checkBoxImage29.Location = new System.Drawing.Point(174, 176);
            this.checkBoxImage29.Max = 1;
            this.checkBoxImage29.Name = "checkBoxImage29";
            this.checkBoxImage29.SelectedItem = WWHDHacker.ItemEnum.CommandMelody;
            this.checkBoxImage29.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage29.TabIndex = 27;
            this.checkBoxImage29.TabStop = false;
            // 
            // checkBoxImage30
            // 
            this.checkBoxImage30.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage30.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage30.Image")));
            this.checkBoxImage30.Index = 0;
            this.checkBoxImage30.Location = new System.Drawing.Point(120, 176);
            this.checkBoxImage30.Max = 1;
            this.checkBoxImage30.Name = "checkBoxImage30";
            this.checkBoxImage30.SelectedItem = WWHDHacker.ItemEnum.BalladOfGales;
            this.checkBoxImage30.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage30.TabIndex = 26;
            this.checkBoxImage30.TabStop = false;
            // 
            // checkBoxImage31
            // 
            this.checkBoxImage31.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage31.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage31.Image")));
            this.checkBoxImage31.Index = 0;
            this.checkBoxImage31.Location = new System.Drawing.Point(66, 176);
            this.checkBoxImage31.Max = 1;
            this.checkBoxImage31.Name = "checkBoxImage31";
            this.checkBoxImage31.SelectedItem = WWHDHacker.ItemEnum.WindsRequiem;
            this.checkBoxImage31.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage31.TabIndex = 25;
            this.checkBoxImage31.TabStop = false;
            // 
            // checkBoxImage32
            // 
            this.checkBoxImage32.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage32.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage32.Image")));
            this.checkBoxImage32.Index = 0;
            this.checkBoxImage32.Location = new System.Drawing.Point(13, 176);
            this.checkBoxImage32.Max = 1;
            this.checkBoxImage32.Name = "checkBoxImage32";
            this.checkBoxImage32.SelectedItem = WWHDHacker.ItemEnum.Bottle;
            this.checkBoxImage32.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage32.TabIndex = 24;
            this.checkBoxImage32.TabStop = false;
            // 
            // checkBoxImage17
            // 
            this.checkBoxImage17.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage17.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage17.Image")));
            this.checkBoxImage17.Index = 0;
            this.checkBoxImage17.Location = new System.Drawing.Point(283, 124);
            this.checkBoxImage17.Max = 1;
            this.checkBoxImage17.Name = "checkBoxImage17";
            this.checkBoxImage17.SelectedItem = WWHDHacker.ItemEnum.Hookshot;
            this.checkBoxImage17.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage17.TabIndex = 23;
            this.checkBoxImage17.TabStop = false;
            // 
            // checkBoxImage18
            // 
            this.checkBoxImage18.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage18.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage18.Image")));
            this.checkBoxImage18.Index = 0;
            this.checkBoxImage18.Location = new System.Drawing.Point(338, 124);
            this.checkBoxImage18.Max = 1;
            this.checkBoxImage18.Name = "checkBoxImage18";
            this.checkBoxImage18.SelectedItem = WWHDHacker.ItemEnum.Hammer;
            this.checkBoxImage18.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage18.TabIndex = 22;
            this.checkBoxImage18.TabStop = false;
            // 
            // checkBoxImage19
            // 
            this.checkBoxImage19.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage19.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage19.Image")));
            this.checkBoxImage19.Index = 0;
            this.checkBoxImage19.Location = new System.Drawing.Point(390, 123);
            this.checkBoxImage19.Max = 1;
            this.checkBoxImage19.Name = "checkBoxImage19";
            this.checkBoxImage19.SelectedItem = WWHDHacker.ItemEnum.PowerBracelets;
            this.checkBoxImage19.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage19.TabIndex = 21;
            this.checkBoxImage19.TabStop = false;
            // 
            // checkBoxImage20
            // 
            this.checkBoxImage20.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage20.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage20.Image")));
            this.checkBoxImage20.Index = 0;
            this.checkBoxImage20.Location = new System.Drawing.Point(227, 124);
            this.checkBoxImage20.Max = 1;
            this.checkBoxImage20.Name = "checkBoxImage20";
            this.checkBoxImage20.SelectedItem = WWHDHacker.ItemEnum.DeliveryBag;
            this.checkBoxImage20.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage20.TabIndex = 20;
            this.checkBoxImage20.TabStop = false;
            // 
            // checkBoxImage21
            // 
            this.checkBoxImage21.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage21.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage21.Image")));
            this.checkBoxImage21.Index = 0;
            this.checkBoxImage21.Location = new System.Drawing.Point(174, 124);
            this.checkBoxImage21.Max = 1;
            this.checkBoxImage21.Name = "checkBoxImage21";
            this.checkBoxImage21.SelectedItem = WWHDHacker.ItemEnum.NoteToMom;
            this.checkBoxImage21.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage21.TabIndex = 19;
            this.checkBoxImage21.TabStop = false;
            // 
            // checkBoxImage22
            // 
            this.checkBoxImage22.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage22.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage22.Image")));
            this.checkBoxImage22.Index = 0;
            this.checkBoxImage22.Location = new System.Drawing.Point(120, 124);
            this.checkBoxImage22.Max = 1;
            this.checkBoxImage22.Name = "checkBoxImage22";
            this.checkBoxImage22.SelectedItem = WWHDHacker.ItemEnum.MoblinsLetter;
            this.checkBoxImage22.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage22.TabIndex = 18;
            this.checkBoxImage22.TabStop = false;
            // 
            // checkBoxImage23
            // 
            this.checkBoxImage23.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage23.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage23.Image")));
            this.checkBoxImage23.Index = 0;
            this.checkBoxImage23.Location = new System.Drawing.Point(66, 124);
            this.checkBoxImage23.Max = 1;
            this.checkBoxImage23.Name = "checkBoxImage23";
            this.checkBoxImage23.SelectedItem = WWHDHacker.ItemEnum.MaggiesLetter;
            this.checkBoxImage23.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage23.TabIndex = 17;
            this.checkBoxImage23.TabStop = false;
            // 
            // checkBoxImage24
            // 
            this.checkBoxImage24.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage24.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage24.Image")));
            this.checkBoxImage24.Index = 0;
            this.checkBoxImage24.Location = new System.Drawing.Point(13, 124);
            this.checkBoxImage24.Max = 1;
            this.checkBoxImage24.Name = "checkBoxImage24";
            this.checkBoxImage24.SelectedItem = WWHDHacker.ItemEnum.CabanaDeed;
            this.checkBoxImage24.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage24.TabIndex = 16;
            this.checkBoxImage24.TabStop = false;
            // 
            // checkBoxImage9
            // 
            this.checkBoxImage9.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage9.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage9.Image")));
            this.checkBoxImage9.Index = 0;
            this.checkBoxImage9.Location = new System.Drawing.Point(283, 70);
            this.checkBoxImage9.Max = 3;
            this.checkBoxImage9.Name = "checkBoxImage9";
            this.checkBoxImage9.SelectedItem = WWHDHacker.ItemEnum.Bow;
            this.checkBoxImage9.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage9.TabIndex = 15;
            this.checkBoxImage9.TabStop = false;
            // 
            // checkBoxImage10
            // 
            this.checkBoxImage10.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage10.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage10.Image")));
            this.checkBoxImage10.Index = 0;
            this.checkBoxImage10.Location = new System.Drawing.Point(338, 70);
            this.checkBoxImage10.Max = 1;
            this.checkBoxImage10.Name = "checkBoxImage10";
            this.checkBoxImage10.SelectedItem = WWHDHacker.ItemEnum.Bombs;
            this.checkBoxImage10.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage10.TabIndex = 14;
            this.checkBoxImage10.TabStop = false;
            // 
            // checkBoxImage11
            // 
            this.checkBoxImage11.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage11.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage11.Image")));
            this.checkBoxImage11.Index = 0;
            this.checkBoxImage11.Location = new System.Drawing.Point(390, 69);
            this.checkBoxImage11.Max = 2;
            this.checkBoxImage11.Name = "checkBoxImage11";
            this.checkBoxImage11.SelectedItem = WWHDHacker.ItemEnum.Shield;
            this.checkBoxImage11.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage11.TabIndex = 13;
            this.checkBoxImage11.TabStop = false;
            // 
            // checkBoxImage12
            // 
            this.checkBoxImage12.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage12.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage12.Image")));
            this.checkBoxImage12.Index = 0;
            this.checkBoxImage12.Location = new System.Drawing.Point(227, 70);
            this.checkBoxImage12.Max = 1;
            this.checkBoxImage12.Name = "checkBoxImage12";
            this.checkBoxImage12.SelectedItem = WWHDHacker.ItemEnum.BaitBag;
            this.checkBoxImage12.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage12.TabIndex = 12;
            this.checkBoxImage12.TabStop = false;
            // 
            // checkBoxImage13
            // 
            this.checkBoxImage13.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage13.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage13.Image")));
            this.checkBoxImage13.Index = 0;
            this.checkBoxImage13.Location = new System.Drawing.Point(174, 70);
            this.checkBoxImage13.Max = 1;
            this.checkBoxImage13.Name = "checkBoxImage13";
            this.checkBoxImage13.SelectedItem = WWHDHacker.ItemEnum.MagicArmor;
            this.checkBoxImage13.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage13.TabIndex = 11;
            this.checkBoxImage13.TabStop = false;
            // 
            // checkBoxImage14
            // 
            this.checkBoxImage14.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage14.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage14.Image")));
            this.checkBoxImage14.Index = 0;
            this.checkBoxImage14.Location = new System.Drawing.Point(120, 70);
            this.checkBoxImage14.Max = 1;
            this.checkBoxImage14.Name = "checkBoxImage14";
            this.checkBoxImage14.SelectedItem = WWHDHacker.ItemEnum.IronBoots;
            this.checkBoxImage14.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage14.TabIndex = 10;
            this.checkBoxImage14.TabStop = false;
            // 
            // checkBoxImage15
            // 
            this.checkBoxImage15.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage15.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage15.Image")));
            this.checkBoxImage15.Index = 0;
            this.checkBoxImage15.Location = new System.Drawing.Point(66, 70);
            this.checkBoxImage15.Max = 2;
            this.checkBoxImage15.Name = "checkBoxImage15";
            this.checkBoxImage15.SelectedItem = WWHDHacker.ItemEnum.Pictobox;
            this.checkBoxImage15.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage15.TabIndex = 9;
            this.checkBoxImage15.TabStop = false;
            // 
            // checkBoxImage16
            // 
            this.checkBoxImage16.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage16.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage16.Image")));
            this.checkBoxImage16.Index = 0;
            this.checkBoxImage16.Location = new System.Drawing.Point(13, 70);
            this.checkBoxImage16.Max = 1;
            this.checkBoxImage16.Name = "checkBoxImage16";
            this.checkBoxImage16.SelectedItem = WWHDHacker.ItemEnum.TingleBottle;
            this.checkBoxImage16.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage16.TabIndex = 8;
            this.checkBoxImage16.TabStop = false;
            // 
            // checkBoxImage8
            // 
            this.checkBoxImage8.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage8.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage8.Image")));
            this.checkBoxImage8.Index = 0;
            this.checkBoxImage8.Location = new System.Drawing.Point(284, 17);
            this.checkBoxImage8.Max = 1;
            this.checkBoxImage8.Name = "checkBoxImage8";
            this.checkBoxImage8.SelectedItem = WWHDHacker.ItemEnum.Boomerang;
            this.checkBoxImage8.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage8.TabIndex = 7;
            this.checkBoxImage8.TabStop = false;
            // 
            // checkBoxImage7
            // 
            this.checkBoxImage7.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage7.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage7.Image")));
            this.checkBoxImage7.Index = 0;
            this.checkBoxImage7.Location = new System.Drawing.Point(339, 17);
            this.checkBoxImage7.Max = 1;
            this.checkBoxImage7.Name = "checkBoxImage7";
            this.checkBoxImage7.SelectedItem = WWHDHacker.ItemEnum.Leaf;
            this.checkBoxImage7.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage7.TabIndex = 6;
            this.checkBoxImage7.TabStop = false;
            // 
            // checkBoxImage6
            // 
            this.checkBoxImage6.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage6.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage6.Image")));
            this.checkBoxImage6.Index = 0;
            this.checkBoxImage6.Location = new System.Drawing.Point(391, 16);
            this.checkBoxImage6.Max = 4;
            this.checkBoxImage6.Name = "checkBoxImage6";
            this.checkBoxImage6.SelectedItem = WWHDHacker.ItemEnum.Sword;
            this.checkBoxImage6.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage6.TabIndex = 5;
            this.checkBoxImage6.TabStop = false;
            // 
            // checkBoxImage5
            // 
            this.checkBoxImage5.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage5.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage5.Image")));
            this.checkBoxImage5.Index = 0;
            this.checkBoxImage5.Location = new System.Drawing.Point(228, 17);
            this.checkBoxImage5.Max = 1;
            this.checkBoxImage5.Name = "checkBoxImage5";
            this.checkBoxImage5.SelectedItem = WWHDHacker.ItemEnum.SpoilsBag;
            this.checkBoxImage5.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage5.TabIndex = 4;
            this.checkBoxImage5.TabStop = false;
            // 
            // checkBoxImage4
            // 
            this.checkBoxImage4.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage4.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage4.Image")));
            this.checkBoxImage4.Index = 0;
            this.checkBoxImage4.Location = new System.Drawing.Point(175, 17);
            this.checkBoxImage4.Max = 1;
            this.checkBoxImage4.Name = "checkBoxImage4";
            this.checkBoxImage4.SelectedItem = WWHDHacker.ItemEnum.GrapplingHook;
            this.checkBoxImage4.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage4.TabIndex = 3;
            this.checkBoxImage4.TabStop = false;
            // 
            // checkBoxImage3
            // 
            this.checkBoxImage3.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage3.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage3.Image")));
            this.checkBoxImage3.Index = 0;
            this.checkBoxImage3.Location = new System.Drawing.Point(121, 17);
            this.checkBoxImage3.Max = 1;
            this.checkBoxImage3.Name = "checkBoxImage3";
            this.checkBoxImage3.SelectedItem = WWHDHacker.ItemEnum.WindWaker;
            this.checkBoxImage3.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage3.TabIndex = 2;
            this.checkBoxImage3.TabStop = false;
            // 
            // checkBoxImage2
            // 
            this.checkBoxImage2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage2.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage2.Image")));
            this.checkBoxImage2.Index = 0;
            this.checkBoxImage2.Location = new System.Drawing.Point(67, 17);
            this.checkBoxImage2.Max = 2;
            this.checkBoxImage2.Name = "checkBoxImage2";
            this.checkBoxImage2.SelectedItem = WWHDHacker.ItemEnum.Sail;
            this.checkBoxImage2.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage2.TabIndex = 1;
            this.checkBoxImage2.TabStop = false;
            // 
            // checkBoxImage1
            // 
            this.checkBoxImage1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxImage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxImage1.Image = ((System.Drawing.Image)(resources.GetObject("checkBoxImage1.Image")));
            this.checkBoxImage1.Index = 0;
            this.checkBoxImage1.Location = new System.Drawing.Point(14, 17);
            this.checkBoxImage1.Max = 1;
            this.checkBoxImage1.Name = "checkBoxImage1";
            this.checkBoxImage1.SelectedItem = WWHDHacker.ItemEnum.Telescope;
            this.checkBoxImage1.Size = new System.Drawing.Size(48, 48);
            this.checkBoxImage1.TabIndex = 0;
            this.checkBoxImage1.TabStop = false;
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
            this.memfilesPanel.Controls.Add(this.SavefileIndicator);
            this.memfilesPanel.Controls.Add(this.groupBox13);
            this.memfilesPanel.Controls.Add(this.groupBox12);
            this.memfilesPanel.Location = new System.Drawing.Point(7, 70);
            this.memfilesPanel.Name = "memfilesPanel";
            this.memfilesPanel.Size = new System.Drawing.Size(803, 348);
            this.memfilesPanel.TabIndex = 32;
            // 
            // SavefileIndicator
            // 
            this.SavefileIndicator.AutoSize = true;
            this.SavefileIndicator.ForeColor = System.Drawing.Color.ForestGreen;
            this.SavefileIndicator.Location = new System.Drawing.Point(16, 330);
            this.SavefileIndicator.Name = "SavefileIndicator";
            this.SavefileIndicator.Size = new System.Drawing.Size(0, 13);
            this.SavefileIndicator.TabIndex = 5;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.memfilesViewer);
            this.groupBox13.Controls.Add(this.deleteMemfile);
            this.groupBox13.Controls.Add(this.openMemfileFolder);
            this.groupBox13.Controls.Add(this.loadMemfile);
            this.groupBox13.Controls.Add(this.createMemfile);
            this.groupBox13.Location = new System.Drawing.Point(14, 13);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(325, 315);
            this.groupBox13.TabIndex = 4;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Memfiles";
            // 
            // memfilesViewer
            // 
            this.memfilesViewer.Location = new System.Drawing.Point(8, 22);
            this.memfilesViewer.Name = "memfilesViewer";
            treeNode1.Name = "Node1";
            treeNode1.Text = "b";
            treeNode2.Name = "test";
            treeNode2.Text = "a";
            this.memfilesViewer.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.memfilesViewer.Size = new System.Drawing.Size(305, 213);
            this.memfilesViewer.TabIndex = 6;
            // 
            // deleteMemfile
            // 
            this.deleteMemfile.Location = new System.Drawing.Point(4, 280);
            this.deleteMemfile.Name = "deleteMemfile";
            this.deleteMemfile.Size = new System.Drawing.Size(126, 23);
            this.deleteMemfile.TabIndex = 8;
            this.deleteMemfile.Text = "Delete memfile";
            this.deleteMemfile.UseVisualStyleBackColor = true;
            this.deleteMemfile.Click += new System.EventHandler(this.deleteMemfile_Click);
            // 
            // openMemfileFolder
            // 
            this.openMemfileFolder.Location = new System.Drawing.Point(205, 280);
            this.openMemfileFolder.Name = "openMemfileFolder";
            this.openMemfileFolder.Size = new System.Drawing.Size(114, 23);
            this.openMemfileFolder.TabIndex = 7;
            this.openMemfileFolder.Text = "Open Memfile Folder";
            this.openMemfileFolder.UseVisualStyleBackColor = true;
            this.openMemfileFolder.Click += new System.EventHandler(this.openMemfileFolder_Click);
            // 
            // loadMemfile
            // 
            this.loadMemfile.Location = new System.Drawing.Point(205, 252);
            this.loadMemfile.Name = "loadMemfile";
            this.loadMemfile.Size = new System.Drawing.Size(114, 23);
            this.loadMemfile.TabIndex = 1;
            this.loadMemfile.Text = "Load Memfile";
            this.loadMemfile.UseVisualStyleBackColor = true;
            this.loadMemfile.Click += new System.EventHandler(this.loadMemfile_Click);
            // 
            // createMemfile
            // 
            this.createMemfile.Location = new System.Drawing.Point(3, 252);
            this.createMemfile.Name = "createMemfile";
            this.createMemfile.Size = new System.Drawing.Size(127, 23);
            this.createMemfile.TabIndex = 0;
            this.createMemfile.Text = "Create memfile";
            this.createMemfile.UseVisualStyleBackColor = true;
            this.createMemfile.Click += new System.EventHandler(this.createMemfile_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.openSFDir);
            this.groupBox12.Controls.Add(this.dumpSF);
            this.groupBox12.Controls.Add(this.loadSF);
            this.groupBox12.Controls.Add(this.fileRep);
            this.groupBox12.Location = new System.Drawing.Point(467, 13);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(327, 315);
            this.groupBox12.TabIndex = 3;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Save files";
            // 
            // openSFDir
            // 
            this.openSFDir.Location = new System.Drawing.Point(116, 278);
            this.openSFDir.Name = "openSFDir";
            this.openSFDir.Size = new System.Drawing.Size(103, 33);
            this.openSFDir.TabIndex = 8;
            this.openSFDir.Text = "Open Savefiles Dir";
            this.openSFDir.UseVisualStyleBackColor = true;
            this.openSFDir.Click += new System.EventHandler(this.openSFDir_Click);
            // 
            // dumpSF
            // 
            this.dumpSF.Location = new System.Drawing.Point(223, 278);
            this.dumpSF.Name = "dumpSF";
            this.dumpSF.Size = new System.Drawing.Size(90, 33);
            this.dumpSF.TabIndex = 7;
            this.dumpSF.Text = "Dump Savefile";
            this.dumpSF.UseVisualStyleBackColor = true;
            this.dumpSF.Click += new System.EventHandler(this.dumpSF_Click);
            // 
            // loadSF
            // 
            this.loadSF.Location = new System.Drawing.Point(20, 278);
            this.loadSF.Name = "loadSF";
            this.loadSF.Size = new System.Drawing.Size(90, 33);
            this.loadSF.TabIndex = 6;
            this.loadSF.Text = "Load Savefile";
            this.loadSF.UseVisualStyleBackColor = true;
            this.loadSF.Click += new System.EventHandler(this.loadSF_Click);
            // 
            // fileRep
            // 
            this.fileRep.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.fileRep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Save});
            this.fileRep.HideSelection = false;
            this.fileRep.Location = new System.Drawing.Point(20, 26);
            this.fileRep.MultiSelect = false;
            this.fileRep.Name = "fileRep";
            this.fileRep.Size = new System.Drawing.Size(288, 239);
            this.fileRep.TabIndex = 5;
            this.fileRep.UseCompatibleStateImageBehavior = false;
            this.fileRep.View = System.Windows.Forms.View.Details;
            // 
            // Save
            // 
            this.Save.Text = "Save";
            this.Save.Width = 284;
            // 
            // teleporterPanel
            // 
            this.teleporterPanel.Controls.Add(this.panel1);
            this.teleporterPanel.Controls.Add(this.addCustomFavorite);
            this.teleporterPanel.Controls.Add(this.displayOnMap);
            this.teleporterPanel.Controls.Add(this.transparentLayer);
            this.teleporterPanel.Controls.Add(this.addedRemoved);
            this.teleporterPanel.Controls.Add(this.teleporterToggleFavorites);
            this.teleporterPanel.Controls.Add(this.groupBox8);
            this.teleporterPanel.Controls.Add(this.linkLocationLabel);
            this.teleporterPanel.Controls.Add(this.pictureBox1);
            this.teleporterPanel.Controls.Add(this.teleporterToggleHyrule);
            this.teleporterPanel.Controls.Add(this.islandLabel);
            this.teleporterPanel.Location = new System.Drawing.Point(7, 70);
            this.teleporterPanel.Name = "teleporterPanel";
            this.teleporterPanel.Size = new System.Drawing.Size(803, 348);
            this.teleporterPanel.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WWHDHacker.Properties.Resources.area_empty;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.subAreas);
            this.panel1.Location = new System.Drawing.Point(339, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 304);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(10, 9);
            this.label6.MaximumSize = new System.Drawing.Size(92, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Island: ";
            // 
            // subAreas
            // 
            this.subAreas.AutoScroll = true;
            this.subAreas.BackColor = System.Drawing.Color.Transparent;
            this.subAreas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.subAreas.Location = new System.Drawing.Point(10, 26);
            this.subAreas.Name = "subAreas";
            this.subAreas.Size = new System.Drawing.Size(280, 260);
            this.subAreas.TabIndex = 4;
            // 
            // addCustomFavorite
            // 
            this.addCustomFavorite.Location = new System.Drawing.Point(660, 251);
            this.addCustomFavorite.Name = "addCustomFavorite";
            this.addCustomFavorite.Size = new System.Drawing.Size(125, 23);
            this.addCustomFavorite.TabIndex = 20;
            this.addCustomFavorite.Text = "Add custom favorite";
            this.addCustomFavorite.UseVisualStyleBackColor = true;
            this.addCustomFavorite.Click += new System.EventHandler(this.addCustomFavorite_Click);
            // 
            // displayOnMap
            // 
            this.displayOnMap.AutoSize = true;
            this.displayOnMap.Location = new System.Drawing.Point(663, 235);
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
            this.transparentLayer.Location = new System.Drawing.Point(19, 26);
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
            this.teleporterToggleFavorites.Location = new System.Drawing.Point(660, 291);
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
            this.groupBox8.Location = new System.Drawing.Point(663, 26);
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
            this.linkLocationLabel.Location = new System.Drawing.Point(701, 191);
            this.linkLocationLabel.MaximumSize = new System.Drawing.Size(92, 60);
            this.linkLocationLabel.Name = "linkLocationLabel";
            this.linkLocationLabel.Size = new System.Drawing.Size(59, 13);
            this.linkLocationLabel.TabIndex = 7;
            this.linkLocationLabel.Text = ": Unknown";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WWHDHacker.Properties.Resources.MapLinkS_00_l_bflim;
            this.pictureBox1.Location = new System.Drawing.Point(660, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // teleporterToggleHyrule
            // 
            this.teleporterToggleHyrule.Location = new System.Drawing.Point(660, 314);
            this.teleporterToggleHyrule.Name = "teleporterToggleHyrule";
            this.teleporterToggleHyrule.Size = new System.Drawing.Size(101, 23);
            this.teleporterToggleHyrule.TabIndex = 5;
            this.teleporterToggleHyrule.Text = "Hyrule zones";
            this.teleporterToggleHyrule.UseVisualStyleBackColor = true;
            this.teleporterToggleHyrule.Click += new System.EventHandler(this.teleporterToggleHyrule_Click);
            // 
            // islandLabel
            // 
            this.islandLabel.AutoSize = true;
            this.islandLabel.Location = new System.Drawing.Point(22, 328);
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
            this.Controls.Add(this.mainFeaturesPanel);
            this.Controls.Add(this.itemsManager);
            this.Controls.Add(this.miscFeaturesPanel);
            this.Controls.Add(this.advancedPanel);
            this.Controls.Add(this.teleporterPanel);
            this.Controls.Add(this.memfilesPanel);
            this.Controls.Add(this.dataViewerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WWHD Hacker";
            this.miscFeaturesPanel.ResumeLayout(false);
            this.miscFeaturesPanel.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.Levitate.ResumeLayout(false);
            this.Levitate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levitateHeight)).EndInit();
            this.DoorCancel.ResumeLayout(false);
            this.DoorCancel.PerformLayout();
            this.Superspeed.ResumeLayout(false);
            this.Superspeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superswimSpeed)).EndInit();
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
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyNumber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setHCValue)).EndInit();
            this.itemsPanel.ResumeLayout(false);
            this.itemsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxImage1)).EndInit();
            this.memfilesPanel.ResumeLayout(false);
            this.memfilesPanel.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.teleporterPanel.ResumeLayout(false);
            this.teleporterPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.transparentLayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.movingLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teleporterMap)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private GroupBox groupBox13;
        private GroupBox groupBox12;
        private ListView fileRep;
        private ColumnHeader Save;
        private Button loadSF;
        private Button deleteMemfile;
        private Button openMemfileFolder;
        private Button dumpSF;
        private Button openSFDir;
        private Label SavefileIndicator;
        private NumericUpDown levitateHeight;
        private Label label5;
        private NumericUpDown superswimSpeed;
        private Label label34;
        private Button addCustomFavorite;
        private CheckBoxImage checkBoxImage1;
        private CheckBoxImage checkBoxImage8;
        private CheckBoxImage checkBoxImage7;
        private CheckBoxImage checkBoxImage6;
        private CheckBoxImage checkBoxImage5;
        private CheckBoxImage checkBoxImage4;
        private CheckBoxImage checkBoxImage3;
        private CheckBoxImage checkBoxImage2;
        private CheckBoxImage checkBoxImage40;
        private CheckBoxImage checkBoxImage39;
        private CheckBoxImage checkBoxImage38;
        private CheckBoxImage checkBoxImage37;
        private CheckBoxImage checkBoxImage33;
        private CheckBoxImage checkBoxImage34;
        private CheckBoxImage checkBoxImage35;
        private CheckBoxImage checkBoxImage36;
        private CheckBoxImage checkBoxImage25;
        private CheckBoxImage checkBoxImage26;
        private CheckBoxImage checkBoxImage27;
        private CheckBoxImage checkBoxImage28;
        private CheckBoxImage checkBoxImage29;
        private CheckBoxImage checkBoxImage30;
        private CheckBoxImage checkBoxImage31;
        private CheckBoxImage checkBoxImage32;
        private CheckBoxImage checkBoxImage17;
        private CheckBoxImage checkBoxImage18;
        private CheckBoxImage checkBoxImage19;
        private CheckBoxImage checkBoxImage20;
        private CheckBoxImage checkBoxImage21;
        private CheckBoxImage checkBoxImage22;
        private CheckBoxImage checkBoxImage23;
        private CheckBoxImage checkBoxImage24;
        private CheckBoxImage checkBoxImage9;
        private CheckBoxImage checkBoxImage10;
        private CheckBoxImage checkBoxImage11;
        private CheckBoxImage checkBoxImage12;
        private CheckBoxImage checkBoxImage13;
        private CheckBoxImage checkBoxImage14;
        private CheckBoxImage checkBoxImage15;
        private CheckBoxImage checkBoxImage16;
        private CheckBox accuratePositionRestore;
        private CheckBox macrosPausedCheckBox;
        private TreeView memfilesViewer;
        private Panel panel1;
        private Label label6;
        private GroupBox groupBox14;
        private Label label33;
        private Button setKey;
        private NumericUpDown keyNumber;
    }
}

