namespace SendMailApp
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
            this.cbConfigName = new System.Windows.Forms.ComboBox();
            this.btnNewConfig = new System.Windows.Forms.Button();
            this.lblConfigName = new System.Windows.Forms.Label();
            this.ckbColMail = new System.Windows.Forms.CheckBox();
            this.txtSkipLines = new System.Windows.Forms.TextBox();
            this.lblSkipLines = new System.Windows.Forms.Label();
            this.btnDelColConfig = new System.Windows.Forms.Button();
            this.lbConfigs = new System.Windows.Forms.ListBox();
            this.btnColAdd = new System.Windows.Forms.Button();
            this.txtColReplace = new System.Windows.Forms.TextBox();
            this.lblColReplace = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblColPosition = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.gbEncryption = new System.Windows.Forms.GroupBox();
            this.rbtNoCript = new System.Windows.Forms.RadioButton();
            this.rbtTsl = new System.Windows.Forms.RadioButton();
            this.rbtSsl = new System.Windows.Forms.RadioButton();
            this.gbTemplateType = new System.Windows.Forms.GroupBox();
            this.rbtTxt = new System.Windows.Forms.RadioButton();
            this.rbtHtml = new System.Windows.Forms.RadioButton();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.lblSmtp = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnFindCsv = new System.Windows.Forms.Button();
            this.txtCsvFile = new System.Windows.Forms.TextBox();
            this.lblCsv = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.btnLoadColumns = new System.Windows.Forms.Button();
            this.cbColHeader = new System.Windows.Forms.ComboBox();
            this.cbSheets = new System.Windows.Forms.ComboBox();
            this.lblSheet = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.gbEncryption.SuspendLayout();
            this.gbTemplateType.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbConfigName
            // 
            this.cbConfigName.FormattingEnabled = true;
            this.cbConfigName.Location = new System.Drawing.Point(159, 7);
            this.cbConfigName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbConfigName.Name = "cbConfigName";
            this.cbConfigName.Size = new System.Drawing.Size(432, 24);
            this.cbConfigName.TabIndex = 65;
            this.cbConfigName.SelectedIndexChanged += new System.EventHandler(this.cbConfigName_SelectedIndexChanged);
            // 
            // btnNewConfig
            // 
            this.btnNewConfig.Location = new System.Drawing.Point(600, 5);
            this.btnNewConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewConfig.Name = "btnNewConfig";
            this.btnNewConfig.Size = new System.Drawing.Size(155, 28);
            this.btnNewConfig.TabIndex = 64;
            this.btnNewConfig.Text = "Nova Configuração";
            this.btnNewConfig.UseVisualStyleBackColor = true;
            this.btnNewConfig.Click += new System.EventHandler(this.btnNewConfig_Click);
            // 
            // lblConfigName
            // 
            this.lblConfigName.AutoSize = true;
            this.lblConfigName.Location = new System.Drawing.Point(12, 11);
            this.lblConfigName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfigName.Name = "lblConfigName";
            this.lblConfigName.Size = new System.Drawing.Size(137, 17);
            this.lblConfigName.TabIndex = 63;
            this.lblConfigName.Text = "Nome Configuração:";
            // 
            // ckbColMail
            // 
            this.ckbColMail.AutoSize = true;
            this.ckbColMail.Location = new System.Drawing.Point(701, 310);
            this.ckbColMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbColMail.Name = "ckbColMail";
            this.ckbColMail.Size = new System.Drawing.Size(137, 21);
            this.ckbColMail.TabIndex = 62;
            this.ckbColMail.Text = "Coluna do E-mail";
            this.ckbColMail.UseVisualStyleBackColor = true;
            // 
            // txtSkipLines
            // 
            this.txtSkipLines.Location = new System.Drawing.Point(712, 135);
            this.txtSkipLines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSkipLines.Name = "txtSkipLines";
            this.txtSkipLines.Size = new System.Drawing.Size(105, 22);
            this.txtSkipLines.TabIndex = 61;
            // 
            // lblSkipLines
            // 
            this.lblSkipLines.AutoSize = true;
            this.lblSkipLines.Location = new System.Drawing.Point(601, 139);
            this.lblSkipLines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSkipLines.Name = "lblSkipLines";
            this.lblSkipLines.Size = new System.Drawing.Size(103, 17);
            this.lblSkipLines.TabIndex = 60;
            this.lblSkipLines.Text = "Linhas a Pular:";
            // 
            // btnDelColConfig
            // 
            this.btnDelColConfig.Location = new System.Drawing.Point(735, 405);
            this.btnDelColConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelColConfig.Name = "btnDelColConfig";
            this.btnDelColConfig.Size = new System.Drawing.Size(100, 28);
            this.btnDelColConfig.TabIndex = 59;
            this.btnDelColConfig.Text = "Remover";
            this.btnDelColConfig.UseVisualStyleBackColor = true;
            this.btnDelColConfig.Click += new System.EventHandler(this.btnDelColConfig_Click);
            // 
            // lbConfigs
            // 
            this.lbConfigs.FormattingEnabled = true;
            this.lbConfigs.ItemHeight = 16;
            this.lbConfigs.Location = new System.Drawing.Point(9, 352);
            this.lbConfigs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbConfigs.Name = "lbConfigs";
            this.lbConfigs.Size = new System.Drawing.Size(716, 164);
            this.lbConfigs.TabIndex = 58;
            // 
            // btnColAdd
            // 
            this.btnColAdd.Location = new System.Drawing.Point(849, 304);
            this.btnColAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnColAdd.Name = "btnColAdd";
            this.btnColAdd.Size = new System.Drawing.Size(100, 28);
            this.btnColAdd.TabIndex = 57;
            this.btnColAdd.Text = "Adicionar";
            this.btnColAdd.UseVisualStyleBackColor = true;
            this.btnColAdd.Click += new System.EventHandler(this.btnColAdd_Click);
            // 
            // txtColReplace
            // 
            this.txtColReplace.Location = new System.Drawing.Point(567, 308);
            this.txtColReplace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtColReplace.Name = "txtColReplace";
            this.txtColReplace.Size = new System.Drawing.Size(125, 22);
            this.txtColReplace.TabIndex = 56;
            // 
            // lblColReplace
            // 
            this.lblColReplace.AutoSize = true;
            this.lblColReplace.Location = new System.Drawing.Point(439, 311);
            this.lblColReplace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColReplace.Name = "lblColReplace";
            this.lblColReplace.Size = new System.Drawing.Size(118, 17);
            this.lblColReplace.TabIndex = 55;
            this.lblColReplace.Text = "Tag Substituição:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(368, 305);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(61, 22);
            this.txtPosition.TabIndex = 54;
            this.txtPosition.Text = "1";
            // 
            // lblColPosition
            // 
            this.lblColPosition.AutoSize = true;
            this.lblColPosition.Location = new System.Drawing.Point(296, 311);
            this.lblColPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColPosition.Name = "lblColPosition";
            this.lblColPosition.Size = new System.Drawing.Size(62, 17);
            this.lblColPosition.TabIndex = 53;
            this.lblColPosition.Text = "Posição:";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(5, 310);
            this.lblCol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(56, 17);
            this.lblCol.TabIndex = 51;
            this.lblCol.Text = "Coluna:";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(763, 5);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(185, 28);
            this.btnSaveConfig.TabIndex = 50;
            this.btnSaveConfig.Text = "Salvar Configuração";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(85, 108);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(507, 78);
            this.txtSubject.TabIndex = 49;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(29, 135);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(47, 17);
            this.lblSubject.TabIndex = 48;
            this.lblSubject.Text = "Titulo:";
            // 
            // gbEncryption
            // 
            this.gbEncryption.Controls.Add(this.rbtNoCript);
            this.gbEncryption.Controls.Add(this.rbtTsl);
            this.gbEncryption.Controls.Add(this.rbtSsl);
            this.gbEncryption.Location = new System.Drawing.Point(771, 62);
            this.gbEncryption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEncryption.Name = "gbEncryption";
            this.gbEncryption.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEncryption.Size = new System.Drawing.Size(233, 50);
            this.gbEncryption.TabIndex = 47;
            this.gbEncryption.TabStop = false;
            this.gbEncryption.Text = "Criptografia";
            // 
            // rbtNoCript
            // 
            this.rbtNoCript.AutoSize = true;
            this.rbtNoCript.Location = new System.Drawing.Point(157, 22);
            this.rbtNoCript.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtNoCript.Name = "rbtNoCript";
            this.rbtNoCript.Size = new System.Drawing.Size(57, 21);
            this.rbtNoCript.TabIndex = 9;
            this.rbtNoCript.Text = "Sem";
            this.rbtNoCript.UseVisualStyleBackColor = true;
            // 
            // rbtTsl
            // 
            this.rbtTsl.AutoSize = true;
            this.rbtTsl.Location = new System.Drawing.Point(89, 22);
            this.rbtTsl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtTsl.Name = "rbtTsl";
            this.rbtTsl.Size = new System.Drawing.Size(55, 21);
            this.rbtTsl.TabIndex = 8;
            this.rbtTsl.Text = "TSL";
            this.rbtTsl.UseVisualStyleBackColor = true;
            // 
            // rbtSsl
            // 
            this.rbtSsl.AutoSize = true;
            this.rbtSsl.Checked = true;
            this.rbtSsl.Location = new System.Drawing.Point(21, 22);
            this.rbtSsl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtSsl.Name = "rbtSsl";
            this.rbtSsl.Size = new System.Drawing.Size(55, 21);
            this.rbtSsl.TabIndex = 7;
            this.rbtSsl.TabStop = true;
            this.rbtSsl.Text = "SSL";
            this.rbtSsl.UseVisualStyleBackColor = true;
            // 
            // gbTemplateType
            // 
            this.gbTemplateType.Controls.Add(this.rbtTxt);
            this.gbTemplateType.Controls.Add(this.rbtHtml);
            this.gbTemplateType.Location = new System.Drawing.Point(709, 187);
            this.gbTemplateType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTemplateType.Name = "gbTemplateType";
            this.gbTemplateType.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTemplateType.Size = new System.Drawing.Size(176, 50);
            this.gbTemplateType.TabIndex = 46;
            this.gbTemplateType.TabStop = false;
            this.gbTemplateType.Text = "Tipo";
            // 
            // rbtTxt
            // 
            this.rbtTxt.AutoSize = true;
            this.rbtTxt.Location = new System.Drawing.Point(103, 22);
            this.rbtTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtTxt.Name = "rbtTxt";
            this.rbtTxt.Size = new System.Drawing.Size(56, 21);
            this.rbtTxt.TabIndex = 8;
            this.rbtTxt.Text = "TXT";
            this.rbtTxt.UseVisualStyleBackColor = true;
            // 
            // rbtHtml
            // 
            this.rbtHtml.AutoSize = true;
            this.rbtHtml.Checked = true;
            this.rbtHtml.Location = new System.Drawing.Point(21, 22);
            this.rbtHtml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtHtml.Name = "rbtHtml";
            this.rbtHtml.Size = new System.Drawing.Size(67, 21);
            this.rbtHtml.TabIndex = 7;
            this.rbtHtml.TabStop = true;
            this.rbtHtml.Text = "HTML";
            this.rbtHtml.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(656, 76);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(105, 22);
            this.txtPort.TabIndex = 45;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(601, 80);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(46, 17);
            this.lblPort.TabIndex = 44;
            this.lblPort.Text = "Porta:";
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(85, 76);
            this.txtSmtp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(507, 22);
            this.txtSmtp.TabIndex = 43;
            // 
            // lblSmtp
            // 
            this.lblSmtp.AutoSize = true;
            this.lblSmtp.Location = new System.Drawing.Point(24, 80);
            this.lblSmtp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSmtp.Name = "lblSmtp";
            this.lblSmtp.Size = new System.Drawing.Size(50, 17);
            this.lblSmtp.TabIndex = 42;
            this.lblSmtp.Text = "SMTP:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(492, 208);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 28);
            this.btnFind.TabIndex = 41;
            this.btnFind.Text = "Procurar";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtTemplate
            // 
            this.txtTemplate.Location = new System.Drawing.Point(85, 212);
            this.txtTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(397, 22);
            this.txtTemplate.TabIndex = 40;
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(5, 215);
            this.lblTemplate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(71, 17);
            this.lblTemplate.TabIndex = 39;
            this.lblTemplate.Text = "Template:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(85, 44);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(507, 22);
            this.txtEmail.TabIndex = 38;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 48);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "E-mail:";
            // 
            // btnFindCsv
            // 
            this.btnFindCsv.Location = new System.Drawing.Point(593, 250);
            this.btnFindCsv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFindCsv.Name = "btnFindCsv";
            this.btnFindCsv.Size = new System.Drawing.Size(100, 28);
            this.btnFindCsv.TabIndex = 68;
            this.btnFindCsv.Text = "Procurar";
            this.btnFindCsv.UseVisualStyleBackColor = true;
            this.btnFindCsv.Click += new System.EventHandler(this.btnFindCsv_Click);
            // 
            // txtCsvFile
            // 
            this.txtCsvFile.Location = new System.Drawing.Point(76, 252);
            this.txtCsvFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCsvFile.Name = "txtCsvFile";
            this.txtCsvFile.Size = new System.Drawing.Size(507, 22);
            this.txtCsvFile.TabIndex = 67;
            // 
            // lblCsv
            // 
            this.lblCsv.AutoSize = true;
            this.lblCsv.Location = new System.Drawing.Point(7, 258);
            this.lblCsv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCsv.Name = "lblCsv";
            this.lblCsv.Size = new System.Drawing.Size(62, 17);
            this.lblCsv.TabIndex = 66;
            this.lblCsv.Text = "Planilha:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(951, 407);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(231, 22);
            this.txtPwd.TabIndex = 70;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(888, 412);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 17);
            this.lblPwd.TabIndex = 69;
            this.lblPwd.Text = "Senha:";
            // 
            // btnLoadColumns
            // 
            this.btnLoadColumns.Location = new System.Drawing.Point(701, 252);
            this.btnLoadColumns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadColumns.Name = "btnLoadColumns";
            this.btnLoadColumns.Size = new System.Drawing.Size(100, 28);
            this.btnLoadColumns.TabIndex = 71;
            this.btnLoadColumns.Text = "Carregar Colunas";
            this.btnLoadColumns.UseVisualStyleBackColor = true;
            this.btnLoadColumns.Click += new System.EventHandler(this.btnLoadColumns_Click);
            // 
            // cbColHeader
            // 
            this.cbColHeader.FormattingEnabled = true;
            this.cbColHeader.Location = new System.Drawing.Point(71, 305);
            this.cbColHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbColHeader.Name = "cbColHeader";
            this.cbColHeader.Size = new System.Drawing.Size(216, 24);
            this.cbColHeader.TabIndex = 72;
            this.cbColHeader.SelectedIndexChanged += new System.EventHandler(this.cbColHeader_SelectedIndexChanged);
            // 
            // cbSheets
            // 
            this.cbSheets.FormattingEnabled = true;
            this.cbSheets.Location = new System.Drawing.Point(891, 252);
            this.cbSheets.Margin = new System.Windows.Forms.Padding(4);
            this.cbSheets.Name = "cbSheets";
            this.cbSheets.Size = new System.Drawing.Size(216, 24);
            this.cbSheets.TabIndex = 74;
            this.cbSheets.SelectedIndexChanged += new System.EventHandler(this.cbSheets_SelectedIndexChanged);
            // 
            // lblSheet
            // 
            this.lblSheet.AutoSize = true;
            this.lblSheet.Location = new System.Drawing.Point(825, 257);
            this.lblSheet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSheet.Name = "lblSheet";
            this.lblSheet.Size = new System.Drawing.Size(49, 17);
            this.lblSheet.TabIndex = 73;
            this.lblSheet.Text = "Sheet:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1007, 459);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 28);
            this.btnRun.TabIndex = 75;
            this.btnRun.Text = "Processar";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 555);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.cbSheets);
            this.Controls.Add(this.lblSheet);
            this.Controls.Add(this.cbColHeader);
            this.Controls.Add(this.btnLoadColumns);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.btnFindCsv);
            this.Controls.Add(this.txtCsvFile);
            this.Controls.Add(this.lblCsv);
            this.Controls.Add(this.cbConfigName);
            this.Controls.Add(this.btnNewConfig);
            this.Controls.Add(this.lblConfigName);
            this.Controls.Add(this.ckbColMail);
            this.Controls.Add(this.txtSkipLines);
            this.Controls.Add(this.lblSkipLines);
            this.Controls.Add(this.btnDelColConfig);
            this.Controls.Add(this.lbConfigs);
            this.Controls.Add(this.btnColAdd);
            this.Controls.Add(this.txtColReplace);
            this.Controls.Add(this.lblColReplace);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblColPosition);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.gbEncryption);
            this.Controls.Add(this.gbTemplateType);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtSmtp);
            this.Controls.Add(this.lblSmtp);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtTemplate);
            this.Controls.Add(this.lblTemplate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Enviar e-mails";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEncryption.ResumeLayout(false);
            this.gbEncryption.PerformLayout();
            this.gbTemplateType.ResumeLayout(false);
            this.gbTemplateType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbConfigName;
        private System.Windows.Forms.Button btnNewConfig;
        private System.Windows.Forms.Label lblConfigName;
        private System.Windows.Forms.CheckBox ckbColMail;
        private System.Windows.Forms.TextBox txtSkipLines;
        private System.Windows.Forms.Label lblSkipLines;
        private System.Windows.Forms.Button btnDelColConfig;
        private System.Windows.Forms.ListBox lbConfigs;
        private System.Windows.Forms.Button btnColAdd;
        private System.Windows.Forms.TextBox txtColReplace;
        private System.Windows.Forms.Label lblColReplace;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblColPosition;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.GroupBox gbEncryption;
        private System.Windows.Forms.RadioButton rbtNoCript;
        private System.Windows.Forms.RadioButton rbtTsl;
        private System.Windows.Forms.RadioButton rbtSsl;
        private System.Windows.Forms.GroupBox gbTemplateType;
        private System.Windows.Forms.RadioButton rbtTxt;
        private System.Windows.Forms.RadioButton rbtHtml;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.Label lblSmtp;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnFindCsv;
        private System.Windows.Forms.TextBox txtCsvFile;
        private System.Windows.Forms.Label lblCsv;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Button btnLoadColumns;
        private System.Windows.Forms.ComboBox cbColHeader;
        private System.Windows.Forms.ComboBox cbSheets;
        private System.Windows.Forms.Label lblSheet;
        private System.Windows.Forms.Button btnRun;
    }
}

