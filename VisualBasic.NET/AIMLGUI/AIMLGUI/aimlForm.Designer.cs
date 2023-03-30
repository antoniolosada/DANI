namespace AIMLGUI
{
    partial class aimlForm
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromAIMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromDatFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoadSession = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCustomLib = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveSession = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSpeech = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripBottom = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessages = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.chkMoverCabeza = new System.Windows.Forms.CheckBox();
            this.chkMoverBoca = new System.Windows.Forms.CheckBox();
            this.tbMyo = new System.Windows.Forms.TextBox();
            this.chkReconocimientoActivo = new System.Windows.Forms.CheckBox();
            this.cmdMyo = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.saveFileDialogDump = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogDump = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogAIML = new System.Windows.Forms.FolderBrowserDialog();
            this.tmrMoverBoca = new System.Windows.Forms.Timer(this.components);
            this.tmrMyo = new System.Windows.Forms.Timer(this.components);
            this.tmrProcesarVozUWP = new System.Windows.Forms.Timer(this.components);
            this.tmrMoverCabeza = new System.Windows.Forms.Timer(this.components);
            this.TimeOutConversacion = new System.Windows.Forms.Timer(this.components);
            this.cmdPython = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.statusStripBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(428, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBotToolStripMenuItem,
            this.toolStripMenuItemLoadSession,
            this.toolStripMenuItemCustomLib,
            this.toolStripMenuItemSaveSession,
            this.saveBotToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItemSpeech,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newBotToolStripMenuItem
            // 
            this.newBotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromDefaultToolStripMenuItem,
            this.fromAIMLToolStripMenuItem,
            this.fromDatFileToolStripMenuItem,
            this.singleFileToolStripMenuItem});
            this.newBotToolStripMenuItem.Name = "newBotToolStripMenuItem";
            this.newBotToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.newBotToolStripMenuItem.Text = "Open Bot";
            // 
            // fromDefaultToolStripMenuItem
            // 
            this.fromDefaultToolStripMenuItem.Name = "fromDefaultToolStripMenuItem";
            this.fromDefaultToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.fromDefaultToolStripMenuItem.Text = "From Default AIML";
            this.fromDefaultToolStripMenuItem.Click += new System.EventHandler(this.fromDefaultToolStripMenuItem_Click);
            // 
            // fromAIMLToolStripMenuItem
            // 
            this.fromAIMLToolStripMenuItem.Name = "fromAIMLToolStripMenuItem";
            this.fromAIMLToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.fromAIMLToolStripMenuItem.Text = "From AIML files";
            this.fromAIMLToolStripMenuItem.Click += new System.EventHandler(this.fromAIMLToolStripMenuItem_Click);
            // 
            // fromDatFileToolStripMenuItem
            // 
            this.fromDatFileToolStripMenuItem.Name = "fromDatFileToolStripMenuItem";
            this.fromDatFileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.fromDatFileToolStripMenuItem.Text = "From dat file";
            this.fromDatFileToolStripMenuItem.Click += new System.EventHandler(this.fromDatFileToolStripMenuItem_Click);
            // 
            // singleFileToolStripMenuItem
            // 
            this.singleFileToolStripMenuItem.Name = "singleFileToolStripMenuItem";
            this.singleFileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.singleFileToolStripMenuItem.Text = "Single File";
            this.singleFileToolStripMenuItem.Click += new System.EventHandler(this.singleFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItemLoadSession
            // 
            this.toolStripMenuItemLoadSession.Name = "toolStripMenuItemLoadSession";
            this.toolStripMenuItemLoadSession.Size = new System.Drawing.Size(205, 22);
            this.toolStripMenuItemLoadSession.Text = "Load Session";
            this.toolStripMenuItemLoadSession.Click += new System.EventHandler(this.toolStripMenuItemLoadSession_Click);
            // 
            // toolStripMenuItemCustomLib
            // 
            this.toolStripMenuItemCustomLib.Name = "toolStripMenuItemCustomLib";
            this.toolStripMenuItemCustomLib.Size = new System.Drawing.Size(205, 22);
            this.toolStripMenuItemCustomLib.Text = "Load Custom Tag Library";
            this.toolStripMenuItemCustomLib.Click += new System.EventHandler(this.toolStripMenuItemCustomLib_Click);
            // 
            // toolStripMenuItemSaveSession
            // 
            this.toolStripMenuItemSaveSession.Name = "toolStripMenuItemSaveSession";
            this.toolStripMenuItemSaveSession.Size = new System.Drawing.Size(205, 22);
            this.toolStripMenuItemSaveSession.Text = "Save Session";
            this.toolStripMenuItemSaveSession.Click += new System.EventHandler(this.toolStripMenuItemSaveSession_Click);
            // 
            // saveBotToolStripMenuItem
            // 
            this.saveBotToolStripMenuItem.Name = "saveBotToolStripMenuItem";
            this.saveBotToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.saveBotToolStripMenuItem.Text = "Save Bot";
            this.saveBotToolStripMenuItem.Click += new System.EventHandler(this.saveBotToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // toolStripMenuItemSpeech
            // 
            this.toolStripMenuItemSpeech.Checked = true;
            this.toolStripMenuItemSpeech.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemSpeech.Name = "toolStripMenuItemSpeech";
            this.toolStripMenuItemSpeech.Size = new System.Drawing.Size(205, 22);
            this.toolStripMenuItemSpeech.Text = "Synthesize Speech";
            this.toolStripMenuItemSpeech.Click += new System.EventHandler(this.toolStripMenuItemSpeech_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.userToolStripMenuItem,
            this.lastRequestToolStripMenuItem,
            this.lastResultToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // lastRequestToolStripMenuItem
            // 
            this.lastRequestToolStripMenuItem.Name = "lastRequestToolStripMenuItem";
            this.lastRequestToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.lastRequestToolStripMenuItem.Text = "Last Request";
            this.lastRequestToolStripMenuItem.Click += new System.EventHandler(this.lastRequestToolStripMenuItem_Click);
            // 
            // lastResultToolStripMenuItem
            // 
            this.lastResultToolStripMenuItem.Name = "lastResultToolStripMenuItem";
            this.lastResultToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.lastResultToolStripMenuItem.Text = "Last Result";
            this.lastResultToolStripMenuItem.Click += new System.EventHandler(this.lastResultToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.licenseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // statusStripBottom
            // 
            this.statusStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMessages});
            this.statusStripBottom.Location = new System.Drawing.Point(0, 143);
            this.statusStripBottom.Name = "statusStripBottom";
            this.statusStripBottom.Size = new System.Drawing.Size(428, 22);
            this.statusStripBottom.TabIndex = 1;
            this.statusStripBottom.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessages
            // 
            this.toolStripStatusLabelMessages.Name = "toolStripStatusLabelMessages";
            this.toolStripStatusLabelMessages.Size = new System.Drawing.Size(0, 17);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxOutput.Size = new System.Drawing.Size(428, 67);
            this.richTextBoxOutput.TabIndex = 99;
            this.richTextBoxOutput.Text = "Use the \"File\" -> \"Open Bot\" -> \"From AIML files\" menu to load AIML files into th" +
    "e bot\'s brain. (Clicking \"OK\" in the \"Browse for folder\" box will load the AIML " +
    "files from the default location.)";
            this.richTextBoxOutput.TextChanged += new System.EventHandler(this.richTextBoxOutput_TextChanged);
            // 
            // buttonGo
            // 
            this.buttonGo.AutoSize = true;
            this.buttonGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGo.Location = new System.Drawing.Point(0, 0);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(123, 26);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "PROCESAR";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmdPython);
            this.splitContainer1.Panel1.Controls.Add(this.cbModelo);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBoxOutput);
            this.splitContainer1.Panel1.Controls.Add(this.chkMoverCabeza);
            this.splitContainer1.Panel1.Controls.Add(this.chkMoverBoca);
            this.splitContainer1.Panel1.Controls.Add(this.tbMyo);
            this.splitContainer1.Panel1.Controls.Add(this.chkReconocimientoActivo);
            this.splitContainer1.Panel1.Controls.Add(this.cmdMyo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(428, 119);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 5;
            // 
            // cbModelo
            // 
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "davinci",
            "AIML",
            "curie",
            "AIM,davinci",
            "AIM,curie",
            "AIM,chatgpt"});
            this.cbModelo.Location = new System.Drawing.Point(150, 68);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(60, 21);
            this.cbModelo.TabIndex = 11;
            this.cbModelo.Text = "AIML";
            // 
            // chkMoverCabeza
            // 
            this.chkMoverCabeza.AutoSize = true;
            this.chkMoverCabeza.Location = new System.Drawing.Point(358, 72);
            this.chkMoverCabeza.Name = "chkMoverCabeza";
            this.chkMoverCabeza.Size = new System.Drawing.Size(74, 17);
            this.chkMoverCabeza.TabIndex = 10;
            this.chkMoverCabeza.Text = "M.Cabeza";
            this.chkMoverCabeza.UseVisualStyleBackColor = true;
            this.chkMoverCabeza.CheckedChanged += new System.EventHandler(this.chkMoverCabeza_CheckedChanged);
            // 
            // chkMoverBoca
            // 
            this.chkMoverBoca.AutoSize = true;
            this.chkMoverBoca.Location = new System.Drawing.Point(283, 73);
            this.chkMoverBoca.Name = "chkMoverBoca";
            this.chkMoverBoca.Size = new System.Drawing.Size(75, 17);
            this.chkMoverBoca.TabIndex = 6;
            this.chkMoverBoca.Text = "Mov.Boca";
            this.chkMoverBoca.UseVisualStyleBackColor = true;
            this.chkMoverBoca.CheckedChanged += new System.EventHandler(this.chkMoverBoca_CheckedChanged);
            // 
            // tbMyo
            // 
            this.tbMyo.Location = new System.Drawing.Point(74, 68);
            this.tbMyo.Name = "tbMyo";
            this.tbMyo.Size = new System.Drawing.Size(75, 20);
            this.tbMyo.TabIndex = 9;
            // 
            // chkReconocimientoActivo
            // 
            this.chkReconocimientoActivo.AutoSize = true;
            this.chkReconocimientoActivo.Checked = true;
            this.chkReconocimientoActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReconocimientoActivo.Location = new System.Drawing.Point(216, 73);
            this.chkReconocimientoActivo.Name = "chkReconocimientoActivo";
            this.chkReconocimientoActivo.Size = new System.Drawing.Size(67, 17);
            this.chkReconocimientoActivo.TabIndex = 7;
            this.chkReconocimientoActivo.Text = "Rec.Voz";
            this.chkReconocimientoActivo.UseVisualStyleBackColor = true;
            this.chkReconocimientoActivo.CheckedChanged += new System.EventHandler(this.chkReconocimientoActivo_CheckedChanged);
            this.chkReconocimientoActivo.CheckStateChanged += new System.EventHandler(this.chkReconocimientoActivo_CheckStateChanged);
            // 
            // cmdMyo
            // 
            this.cmdMyo.Location = new System.Drawing.Point(34, 67);
            this.cmdMyo.Name = "cmdMyo";
            this.cmdMyo.Size = new System.Drawing.Size(39, 23);
            this.cmdMyo.TabIndex = 8;
            this.cmdMyo.Text = "Myo";
            this.cmdMyo.UseVisualStyleBackColor = true;
            this.cmdMyo.Click += new System.EventHandler(this.cmdMyo_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxInput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonGo);
            this.splitContainer2.Size = new System.Drawing.Size(428, 26);
            this.splitContainer2.SplitterDistance = 301;
            this.splitContainer2.TabIndex = 5;
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInput.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(301, 26);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.TextChanged += new System.EventHandler(this.richTextBoxInput_TextChanged);
            this.richTextBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxInput_KeyPress);
            // 
            // saveFileDialogDump
            // 
            this.saveFileDialogDump.FileName = "Graphmaster.dat";
            this.saveFileDialogDump.Title = "Select location to save graphmaster";
            // 
            // openFileDialogDump
            // 
            this.openFileDialogDump.FileName = "Graphmaster.dat";
            this.openFileDialogDump.Title = "Select the binary file to load into memory";
            // 
            // folderBrowserDialogAIML
            // 
            this.folderBrowserDialogAIML.Description = "Select AIML folder";
            this.folderBrowserDialogAIML.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            this.folderBrowserDialogAIML.ShowNewFolderButton = false;
            // 
            // tmrMoverBoca
            // 
            this.tmrMoverBoca.Interval = 150;
            this.tmrMoverBoca.Tick += new System.EventHandler(this.tmrMoverBoca_Tick);
            // 
            // tmrMyo
            // 
            this.tmrMyo.Tick += new System.EventHandler(this.tmrMyo_Tick);
            // 
            // tmrProcesarVozUWP
            // 
            this.tmrProcesarVozUWP.Tick += new System.EventHandler(this.tmrPRocesarVozUWP_Tick);
            // 
            // tmrMoverCabeza
            // 
            this.tmrMoverCabeza.Interval = 1000;
            this.tmrMoverCabeza.Tick += new System.EventHandler(this.tmrMoverCabeza_Tick);
            // 
            // TimeOutConversacion
            // 
            this.TimeOutConversacion.Interval = 1000;
            this.TimeOutConversacion.Tick += new System.EventHandler(this.TimeOutConversacion_Tick);
            // 
            // cmdPython
            // 
            this.cmdPython.Location = new System.Drawing.Point(5, 67);
            this.cmdPython.Name = "cmdPython";
            this.cmdPython.Size = new System.Drawing.Size(27, 23);
            this.cmdPython.TabIndex = 100;
            this.cmdPython.Text = "Py";
            this.cmdPython.UseVisualStyleBackColor = true;
            // 
            // aimlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 165);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStripBottom);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "aimlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AIML GUI";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.aimlForm_FormClosing);
            this.Load += new System.EventHandler(this.aimlForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripBottom.ResumeLayout(false);
            this.statusStripBottom.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripBottom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessages;
        private System.Windows.Forms.ToolStripMenuItem newBotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromAIMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromDatFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBotToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastResultToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.SaveFileDialog saveFileDialogDump;
        private System.Windows.Forms.OpenFileDialog openFileDialogDump;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogAIML;
        private System.Windows.Forms.ToolStripMenuItem singleFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCustomLib;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSpeech;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fromDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveSession;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoadSession;
        private System.Windows.Forms.CheckBox chkMoverBoca;
        private System.Windows.Forms.CheckBox chkReconocimientoActivo;
        private System.Windows.Forms.Timer tmrMoverBoca;
        private System.Windows.Forms.Button cmdMyo;
        private System.Windows.Forms.TextBox tbMyo;
        private System.Windows.Forms.Timer tmrMyo;
        private System.Windows.Forms.Timer tmrProcesarVozUWP;
        private System.Windows.Forms.CheckBox chkMoverCabeza;
        private System.Windows.Forms.Timer tmrMoverCabeza;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Timer TimeOutConversacion;
        private System.Windows.Forms.Button cmdPython;
    }
}

