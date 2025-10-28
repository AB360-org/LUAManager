
namespace LUAManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptInputLabel = new System.Windows.Forms.Label();
            this.encryptOutputLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.encryptInputFile = new System.Windows.Forms.Label();
            this.encryptPanel = new System.Windows.Forms.Panel();
            this.customKeyEnc = new System.Windows.Forms.TextBox();
            this.encryptBrotipLabel = new System.Windows.Forms.Label();
            this.encryptGameSelect = new System.Windows.Forms.ComboBox();
            this.encryptOutputFile = new System.Windows.Forms.Label();
            this.SevenZipCheck = new System.Windows.Forms.RadioButton();
            this.LZMACheck = new System.Windows.Forms.RadioButton();
            this.RawFileCheck = new System.Windows.Forms.RadioButton();
            this.LetsGo = new System.Windows.Forms.Button();
            this.letsGoText = new System.Windows.Forms.Label();
            this.decryptPanel = new System.Windows.Forms.Panel();
            this.autoUnlzma = new System.Windows.Forms.CheckBox();
            this.customKeyDec = new System.Windows.Forms.TextBox();
            this.decryptInputFileButton = new System.Windows.Forms.Button();
            this.decryptBrotipLabel = new System.Windows.Forms.Label();
            this.autoUnzip = new System.Windows.Forms.CheckBox();
            this.decryptGameSelect = new System.Windows.Forms.ComboBox();
            this.decryptOutputFile = new System.Windows.Forms.Label();
            this.decryptInputLabel = new System.Windows.Forms.Label();
            this.decryptInputFile = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.decryptOutputLabel = new System.Windows.Forms.Label();
            this.decryptOutputFileButton = new System.Windows.Forms.Button();
            this.decodePanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.decodeBrotipLabel = new System.Windows.Forms.Label();
            this.decodeOutputFile = new System.Windows.Forms.Label();
            this.decodeInputLabel = new System.Windows.Forms.Label();
            this.decodeInputFile = new System.Windows.Forms.Label();
            this.decodeOutputLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderRadio = new System.Windows.Forms.RadioButton();
            this.fileRadio = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxDataMode = new System.Windows.Forms.CheckBox();
            this.radioButtonEncrypt = new System.Windows.Forms.RadioButton();
            this.radioButtonDecrypt = new System.Windows.Forms.RadioButton();
            this.panelCrypt = new System.Windows.Forms.Panel();
            this.AssembleButton = new System.Windows.Forms.Button();
            this.assemblePanel = new System.Windows.Forms.Panel();
            this.buttonAssembleInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAssembleOutput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAssembleInput = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAssembleOutput = new System.Windows.Forms.Button();
            this.panelAssemble = new System.Windows.Forms.Panel();
            this.radioButtonDisassemble = new System.Windows.Forms.RadioButton();
            this.radioButtonAssemble = new System.Windows.Forms.RadioButton();
            this.disassemblePanel = new System.Windows.Forms.Panel();
            this.buttonDisassembleInput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDisassembleOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDisassembleInput = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonDisassembleOutput = new System.Windows.Forms.Button();
            this.checkBoxFolderMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.encryptPanel.SuspendLayout();
            this.decryptPanel.SuspendLayout();
            this.decodePanel.SuspendLayout();
            this.panelCrypt.SuspendLayout();
            this.assemblePanel.SuspendLayout();
            this.panelAssemble.SuspendLayout();
            this.disassemblePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptButton
            // 
            this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncryptButton.ForeColor = System.Drawing.Color.White;
            this.EncryptButton.Location = new System.Drawing.Point(14, 14);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(86, 68);
            this.EncryptButton.TabIndex = 0;
            this.EncryptButton.Text = "Crypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DecodeButton.ForeColor = System.Drawing.Color.White;
            this.DecodeButton.Location = new System.Drawing.Point(205, 13);
            this.DecodeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(86, 68);
            this.DecodeButton.TabIndex = 2;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(411, 456);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 94);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Game:";
            // 
            // encryptInputLabel
            // 
            this.encryptInputLabel.AutoSize = true;
            this.encryptInputLabel.ForeColor = System.Drawing.Color.Transparent;
            this.encryptInputLabel.Location = new System.Drawing.Point(0, 57);
            this.encryptInputLabel.Name = "encryptInputLabel";
            this.encryptInputLabel.Size = new System.Drawing.Size(128, 18);
            this.encryptInputLabel.TabIndex = 5;
            this.encryptInputLabel.Text = "Encrypt files from:";
            // 
            // encryptOutputLabel
            // 
            this.encryptOutputLabel.AutoSize = true;
            this.encryptOutputLabel.ForeColor = System.Drawing.Color.Transparent;
            this.encryptOutputLabel.Location = new System.Drawing.Point(1, 111);
            this.encryptOutputLabel.Name = "encryptOutputLabel";
            this.encryptOutputLabel.Size = new System.Drawing.Size(75, 18);
            this.encryptOutputLabel.TabIndex = 6;
            this.encryptOutputLabel.Text = "Output to:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(82, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(137, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // encryptInputFile
            // 
            this.encryptInputFile.ForeColor = System.Drawing.Color.White;
            this.encryptInputFile.Location = new System.Drawing.Point(3, 79);
            this.encryptInputFile.Name = "encryptInputFile";
            this.encryptInputFile.Size = new System.Drawing.Size(455, 22);
            this.encryptInputFile.TabIndex = 9;
            this.encryptInputFile.Text = "InputFilePath";
            this.encryptInputFile.Visible = false;
            // 
            // encryptPanel
            // 
            this.encryptPanel.Controls.Add(this.customKeyEnc);
            this.encryptPanel.Controls.Add(this.button2);
            this.encryptPanel.Controls.Add(this.encryptBrotipLabel);
            this.encryptPanel.Controls.Add(this.encryptGameSelect);
            this.encryptPanel.Controls.Add(this.encryptOutputFile);
            this.encryptPanel.Controls.Add(this.encryptInputLabel);
            this.encryptPanel.Controls.Add(this.encryptInputFile);
            this.encryptPanel.Controls.Add(this.label1);
            this.encryptPanel.Controls.Add(this.encryptOutputLabel);
            this.encryptPanel.Controls.Add(this.button1);
            this.encryptPanel.Controls.Add(this.SevenZipCheck);
            this.encryptPanel.Controls.Add(this.LZMACheck);
            this.encryptPanel.Controls.Add(this.RawFileCheck);
            this.encryptPanel.Location = new System.Drawing.Point(14, 182);
            this.encryptPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encryptPanel.Name = "encryptPanel";
            this.encryptPanel.Size = new System.Drawing.Size(462, 256);
            this.encryptPanel.TabIndex = 10;
            // 
            // customKeyEnc
            // 
            this.customKeyEnc.Location = new System.Drawing.Point(231, 0);
            this.customKeyEnc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customKeyEnc.Name = "customKeyEnc";
            this.customKeyEnc.PlaceholderText = "Put a custom key here";
            this.customKeyEnc.Size = new System.Drawing.Size(227, 26);
            this.customKeyEnc.TabIndex = 29;
            this.customKeyEnc.Visible = false;
            // 
            // encryptBrotipLabel
            // 
            this.encryptBrotipLabel.AutoSize = true;
            this.encryptBrotipLabel.ForeColor = System.Drawing.Color.White;
            this.encryptBrotipLabel.Location = new System.Drawing.Point(0, 188);
            this.encryptBrotipLabel.Name = "encryptBrotipLabel";
            this.encryptBrotipLabel.Size = new System.Drawing.Size(480, 36);
            this.encryptBrotipLabel.TabIndex = 13;
            this.encryptBrotipLabel.Text = "Brotip: Newer versions of AB games always store LUAs in either 7z or LZMA \r\ncompr" +
    "ession.";
            // 
            // encryptGameSelect
            // 
            this.encryptGameSelect.DisplayMember = "1";
            this.encryptGameSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptGameSelect.FormattingEnabled = true;
            this.encryptGameSelect.Items.AddRange(new object[] {
            "Angry Birds Classic",
            "Angry Birds Seasons",
            "Angry Birds Rio",
            "Angry Birds Space",
            "Angry Birds Star Wars",
            "Angry Birds Star Wars II",
            "Angry Birds Friends",
            "Angry Birds Stella",
            "Custom key"});
            this.encryptGameSelect.Location = new System.Drawing.Point(56, 1);
            this.encryptGameSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encryptGameSelect.Name = "encryptGameSelect";
            this.encryptGameSelect.Size = new System.Drawing.Size(166, 26);
            this.encryptGameSelect.TabIndex = 11;
            this.encryptGameSelect.SelectedIndexChanged += new System.EventHandler(this.IndexChangeEnc);
            // 
            // encryptOutputFile
            // 
            this.encryptOutputFile.ForeColor = System.Drawing.Color.White;
            this.encryptOutputFile.Location = new System.Drawing.Point(3, 136);
            this.encryptOutputFile.Name = "encryptOutputFile";
            this.encryptOutputFile.Size = new System.Drawing.Size(455, 53);
            this.encryptOutputFile.TabIndex = 10;
            this.encryptOutputFile.Text = "OutputFilePath";
            this.encryptOutputFile.Visible = false;
            // 
            // SevenZipCheck
            // 
            this.SevenZipCheck.AutoSize = true;
            this.SevenZipCheck.ForeColor = System.Drawing.Color.White;
            this.SevenZipCheck.Location = new System.Drawing.Point(2, 28);
            this.SevenZipCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SevenZipCheck.Name = "SevenZipCheck";
            this.SevenZipCheck.Size = new System.Drawing.Size(150, 22);
            this.SevenZipCheck.TabIndex = 26;
            this.SevenZipCheck.Text = "Export in 7z format";
            this.SevenZipCheck.UseVisualStyleBackColor = true;
            // 
            // LZMACheck
            // 
            this.LZMACheck.AutoSize = true;
            this.LZMACheck.ForeColor = System.Drawing.Color.White;
            this.LZMACheck.Location = new System.Drawing.Point(150, 28);
            this.LZMACheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LZMACheck.Name = "LZMACheck";
            this.LZMACheck.Size = new System.Drawing.Size(170, 22);
            this.LZMACheck.TabIndex = 27;
            this.LZMACheck.Text = "Export in LZMA format";
            this.LZMACheck.UseVisualStyleBackColor = true;
            // 
            // RawFileCheck
            // 
            this.RawFileCheck.AutoSize = true;
            this.RawFileCheck.Checked = true;
            this.RawFileCheck.ForeColor = System.Drawing.Color.White;
            this.RawFileCheck.Location = new System.Drawing.Point(323, 28);
            this.RawFileCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RawFileCheck.Name = "RawFileCheck";
            this.RawFileCheck.Size = new System.Drawing.Size(100, 22);
            this.RawFileCheck.TabIndex = 28;
            this.RawFileCheck.TabStop = true;
            this.RawFileCheck.Text = "Export raw";
            this.RawFileCheck.UseVisualStyleBackColor = true;
            // 
            // LetsGo
            // 
            this.LetsGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LetsGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LetsGo.ForeColor = System.Drawing.Color.White;
            this.LetsGo.Location = new System.Drawing.Point(191, 445);
            this.LetsGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LetsGo.Name = "LetsGo";
            this.LetsGo.Size = new System.Drawing.Size(109, 28);
            this.LetsGo.TabIndex = 11;
            this.LetsGo.Text = "LET\'S GOOO";
            this.LetsGo.UseVisualStyleBackColor = false;
            this.LetsGo.Click += new System.EventHandler(this.LetsGo_Click);
            // 
            // letsGoText
            // 
            this.letsGoText.ForeColor = System.Drawing.Color.White;
            this.letsGoText.Location = new System.Drawing.Point(192, 484);
            this.letsGoText.Name = "letsGoText";
            this.letsGoText.Size = new System.Drawing.Size(108, 28);
            this.letsGoText.TabIndex = 12;
            this.letsGoText.Text = "Lets go!";
            this.letsGoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.letsGoText.Visible = false;
            // 
            // decryptPanel
            // 
            this.decryptPanel.Controls.Add(this.autoUnlzma);
            this.decryptPanel.Controls.Add(this.customKeyDec);
            this.decryptPanel.Controls.Add(this.decryptInputFileButton);
            this.decryptPanel.Controls.Add(this.decryptBrotipLabel);
            this.decryptPanel.Controls.Add(this.autoUnzip);
            this.decryptPanel.Controls.Add(this.decryptGameSelect);
            this.decryptPanel.Controls.Add(this.decryptOutputFile);
            this.decryptPanel.Controls.Add(this.decryptInputLabel);
            this.decryptPanel.Controls.Add(this.decryptInputFile);
            this.decryptPanel.Controls.Add(this.label9);
            this.decryptPanel.Controls.Add(this.decryptOutputLabel);
            this.decryptPanel.Controls.Add(this.decryptOutputFileButton);
            this.decryptPanel.Location = new System.Drawing.Point(14, 182);
            this.decryptPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decryptPanel.Name = "decryptPanel";
            this.decryptPanel.Size = new System.Drawing.Size(462, 256);
            this.decryptPanel.TabIndex = 15;
            this.decryptPanel.Visible = false;
            // 
            // autoUnlzma
            // 
            this.autoUnlzma.AutoSize = true;
            this.autoUnlzma.BackColor = System.Drawing.Color.Transparent;
            this.autoUnlzma.Checked = true;
            this.autoUnlzma.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoUnlzma.ForeColor = System.Drawing.Color.White;
            this.autoUnlzma.Location = new System.Drawing.Point(234, 29);
            this.autoUnlzma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.autoUnlzma.Name = "autoUnlzma";
            this.autoUnlzma.Size = new System.Drawing.Size(191, 22);
            this.autoUnlzma.TabIndex = 21;
            this.autoUnlzma.Text = "Auto-decode LZMA format";
            this.autoUnlzma.UseVisualStyleBackColor = false;
            // 
            // customKeyDec
            // 
            this.customKeyDec.Location = new System.Drawing.Point(231, 0);
            this.customKeyDec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customKeyDec.Name = "customKeyDec";
            this.customKeyDec.PlaceholderText = "Put a custom key here";
            this.customKeyDec.Size = new System.Drawing.Size(227, 26);
            this.customKeyDec.TabIndex = 20;
            this.customKeyDec.Visible = false;
            // 
            // decryptInputFileButton
            // 
            this.decryptInputFileButton.BackColor = System.Drawing.Color.Green;
            this.decryptInputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decryptInputFileButton.ForeColor = System.Drawing.Color.White;
            this.decryptInputFileButton.Location = new System.Drawing.Point(137, 50);
            this.decryptInputFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decryptInputFileButton.Name = "decryptInputFileButton";
            this.decryptInputFileButton.Size = new System.Drawing.Size(86, 28);
            this.decryptInputFileButton.TabIndex = 8;
            this.decryptInputFileButton.Text = "Browse";
            this.decryptInputFileButton.UseVisualStyleBackColor = false;
            this.decryptInputFileButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // decryptBrotipLabel
            // 
            this.decryptBrotipLabel.ForeColor = System.Drawing.Color.White;
            this.decryptBrotipLabel.Location = new System.Drawing.Point(0, 188);
            this.decryptBrotipLabel.Name = "decryptBrotipLabel";
            this.decryptBrotipLabel.Size = new System.Drawing.Size(458, 68);
            this.decryptBrotipLabel.TabIndex = 13;
            this.decryptBrotipLabel.Text = "Brotip: Have 2 folders, one with the files to be decrypted, and another to send t" +
    "he files to.";
            // 
            // autoUnzip
            // 
            this.autoUnzip.AutoSize = true;
            this.autoUnzip.BackColor = System.Drawing.Color.Transparent;
            this.autoUnzip.Checked = true;
            this.autoUnzip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoUnzip.ForeColor = System.Drawing.Color.White;
            this.autoUnzip.Location = new System.Drawing.Point(3, 29);
            this.autoUnzip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.autoUnzip.Name = "autoUnzip";
            this.autoUnzip.Size = new System.Drawing.Size(240, 22);
            this.autoUnzip.TabIndex = 12;
            this.autoUnzip.Text = "Automatically unzip 7z if required";
            this.autoUnzip.UseVisualStyleBackColor = false;
            // 
            // decryptGameSelect
            // 
            this.decryptGameSelect.DisplayMember = "1";
            this.decryptGameSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.decryptGameSelect.FormattingEnabled = true;
            this.decryptGameSelect.Items.AddRange(new object[] {
            "Angry Birds Classic",
            "Angry Birds Seasons",
            "Angry Birds Rio",
            "Angry Birds Space",
            "Angry Birds Star Wars",
            "Angry Birds Star Wars II",
            "Angry Birds Friends",
            "Angry Birds Stella",
            "Custom key"});
            this.decryptGameSelect.Location = new System.Drawing.Point(56, 1);
            this.decryptGameSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decryptGameSelect.Name = "decryptGameSelect";
            this.decryptGameSelect.Size = new System.Drawing.Size(166, 26);
            this.decryptGameSelect.TabIndex = 11;
            this.decryptGameSelect.SelectedIndexChanged += new System.EventHandler(this.checkForFifthopt);
            // 
            // decryptOutputFile
            // 
            this.decryptOutputFile.ForeColor = System.Drawing.Color.White;
            this.decryptOutputFile.Location = new System.Drawing.Point(3, 136);
            this.decryptOutputFile.Name = "decryptOutputFile";
            this.decryptOutputFile.Size = new System.Drawing.Size(455, 53);
            this.decryptOutputFile.TabIndex = 10;
            this.decryptOutputFile.Text = "OutputFilePath";
            this.decryptOutputFile.Visible = false;
            // 
            // decryptInputLabel
            // 
            this.decryptInputLabel.AutoSize = true;
            this.decryptInputLabel.ForeColor = System.Drawing.Color.Transparent;
            this.decryptInputLabel.Location = new System.Drawing.Point(0, 57);
            this.decryptInputLabel.Name = "decryptInputLabel";
            this.decryptInputLabel.Size = new System.Drawing.Size(128, 18);
            this.decryptInputLabel.TabIndex = 5;
            this.decryptInputLabel.Text = "Decrypt files from:";
            // 
            // decryptInputFile
            // 
            this.decryptInputFile.ForeColor = System.Drawing.Color.White;
            this.decryptInputFile.Location = new System.Drawing.Point(3, 79);
            this.decryptInputFile.Name = "decryptInputFile";
            this.decryptInputFile.Size = new System.Drawing.Size(455, 22);
            this.decryptInputFile.TabIndex = 9;
            this.decryptInputFile.Text = "InputFilePath";
            this.decryptInputFile.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "Game:";
            // 
            // decryptOutputLabel
            // 
            this.decryptOutputLabel.AutoSize = true;
            this.decryptOutputLabel.ForeColor = System.Drawing.Color.Transparent;
            this.decryptOutputLabel.Location = new System.Drawing.Point(1, 111);
            this.decryptOutputLabel.Name = "decryptOutputLabel";
            this.decryptOutputLabel.Size = new System.Drawing.Size(75, 18);
            this.decryptOutputLabel.TabIndex = 6;
            this.decryptOutputLabel.Text = "Output to:";
            // 
            // decryptOutputFileButton
            // 
            this.decryptOutputFileButton.BackColor = System.Drawing.Color.Green;
            this.decryptOutputFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decryptOutputFileButton.ForeColor = System.Drawing.Color.White;
            this.decryptOutputFileButton.Location = new System.Drawing.Point(82, 104);
            this.decryptOutputFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decryptOutputFileButton.Name = "decryptOutputFileButton";
            this.decryptOutputFileButton.Size = new System.Drawing.Size(86, 28);
            this.decryptOutputFileButton.TabIndex = 7;
            this.decryptOutputFileButton.Text = "Browse";
            this.decryptOutputFileButton.UseVisualStyleBackColor = false;
            this.decryptOutputFileButton.Click += new System.EventHandler(this.decryptOutputFileButton_Click);
            // 
            // decodePanel
            // 
            this.decodePanel.Controls.Add(this.button3);
            this.decodePanel.Controls.Add(this.decodeBrotipLabel);
            this.decodePanel.Controls.Add(this.decodeOutputFile);
            this.decodePanel.Controls.Add(this.decodeInputLabel);
            this.decodePanel.Controls.Add(this.decodeInputFile);
            this.decodePanel.Controls.Add(this.decodeOutputLabel);
            this.decodePanel.Controls.Add(this.button4);
            this.decodePanel.Location = new System.Drawing.Point(14, 182);
            this.decodePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decodePanel.Name = "decodePanel";
            this.decodePanel.Size = new System.Drawing.Size(462, 256);
            this.decodePanel.TabIndex = 17;
            this.decodePanel.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(137, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // decodeBrotipLabel
            // 
            this.decodeBrotipLabel.ForeColor = System.Drawing.Color.White;
            this.decodeBrotipLabel.Location = new System.Drawing.Point(0, 158);
            this.decodeBrotipLabel.Name = "decodeBrotipLabel";
            this.decodeBrotipLabel.Size = new System.Drawing.Size(458, 48);
            this.decodeBrotipLabel.TabIndex = 13;
            this.decodeBrotipLabel.Text = "Brotip: Make sure all LUA files in the folder are not encrypted before you contin" +
    "ue\r\n";
            // 
            // decodeOutputFile
            // 
            this.decodeOutputFile.ForeColor = System.Drawing.Color.White;
            this.decodeOutputFile.Location = new System.Drawing.Point(3, 91);
            this.decodeOutputFile.Name = "decodeOutputFile";
            this.decodeOutputFile.Size = new System.Drawing.Size(455, 53);
            this.decodeOutputFile.TabIndex = 10;
            this.decodeOutputFile.Text = "OutputFilePath";
            this.decodeOutputFile.Visible = false;
            // 
            // decodeInputLabel
            // 
            this.decodeInputLabel.AutoSize = true;
            this.decodeInputLabel.ForeColor = System.Drawing.Color.Transparent;
            this.decodeInputLabel.Location = new System.Drawing.Point(3, 7);
            this.decodeInputLabel.Name = "decodeInputLabel";
            this.decodeInputLabel.Size = new System.Drawing.Size(121, 18);
            this.decodeInputLabel.TabIndex = 5;
            this.decodeInputLabel.Text = "Decode files from:";
            // 
            // decodeInputFile
            // 
            this.decodeInputFile.ForeColor = System.Drawing.Color.White;
            this.decodeInputFile.Location = new System.Drawing.Point(3, 35);
            this.decodeInputFile.Name = "decodeInputFile";
            this.decodeInputFile.Size = new System.Drawing.Size(455, 22);
            this.decodeInputFile.TabIndex = 9;
            this.decodeInputFile.Text = "InputFilePath";
            this.decodeInputFile.Visible = false;
            // 
            // decodeOutputLabel
            // 
            this.decodeOutputLabel.AutoSize = true;
            this.decodeOutputLabel.ForeColor = System.Drawing.Color.Transparent;
            this.decodeOutputLabel.Location = new System.Drawing.Point(3, 66);
            this.decodeOutputLabel.Name = "decodeOutputLabel";
            this.decodeOutputLabel.Size = new System.Drawing.Size(75, 18);
            this.decodeOutputLabel.TabIndex = 6;
            this.decodeOutputLabel.Text = "Output to:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(82, 60);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // folderRadio
            // 
            this.folderRadio.AutoSize = true;
            this.folderRadio.ForeColor = System.Drawing.Color.White;
            this.folderRadio.Location = new System.Drawing.Point(255, 148);
            this.folderRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.folderRadio.Name = "folderRadio";
            this.folderRadio.Size = new System.Drawing.Size(72, 22);
            this.folderRadio.TabIndex = 18;
            this.folderRadio.TabStop = true;
            this.folderRadio.Text = "Folder";
            this.folderRadio.UseVisualStyleBackColor = true;
            this.folderRadio.CheckedChanged += new System.EventHandler(this.folderRadio_CheckedChanged);
            // 
            // fileRadio
            // 
            this.fileRadio.AutoSize = true;
            this.fileRadio.ForeColor = System.Drawing.Color.White;
            this.fileRadio.Location = new System.Drawing.Point(192, 148);
            this.fileRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileRadio.Name = "fileRadio";
            this.fileRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fileRadio.Size = new System.Drawing.Size(52, 22);
            this.fileRadio.TabIndex = 19;
            this.fileRadio.TabStop = true;
            this.fileRadio.Text = "File";
            this.fileRadio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fileRadio.UseVisualStyleBackColor = true;
            this.fileRadio.CheckedChanged += new System.EventHandler(this.fileRadio_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxDataMode
            // 
            this.checkBoxDataMode.AutoSize = true;
            this.checkBoxDataMode.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDataMode.ForeColor = System.Drawing.Color.White;
            this.checkBoxDataMode.Location = new System.Drawing.Point(333, 29);
            this.checkBoxDataMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxDataMode.Name = "checkBoxDataMode";
            this.checkBoxDataMode.Size = new System.Drawing.Size(119, 22);
            this.checkBoxDataMode.TabIndex = 20;
            this.checkBoxDataMode.Text = "Data LUA mode";
            this.checkBoxDataMode.UseVisualStyleBackColor = false;
            // 
            // radioButtonEncrypt
            // 
            this.radioButtonEncrypt.AutoSize = true;
            this.radioButtonEncrypt.ForeColor = System.Drawing.Color.White;
            this.radioButtonEncrypt.Location = new System.Drawing.Point(152, 26);
            this.radioButtonEncrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonEncrypt.Name = "radioButtonEncrypt";
            this.radioButtonEncrypt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonEncrypt.Size = new System.Drawing.Size(79, 22);
            this.radioButtonEncrypt.TabIndex = 22;
            this.radioButtonEncrypt.TabStop = true;
            this.radioButtonEncrypt.Text = "Encrypt";
            this.radioButtonEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonEncrypt.UseVisualStyleBackColor = true;
            this.radioButtonEncrypt.CheckedChanged += new System.EventHandler(this.radioButtonEncrypt_CheckedChanged);
            // 
            // radioButtonDecrypt
            // 
            this.radioButtonDecrypt.AutoSize = true;
            this.radioButtonDecrypt.ForeColor = System.Drawing.Color.White;
            this.radioButtonDecrypt.Location = new System.Drawing.Point(238, 26);
            this.radioButtonDecrypt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonDecrypt.Name = "radioButtonDecrypt";
            this.radioButtonDecrypt.Size = new System.Drawing.Size(79, 22);
            this.radioButtonDecrypt.TabIndex = 21;
            this.radioButtonDecrypt.TabStop = true;
            this.radioButtonDecrypt.Text = "Decrypt";
            this.radioButtonDecrypt.UseVisualStyleBackColor = true;
            this.radioButtonDecrypt.CheckedChanged += new System.EventHandler(this.radioButtonDecrypt_CheckedChanged);
            // 
            // panelCrypt
            // 
            this.panelCrypt.Controls.Add(this.radioButtonEncrypt);
            this.panelCrypt.Controls.Add(this.radioButtonDecrypt);
            this.panelCrypt.Controls.Add(this.checkBoxDataMode);
            this.panelCrypt.Location = new System.Drawing.Point(17, 89);
            this.panelCrypt.Name = "panelCrypt";
            this.panelCrypt.Size = new System.Drawing.Size(451, 51);
            this.panelCrypt.TabIndex = 23;
            // 
            // AssembleButton
            // 
            this.AssembleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AssembleButton.ForeColor = System.Drawing.Color.White;
            this.AssembleButton.Location = new System.Drawing.Point(386, 13);
            this.AssembleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AssembleButton.Name = "AssembleButton";
            this.AssembleButton.Size = new System.Drawing.Size(86, 68);
            this.AssembleButton.TabIndex = 24;
            this.AssembleButton.Text = "Assemble";
            this.AssembleButton.UseVisualStyleBackColor = true;
            this.AssembleButton.Click += new System.EventHandler(this.AssembleButton_Click);
            // 
            // assemblePanel
            // 
            this.assemblePanel.Controls.Add(this.buttonAssembleInput);
            this.assemblePanel.Controls.Add(this.label2);
            this.assemblePanel.Controls.Add(this.labelAssembleOutput);
            this.assemblePanel.Controls.Add(this.label4);
            this.assemblePanel.Controls.Add(this.labelAssembleInput);
            this.assemblePanel.Controls.Add(this.label7);
            this.assemblePanel.Controls.Add(this.buttonAssembleOutput);
            this.assemblePanel.Location = new System.Drawing.Point(14, 182);
            this.assemblePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.assemblePanel.Name = "assemblePanel";
            this.assemblePanel.Size = new System.Drawing.Size(462, 256);
            this.assemblePanel.TabIndex = 25;
            this.assemblePanel.Visible = false;
            // 
            // buttonAssembleInput
            // 
            this.buttonAssembleInput.BackColor = System.Drawing.Color.Green;
            this.buttonAssembleInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAssembleInput.ForeColor = System.Drawing.Color.White;
            this.buttonAssembleInput.Location = new System.Drawing.Point(137, 4);
            this.buttonAssembleInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAssembleInput.Name = "buttonAssembleInput";
            this.buttonAssembleInput.Size = new System.Drawing.Size(86, 28);
            this.buttonAssembleInput.TabIndex = 8;
            this.buttonAssembleInput.Text = "Browse";
            this.buttonAssembleInput.UseVisualStyleBackColor = false;
            this.buttonAssembleInput.Click += new System.EventHandler(this.buttonAssembleInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Brotip: Newer versions of AB games always store LUAs in either 7z or LZMA \r\ncompr" +
    "ession.";
            // 
            // labelAssembleOutput
            // 
            this.labelAssembleOutput.ForeColor = System.Drawing.Color.White;
            this.labelAssembleOutput.Location = new System.Drawing.Point(3, 91);
            this.labelAssembleOutput.Name = "labelAssembleOutput";
            this.labelAssembleOutput.Size = new System.Drawing.Size(455, 53);
            this.labelAssembleOutput.TabIndex = 10;
            this.labelAssembleOutput.Text = "OutputFilePath";
            this.labelAssembleOutput.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Assemble files from:";
            // 
            // labelAssembleInput
            // 
            this.labelAssembleInput.ForeColor = System.Drawing.Color.White;
            this.labelAssembleInput.Location = new System.Drawing.Point(3, 35);
            this.labelAssembleInput.Name = "labelAssembleInput";
            this.labelAssembleInput.Size = new System.Drawing.Size(455, 22);
            this.labelAssembleInput.TabIndex = 9;
            this.labelAssembleInput.Text = "InputFilePath";
            this.labelAssembleInput.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Output to:";
            // 
            // buttonAssembleOutput
            // 
            this.buttonAssembleOutput.BackColor = System.Drawing.Color.Green;
            this.buttonAssembleOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAssembleOutput.ForeColor = System.Drawing.Color.White;
            this.buttonAssembleOutput.Location = new System.Drawing.Point(82, 60);
            this.buttonAssembleOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAssembleOutput.Name = "buttonAssembleOutput";
            this.buttonAssembleOutput.Size = new System.Drawing.Size(86, 28);
            this.buttonAssembleOutput.TabIndex = 7;
            this.buttonAssembleOutput.Text = "Browse";
            this.buttonAssembleOutput.UseVisualStyleBackColor = false;
            this.buttonAssembleOutput.Click += new System.EventHandler(this.buttonAssembleOutput_Click);
            // 
            // panelAssemble
            // 
            this.panelAssemble.Controls.Add(this.radioButtonDisassemble);
            this.panelAssemble.Controls.Add(this.radioButtonAssemble);
            this.panelAssemble.Location = new System.Drawing.Point(16, 85);
            this.panelAssemble.Name = "panelAssemble";
            this.panelAssemble.Size = new System.Drawing.Size(455, 52);
            this.panelAssemble.TabIndex = 26;
            this.panelAssemble.Visible = false;
            // 
            // radioButtonDisassemble
            // 
            this.radioButtonDisassemble.AutoSize = true;
            this.radioButtonDisassemble.ForeColor = System.Drawing.Color.White;
            this.radioButtonDisassemble.Location = new System.Drawing.Point(239, 30);
            this.radioButtonDisassemble.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonDisassemble.Name = "radioButtonDisassemble";
            this.radioButtonDisassemble.Size = new System.Drawing.Size(104, 22);
            this.radioButtonDisassemble.TabIndex = 21;
            this.radioButtonDisassemble.TabStop = true;
            this.radioButtonDisassemble.Text = "Disassemble";
            this.radioButtonDisassemble.UseVisualStyleBackColor = true;
            this.radioButtonDisassemble.CheckedChanged += new System.EventHandler(this.radioButtonDisassemble_CheckedChanged);
            // 
            // radioButtonAssemble
            // 
            this.radioButtonAssemble.AutoSize = true;
            this.radioButtonAssemble.ForeColor = System.Drawing.Color.White;
            this.radioButtonAssemble.Location = new System.Drawing.Point(150, 30);
            this.radioButtonAssemble.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonAssemble.Name = "radioButtonAssemble";
            this.radioButtonAssemble.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonAssemble.Size = new System.Drawing.Size(86, 22);
            this.radioButtonAssemble.TabIndex = 22;
            this.radioButtonAssemble.TabStop = true;
            this.radioButtonAssemble.Text = "Assemble";
            this.radioButtonAssemble.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonAssemble.UseVisualStyleBackColor = true;
            this.radioButtonAssemble.CheckedChanged += new System.EventHandler(this.radioButtonAssemble_CheckedChanged);
            // 
            // disassemblePanel
            // 
            this.disassemblePanel.Controls.Add(this.buttonDisassembleInput);
            this.disassemblePanel.Controls.Add(this.label3);
            this.disassemblePanel.Controls.Add(this.labelDisassembleOutput);
            this.disassemblePanel.Controls.Add(this.label6);
            this.disassemblePanel.Controls.Add(this.labelDisassembleInput);
            this.disassemblePanel.Controls.Add(this.label10);
            this.disassemblePanel.Controls.Add(this.buttonDisassembleOutput);
            this.disassemblePanel.Location = new System.Drawing.Point(14, 182);
            this.disassemblePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.disassemblePanel.Name = "disassemblePanel";
            this.disassemblePanel.Size = new System.Drawing.Size(462, 256);
            this.disassemblePanel.TabIndex = 27;
            this.disassemblePanel.Visible = false;
            // 
            // buttonDisassembleInput
            // 
            this.buttonDisassembleInput.BackColor = System.Drawing.Color.Green;
            this.buttonDisassembleInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDisassembleInput.ForeColor = System.Drawing.Color.White;
            this.buttonDisassembleInput.Location = new System.Drawing.Point(137, 4);
            this.buttonDisassembleInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDisassembleInput.Name = "buttonDisassembleInput";
            this.buttonDisassembleInput.Size = new System.Drawing.Size(86, 28);
            this.buttonDisassembleInput.TabIndex = 8;
            this.buttonDisassembleInput.Text = "Browse";
            this.buttonDisassembleInput.UseVisualStyleBackColor = false;
            this.buttonDisassembleInput.Click += new System.EventHandler(this.buttonDisassembleInput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Brotip: Newer versions of AB games always store LUAs in either 7z or LZMA \r\ncompr" +
    "ession.";
            // 
            // labelDisassembleOutput
            // 
            this.labelDisassembleOutput.ForeColor = System.Drawing.Color.White;
            this.labelDisassembleOutput.Location = new System.Drawing.Point(3, 91);
            this.labelDisassembleOutput.Name = "labelDisassembleOutput";
            this.labelDisassembleOutput.Size = new System.Drawing.Size(455, 53);
            this.labelDisassembleOutput.TabIndex = 10;
            this.labelDisassembleOutput.Text = "OutputFilePath";
            this.labelDisassembleOutput.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Disassemble files from:";
            // 
            // labelDisassembleInput
            // 
            this.labelDisassembleInput.ForeColor = System.Drawing.Color.White;
            this.labelDisassembleInput.Location = new System.Drawing.Point(3, 35);
            this.labelDisassembleInput.Name = "labelDisassembleInput";
            this.labelDisassembleInput.Size = new System.Drawing.Size(455, 22);
            this.labelDisassembleInput.TabIndex = 9;
            this.labelDisassembleInput.Text = "InputFilePath";
            this.labelDisassembleInput.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(3, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Output to:";
            // 
            // buttonDisassembleOutput
            // 
            this.buttonDisassembleOutput.BackColor = System.Drawing.Color.Green;
            this.buttonDisassembleOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDisassembleOutput.ForeColor = System.Drawing.Color.White;
            this.buttonDisassembleOutput.Location = new System.Drawing.Point(82, 60);
            this.buttonDisassembleOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDisassembleOutput.Name = "buttonDisassembleOutput";
            this.buttonDisassembleOutput.Size = new System.Drawing.Size(86, 28);
            this.buttonDisassembleOutput.TabIndex = 7;
            this.buttonDisassembleOutput.Text = "Browse";
            this.buttonDisassembleOutput.UseVisualStyleBackColor = false;
            this.buttonDisassembleOutput.Click += new System.EventHandler(this.buttonDisassembleOutput_Click);
            // 
            // checkBoxFolderMode
            // 
            this.checkBoxFolderMode.AutoSize = true;
            this.checkBoxFolderMode.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFolderMode.Checked = true;
            this.checkBoxFolderMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFolderMode.ForeColor = System.Drawing.Color.White;
            this.checkBoxFolderMode.Location = new System.Drawing.Point(20, 118);
            this.checkBoxFolderMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxFolderMode.Name = "checkBoxFolderMode";
            this.checkBoxFolderMode.Size = new System.Drawing.Size(101, 22);
            this.checkBoxFolderMode.TabIndex = 28;
            this.checkBoxFolderMode.Text = "Subfolders";
            this.checkBoxFolderMode.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(487, 532);
            this.Controls.Add(this.checkBoxFolderMode);
            this.Controls.Add(this.disassemblePanel);
            this.Controls.Add(this.assemblePanel);
            this.Controls.Add(this.encryptPanel);
            this.Controls.Add(this.decryptPanel);
            this.Controls.Add(this.decodePanel);
            this.Controls.Add(this.panelCrypt);
            this.Controls.Add(this.panelAssemble);
            this.Controls.Add(this.AssembleButton);
            this.Controls.Add(this.fileRadio);
            this.Controls.Add(this.folderRadio);
            this.Controls.Add(this.letsGoText);
            this.Controls.Add(this.LetsGo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.EncryptButton);
            this.Font = new System.Drawing.Font("AngryBirds", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(505, 579);
            this.MinimumSize = new System.Drawing.Size(505, 579);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt and decrypt LUA files for Angry Birds";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.encryptPanel.ResumeLayout(false);
            this.encryptPanel.PerformLayout();
            this.decryptPanel.ResumeLayout(false);
            this.decryptPanel.PerformLayout();
            this.decodePanel.ResumeLayout(false);
            this.decodePanel.PerformLayout();
            this.panelCrypt.ResumeLayout(false);
            this.panelCrypt.PerformLayout();
            this.assemblePanel.ResumeLayout(false);
            this.assemblePanel.PerformLayout();
            this.panelAssemble.ResumeLayout(false);
            this.panelAssemble.PerformLayout();
            this.disassemblePanel.ResumeLayout(false);
            this.disassemblePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label encryptInputLabel;
        private System.Windows.Forms.Label encryptOutputLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label encryptInputFile;
        private System.Windows.Forms.Panel encryptPanel;
        private System.Windows.Forms.ComboBox encryptGameSelect;
        private System.Windows.Forms.Label encryptOutputFile;
        private System.Windows.Forms.Label encryptBrotipLabel;
        private System.Windows.Forms.Button LetsGo;
        private System.Windows.Forms.Label letsGoText;
        private System.Windows.Forms.Panel decryptPanel;
        private System.Windows.Forms.Button decryptInputFileButton;
        private System.Windows.Forms.Label decryptBrotipLabel;
        private System.Windows.Forms.CheckBox autoUnzip;
        private System.Windows.Forms.ComboBox decryptGameSelect;
        private System.Windows.Forms.Label decryptOutputFile;
        private System.Windows.Forms.Label decryptInputLabel;
        private System.Windows.Forms.Label decryptInputFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label decryptOutputLabel;
        private System.Windows.Forms.Button decryptOutputFileButton;
        private System.Windows.Forms.Panel decodePanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label decodeBrotipLabel;
        private System.Windows.Forms.Label decodeOutputFile;
        private System.Windows.Forms.Label decodeInputLabel;
        private System.Windows.Forms.Label decodeInputFile;
        private System.Windows.Forms.Label decodeOutputLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.TextBox customKeyEnc;
        private System.Windows.Forms.RadioButton SevenZipCheck;
        private System.Windows.Forms.RadioButton LZMACheck;
        private System.Windows.Forms.RadioButton RawFileCheck;
        private System.Windows.Forms.CheckBox autoUnlzma;
        private System.Windows.Forms.TextBox customKeyDec;
        private System.Windows.Forms.RadioButton folderRadio;
        private System.Windows.Forms.RadioButton fileRadio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBoxDataMode;
        private System.Windows.Forms.RadioButton radioButtonEncrypt;
        private System.Windows.Forms.RadioButton radioButtonDecrypt;
        private System.Windows.Forms.Panel panelCrypt;
        private System.Windows.Forms.Button AssembleButton;
        private System.Windows.Forms.Panel assemblePanel;
        private System.Windows.Forms.Button buttonAssembleInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAssembleOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAssembleInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAssembleOutput;
        private System.Windows.Forms.Panel panelAssemble;
        private System.Windows.Forms.RadioButton radioButtonDisassemble;
        private System.Windows.Forms.RadioButton radioButtonAssemble;
        private System.Windows.Forms.Panel disassemblePanel;
        private System.Windows.Forms.Button buttonDisassembleInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDisassembleOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDisassembleInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonDisassembleOutput;
        private System.Windows.Forms.CheckBox checkBoxFolderMode;
    }
}

