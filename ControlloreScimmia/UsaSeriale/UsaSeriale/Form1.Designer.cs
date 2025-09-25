
namespace UsaSeriale
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.labelPorta = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.btnConnetti = new System.Windows.Forms.Button();
            this.btnDisconnetti = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnScrivi = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.buttonDebug = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.buttonHideSettingsUI = new System.Windows.Forms.Button();
            this.buttonShowSettings = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelopp = new System.Windows.Forms.Label();
            this.labelNecessary = new System.Windows.Forms.Label();
            this.labelNomeUtente = new System.Windows.Forms.Label();
            this.textBoxLoginUtente = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.buttonRegistrazione = new System.Windows.Forms.Button();
            this.buttonConfermaLogin = new System.Windows.Forms.Button();
            this.textBoxFrase = new System.Windows.Forms.TextBox();
            this.panelRegistrati = new System.Windows.Forms.Panel();
            this.textBoxRegUtente = new System.Windows.Forms.TextBox();
            this.labelRegUtente = new System.Windows.Forms.Label();
            this.labelRegPassword = new System.Windows.Forms.Label();
            this.textBoxRegPassword = new System.Windows.Forms.TextBox();
            this.labelRegConfPassword = new System.Windows.Forms.Label();
            this.textBoxRegConfermaPassword = new System.Windows.Forms.TextBox();
            this.buttonBackToLogin = new System.Windows.Forms.Button();
            this.buttonConfermaReg = new System.Windows.Forms.Button();
            this.comboBoxKey = new System.Windows.Forms.ComboBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.buttonCreateNewCryptSetting = new System.Windows.Forms.Button();
            this.labelvalTransp = new System.Windows.Forms.Label();
            this.panelNewCryptoSettings = new System.Windows.Forms.Panel();
            this.buttonDiscardNewCryptoSettings = new System.Windows.Forms.Button();
            this.labelCreateNewKey = new System.Windows.Forms.Label();
            this.textBoxNewKey = new System.Windows.Forms.TextBox();
            this.buttonConfirmCryptoSettings = new System.Windows.Forms.Button();
            this.buttonSendSaveDb = new System.Windows.Forms.Button();
            this.comboBoxValTransp = new System.Windows.Forms.ComboBox();
            this.labelFrase = new System.Windows.Forms.Label();
            this.labelk = new System.Windows.Forms.Label();
            this.textBoxValK = new System.Windows.Forms.TextBox();
            this.panelSettings.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelRegistrati.SuspendLayout();
            this.panelNewCryptoSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(301, 40);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(62, 21);
            this.cmbSerialPort.TabIndex = 0;
            this.cmbSerialPort.Text = "COM3";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(497, 42);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(69, 21);
            this.cmbBaudRate.TabIndex = 1;
            // 
            // labelPorta
            // 
            this.labelPorta.AutoSize = true;
            this.labelPorta.Location = new System.Drawing.Point(298, 24);
            this.labelPorta.Name = "labelPorta";
            this.labelPorta.Size = new System.Drawing.Size(32, 13);
            this.labelPorta.TabIndex = 2;
            this.labelPorta.Text = "Porta";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(494, 24);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(55, 13);
            this.labelBaudRate.TabIndex = 3;
            this.labelBaudRate.Text = "BaudRate";
            // 
            // btnConnetti
            // 
            this.btnConnetti.Location = new System.Drawing.Point(186, 40);
            this.btnConnetti.Name = "btnConnetti";
            this.btnConnetti.Size = new System.Drawing.Size(95, 21);
            this.btnConnetti.TabIndex = 4;
            this.btnConnetti.Text = "Connetti";
            this.btnConnetti.UseVisualStyleBackColor = true;
            this.btnConnetti.Click += new System.EventHandler(this.btnConnetti_Click);
            // 
            // btnDisconnetti
            // 
            this.btnDisconnetti.Enabled = false;
            this.btnDisconnetti.Location = new System.Drawing.Point(572, 40);
            this.btnDisconnetti.Name = "btnDisconnetti";
            this.btnDisconnetti.Size = new System.Drawing.Size(122, 23);
            this.btnDisconnetti.TabIndex = 5;
            this.btnDisconnetti.Text = "Disconnetti";
            this.btnDisconnetti.UseVisualStyleBackColor = true;
            this.btnDisconnetti.Click += new System.EventHandler(this.btnDisconnetti_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 72);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(75, 20);
            this.txtInput.TabIndex = 6;
            this.txtInput.Visible = false;
            // 
            // btnScrivi
            // 
            this.btnScrivi.Location = new System.Drawing.Point(13, 38);
            this.btnScrivi.Name = "btnScrivi";
            this.btnScrivi.Size = new System.Drawing.Size(75, 20);
            this.btnScrivi.TabIndex = 7;
            this.btnScrivi.Text = "INVIA";
            this.btnScrivi.UseVisualStyleBackColor = true;
            this.btnScrivi.Visible = false;
            this.btnScrivi.Click += new System.EventHandler(this.btnScrivi_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(186, 72);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(500, 100);
            this.txtOutput.TabIndex = 8;
            // 
            // buttonDebug
            // 
            this.buttonDebug.Location = new System.Drawing.Point(12, 69);
            this.buttonDebug.Name = "buttonDebug";
            this.buttonDebug.Size = new System.Drawing.Size(100, 31);
            this.buttonDebug.TabIndex = 10;
            this.buttonDebug.Text = "DEBUG";
            this.buttonDebug.UseVisualStyleBackColor = true;
            this.buttonDebug.Visible = false;
            this.buttonDebug.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelSettings.Controls.Add(this.buttonHideSettingsUI);
            this.panelSettings.Controls.Add(this.txtOutput);
            this.panelSettings.Controls.Add(this.cmbSerialPort);
            this.panelSettings.Controls.Add(this.txtInput);
            this.panelSettings.Controls.Add(this.btnDisconnetti);
            this.panelSettings.Controls.Add(this.labelPorta);
            this.panelSettings.Controls.Add(this.btnConnetti);
            this.panelSettings.Controls.Add(this.labelBaudRate);
            this.panelSettings.Controls.Add(this.cmbBaudRate);
            this.panelSettings.Controls.Add(this.btnScrivi);
            this.panelSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSettings.Location = new System.Drawing.Point(83, 12);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(850, 237);
            this.panelSettings.TabIndex = 11;
            this.panelSettings.Visible = false;
            // 
            // buttonHideSettingsUI
            // 
            this.buttonHideSettingsUI.Location = new System.Drawing.Point(186, 184);
            this.buttonHideSettingsUI.Name = "buttonHideSettingsUI";
            this.buttonHideSettingsUI.Size = new System.Drawing.Size(500, 50);
            this.buttonHideSettingsUI.TabIndex = 11;
            this.buttonHideSettingsUI.Text = "Chiudi il menu impostazioni";
            this.buttonHideSettingsUI.UseVisualStyleBackColor = true;
            this.buttonHideSettingsUI.Click += new System.EventHandler(this.buttonHideSettingsUI_Click);
            // 
            // buttonShowSettings
            // 
            this.buttonShowSettings.Location = new System.Drawing.Point(12, 7);
            this.buttonShowSettings.Name = "buttonShowSettings";
            this.buttonShowSettings.Size = new System.Drawing.Size(131, 56);
            this.buttonShowSettings.TabIndex = 12;
            this.buttonShowSettings.Text = "Impostazioni";
            this.buttonShowSettings.UseVisualStyleBackColor = true;
            this.buttonShowSettings.Click += new System.EventHandler(this.buttonShowSettings_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.labelopp);
            this.panelLogin.Controls.Add(this.labelNecessary);
            this.panelLogin.Controls.Add(this.labelNomeUtente);
            this.panelLogin.Controls.Add(this.textBoxLoginUtente);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.textBoxLoginPassword);
            this.panelLogin.Controls.Add(this.buttonRegistrazione);
            this.panelLogin.Controls.Add(this.buttonConfermaLogin);
            this.panelLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLogin.Location = new System.Drawing.Point(8, 7);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(960, 249);
            this.panelLogin.TabIndex = 12;
            // 
            // labelopp
            // 
            this.labelopp.AutoSize = true;
            this.labelopp.Location = new System.Drawing.Point(631, 138);
            this.labelopp.Name = "labelopp";
            this.labelopp.Size = new System.Drawing.Size(42, 13);
            this.labelopp.TabIndex = 17;
            this.labelopp.Text = "Oppure";
            // 
            // labelNecessary
            // 
            this.labelNecessary.AutoSize = true;
            this.labelNecessary.Location = new System.Drawing.Point(250, 65);
            this.labelNecessary.Name = "labelNecessary";
            this.labelNecessary.Size = new System.Drawing.Size(423, 13);
            this.labelNecessary.TabIndex = 16;
            this.labelNecessary.Text = "Benvenuto! e\' necessario accedere al proprio account per utilizzare il controllor" +
    "e scimmia";
            // 
            // labelNomeUtente
            // 
            this.labelNomeUtente.AutoSize = true;
            this.labelNomeUtente.Location = new System.Drawing.Point(260, 103);
            this.labelNomeUtente.Name = "labelNomeUtente";
            this.labelNomeUtente.Size = new System.Drawing.Size(39, 13);
            this.labelNomeUtente.TabIndex = 14;
            this.labelNomeUtente.Text = "Utente";
            // 
            // textBoxLoginUtente
            // 
            this.textBoxLoginUtente.Location = new System.Drawing.Point(319, 101);
            this.textBoxLoginUtente.Name = "textBoxLoginUtente";
            this.textBoxLoginUtente.Size = new System.Drawing.Size(286, 20);
            this.textBoxLoginUtente.TabIndex = 15;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(260, 137);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password";
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Location = new System.Drawing.Point(319, 135);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(286, 20);
            this.textBoxLoginPassword.TabIndex = 13;
            // 
            // buttonRegistrazione
            // 
            this.buttonRegistrazione.Location = new System.Drawing.Point(611, 158);
            this.buttonRegistrazione.Name = "buttonRegistrazione";
            this.buttonRegistrazione.Size = new System.Drawing.Size(81, 36);
            this.buttonRegistrazione.TabIndex = 12;
            this.buttonRegistrazione.Text = "Registrati";
            this.buttonRegistrazione.UseVisualStyleBackColor = true;
            this.buttonRegistrazione.Click += new System.EventHandler(this.buttonRegistrazione_Click);
            // 
            // buttonConfermaLogin
            // 
            this.buttonConfermaLogin.Location = new System.Drawing.Point(263, 158);
            this.buttonConfermaLogin.Name = "buttonConfermaLogin";
            this.buttonConfermaLogin.Size = new System.Drawing.Size(342, 38);
            this.buttonConfermaLogin.TabIndex = 11;
            this.buttonConfermaLogin.Text = "Conferma";
            this.buttonConfermaLogin.UseVisualStyleBackColor = true;
            this.buttonConfermaLogin.Click += new System.EventHandler(this.buttonConfermaLogin_Click);
            // 
            // textBoxFrase
            // 
            this.textBoxFrase.Location = new System.Drawing.Point(239, 45);
            this.textBoxFrase.MaxLength = 255;
            this.textBoxFrase.Multiline = true;
            this.textBoxFrase.Name = "textBoxFrase";
            this.textBoxFrase.Size = new System.Drawing.Size(537, 47);
            this.textBoxFrase.TabIndex = 13;
            // 
            // panelRegistrati
            // 
            this.panelRegistrati.BackColor = System.Drawing.Color.Transparent;
            this.panelRegistrati.Controls.Add(this.textBoxRegUtente);
            this.panelRegistrati.Controls.Add(this.labelRegUtente);
            this.panelRegistrati.Controls.Add(this.labelRegPassword);
            this.panelRegistrati.Controls.Add(this.textBoxRegPassword);
            this.panelRegistrati.Controls.Add(this.labelRegConfPassword);
            this.panelRegistrati.Controls.Add(this.textBoxRegConfermaPassword);
            this.panelRegistrati.Controls.Add(this.buttonBackToLogin);
            this.panelRegistrati.Controls.Add(this.buttonConfermaReg);
            this.panelRegistrati.Enabled = false;
            this.panelRegistrati.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelRegistrati.Location = new System.Drawing.Point(8, 7);
            this.panelRegistrati.Name = "panelRegistrati";
            this.panelRegistrati.Size = new System.Drawing.Size(960, 249);
            this.panelRegistrati.TabIndex = 16;
            this.panelRegistrati.Visible = false;
            // 
            // textBoxRegUtente
            // 
            this.textBoxRegUtente.Location = new System.Drawing.Point(355, 49);
            this.textBoxRegUtente.Name = "textBoxRegUtente";
            this.textBoxRegUtente.Size = new System.Drawing.Size(286, 20);
            this.textBoxRegUtente.TabIndex = 17;
            // 
            // labelRegUtente
            // 
            this.labelRegUtente.AutoSize = true;
            this.labelRegUtente.Location = new System.Drawing.Point(248, 52);
            this.labelRegUtente.Name = "labelRegUtente";
            this.labelRegUtente.Size = new System.Drawing.Size(39, 13);
            this.labelRegUtente.TabIndex = 16;
            this.labelRegUtente.Text = "Utente";
            // 
            // labelRegPassword
            // 
            this.labelRegPassword.AutoSize = true;
            this.labelRegPassword.Location = new System.Drawing.Point(248, 95);
            this.labelRegPassword.Name = "labelRegPassword";
            this.labelRegPassword.Size = new System.Drawing.Size(53, 13);
            this.labelRegPassword.TabIndex = 14;
            this.labelRegPassword.Text = "Password";
            // 
            // textBoxRegPassword
            // 
            this.textBoxRegPassword.Location = new System.Drawing.Point(355, 88);
            this.textBoxRegPassword.Name = "textBoxRegPassword";
            this.textBoxRegPassword.Size = new System.Drawing.Size(286, 20);
            this.textBoxRegPassword.TabIndex = 15;
            // 
            // labelRegConfPassword
            // 
            this.labelRegConfPassword.AutoSize = true;
            this.labelRegConfPassword.Location = new System.Drawing.Point(248, 132);
            this.labelRegConfPassword.Name = "labelRegConfPassword";
            this.labelRegConfPassword.Size = new System.Drawing.Size(101, 13);
            this.labelRegConfPassword.TabIndex = 12;
            this.labelRegConfPassword.Text = "Conferma Password";
            // 
            // textBoxRegConfermaPassword
            // 
            this.textBoxRegConfermaPassword.Location = new System.Drawing.Point(355, 129);
            this.textBoxRegConfermaPassword.Name = "textBoxRegConfermaPassword";
            this.textBoxRegConfermaPassword.Size = new System.Drawing.Size(286, 20);
            this.textBoxRegConfermaPassword.TabIndex = 13;
            // 
            // buttonBackToLogin
            // 
            this.buttonBackToLogin.Location = new System.Drawing.Point(641, 155);
            this.buttonBackToLogin.Name = "buttonBackToLogin";
            this.buttonBackToLogin.Size = new System.Drawing.Size(90, 50);
            this.buttonBackToLogin.TabIndex = 12;
            this.buttonBackToLogin.Text = "Torna al Login";
            this.buttonBackToLogin.UseVisualStyleBackColor = true;
            this.buttonBackToLogin.Click += new System.EventHandler(this.buttonBackToLogin_Click);
            // 
            // buttonConfermaReg
            // 
            this.buttonConfermaReg.Location = new System.Drawing.Point(245, 155);
            this.buttonConfermaReg.Name = "buttonConfermaReg";
            this.buttonConfermaReg.Size = new System.Drawing.Size(390, 50);
            this.buttonConfermaReg.TabIndex = 11;
            this.buttonConfermaReg.Text = "Conferma Registrazione";
            this.buttonConfermaReg.UseVisualStyleBackColor = true;
            this.buttonConfermaReg.Click += new System.EventHandler(this.buttonConfermaReg_Click);
            // 
            // comboBoxKey
            // 
            this.comboBoxKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxKey.FormattingEnabled = true;
            this.comboBoxKey.Location = new System.Drawing.Point(734, 157);
            this.comboBoxKey.MaxDropDownItems = 100;
            this.comboBoxKey.Name = "comboBoxKey";
            this.comboBoxKey.Size = new System.Drawing.Size(80, 21);
            this.comboBoxKey.TabIndex = 12;
            this.comboBoxKey.SelectedIndexChanged += new System.EventHandler(this.comboBoxKey_SelectedIndexChanged);
            this.comboBoxKey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxValTransp_MouseClick);
            this.comboBoxKey.MouseEnter += new System.EventHandler(this.comboBoxValTransp_MouseEnter);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.BackColor = System.Drawing.Color.Transparent;
            this.labelKey.Location = new System.Drawing.Point(719, 141);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(95, 13);
            this.labelKey.TabIndex = 17;
            this.labelKey.Text = "Lunghezza Chiave";
            // 
            // buttonCreateNewCryptSetting
            // 
            this.buttonCreateNewCryptSetting.Location = new System.Drawing.Point(202, 221);
            this.buttonCreateNewCryptSetting.Name = "buttonCreateNewCryptSetting";
            this.buttonCreateNewCryptSetting.Size = new System.Drawing.Size(612, 21);
            this.buttonCreateNewCryptSetting.TabIndex = 18;
            this.buttonCreateNewCryptSetting.Text = "Crea una nuova impostazione di criptazione";
            this.buttonCreateNewCryptSetting.UseVisualStyleBackColor = true;
            this.buttonCreateNewCryptSetting.Click += new System.EventHandler(this.buttonCreateNewCryptSetting_Click);
            // 
            // labelvalTransp
            // 
            this.labelvalTransp.AutoSize = true;
            this.labelvalTransp.BackColor = System.Drawing.Color.Transparent;
            this.labelvalTransp.Location = new System.Drawing.Point(454, 141);
            this.labelvalTransp.Name = "labelvalTransp";
            this.labelvalTransp.Size = new System.Drawing.Size(112, 13);
            this.labelvalTransp.TabIndex = 20;
            this.labelvalTransp.Text = "Valori di Trasposizione";
            // 
            // panelNewCryptoSettings
            // 
            this.panelNewCryptoSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelNewCryptoSettings.Controls.Add(this.buttonDiscardNewCryptoSettings);
            this.panelNewCryptoSettings.Controls.Add(this.labelCreateNewKey);
            this.panelNewCryptoSettings.Controls.Add(this.textBoxNewKey);
            this.panelNewCryptoSettings.Controls.Add(this.buttonConfirmCryptoSettings);
            this.panelNewCryptoSettings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelNewCryptoSettings.Location = new System.Drawing.Point(202, 29);
            this.panelNewCryptoSettings.Name = "panelNewCryptoSettings";
            this.panelNewCryptoSettings.Size = new System.Drawing.Size(612, 213);
            this.panelNewCryptoSettings.TabIndex = 16;
            this.panelNewCryptoSettings.Visible = false;
            // 
            // buttonDiscardNewCryptoSettings
            // 
            this.buttonDiscardNewCryptoSettings.Location = new System.Drawing.Point(121, 130);
            this.buttonDiscardNewCryptoSettings.Name = "buttonDiscardNewCryptoSettings";
            this.buttonDiscardNewCryptoSettings.Size = new System.Drawing.Size(366, 26);
            this.buttonDiscardNewCryptoSettings.TabIndex = 18;
            this.buttonDiscardNewCryptoSettings.Text = "Esci";
            this.buttonDiscardNewCryptoSettings.UseVisualStyleBackColor = true;
            this.buttonDiscardNewCryptoSettings.Click += new System.EventHandler(this.buttonDiscardNewCryptoSettings_Click);
            // 
            // labelCreateNewKey
            // 
            this.labelCreateNewKey.AutoSize = true;
            this.labelCreateNewKey.Location = new System.Drawing.Point(263, 52);
            this.labelCreateNewKey.Name = "labelCreateNewKey";
            this.labelCreateNewKey.Size = new System.Drawing.Size(74, 13);
            this.labelCreateNewKey.TabIndex = 14;
            this.labelCreateNewKey.Text = "Nuova chiave";
            // 
            // textBoxNewKey
            // 
            this.textBoxNewKey.Location = new System.Drawing.Point(121, 68);
            this.textBoxNewKey.Name = "textBoxNewKey";
            this.textBoxNewKey.Size = new System.Drawing.Size(366, 20);
            this.textBoxNewKey.TabIndex = 15;
            // 
            // buttonConfirmCryptoSettings
            // 
            this.buttonConfirmCryptoSettings.Location = new System.Drawing.Point(121, 93);
            this.buttonConfirmCryptoSettings.Name = "buttonConfirmCryptoSettings";
            this.buttonConfirmCryptoSettings.Size = new System.Drawing.Size(366, 31);
            this.buttonConfirmCryptoSettings.TabIndex = 11;
            this.buttonConfirmCryptoSettings.Text = "Conferma";
            this.buttonConfirmCryptoSettings.UseVisualStyleBackColor = true;
            this.buttonConfirmCryptoSettings.Click += new System.EventHandler(this.buttonConfirmCryptoSettings_Click);
            // 
            // buttonSendSaveDb
            // 
            this.buttonSendSaveDb.Location = new System.Drawing.Point(239, 98);
            this.buttonSendSaveDb.Name = "buttonSendSaveDb";
            this.buttonSendSaveDb.Size = new System.Drawing.Size(537, 31);
            this.buttonSendSaveDb.TabIndex = 21;
            this.buttonSendSaveDb.Text = "Conferma frase";
            this.buttonSendSaveDb.UseVisualStyleBackColor = true;
            this.buttonSendSaveDb.Click += new System.EventHandler(this.buttonSendSaveDb_Click);
            // 
            // comboBoxValTransp
            // 
            this.comboBoxValTransp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValTransp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxValTransp.FormattingEnabled = true;
            this.comboBoxValTransp.Location = new System.Drawing.Point(202, 157);
            this.comboBoxValTransp.MaxDropDownItems = 100;
            this.comboBoxValTransp.Name = "comboBoxValTransp";
            this.comboBoxValTransp.Size = new System.Drawing.Size(526, 21);
            this.comboBoxValTransp.TabIndex = 22;
            this.comboBoxValTransp.SelectedIndexChanged += new System.EventHandler(this.comboBoxValTransp_SelectedIndexChanged);
            this.comboBoxValTransp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxValTransp_MouseClick);
            this.comboBoxValTransp.MouseEnter += new System.EventHandler(this.comboBoxValTransp_MouseEnter);
            // 
            // labelFrase
            // 
            this.labelFrase.AutoSize = true;
            this.labelFrase.BackColor = System.Drawing.Color.Transparent;
            this.labelFrase.Location = new System.Drawing.Point(437, 29);
            this.labelFrase.Name = "labelFrase";
            this.labelFrase.Size = new System.Drawing.Size(144, 13);
            this.labelFrase.TabIndex = 23;
            this.labelFrase.Text = "Inserire una frase da criptare ";
            // 
            // labelk
            // 
            this.labelk.AutoSize = true;
            this.labelk.BackColor = System.Drawing.Color.White;
            this.labelk.Location = new System.Drawing.Point(489, 181);
            this.labelk.Name = "labelk";
            this.labelk.Size = new System.Drawing.Size(40, 13);
            this.labelk.TabIndex = 25;
            this.labelk.Text = "Chiave";
            // 
            // textBoxValK
            // 
            this.textBoxValK.Location = new System.Drawing.Point(202, 197);
            this.textBoxValK.Name = "textBoxValK";
            this.textBoxValK.ReadOnly = true;
            this.textBoxValK.Size = new System.Drawing.Size(612, 20);
            this.textBoxValK.TabIndex = 26;
            this.textBoxValK.MouseEnter += new System.EventHandler(this.textBoxValK_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UsaSeriale.Properties.Resources.monke;
            this.ClientSize = new System.Drawing.Size(984, 261);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelRegistrati);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelNewCryptoSettings);
            this.Controls.Add(this.textBoxValK);
            this.Controls.Add(this.labelk);
            this.Controls.Add(this.labelFrase);
            this.Controls.Add(this.comboBoxValTransp);
            this.Controls.Add(this.buttonSendSaveDb);
            this.Controls.Add(this.labelvalTransp);
            this.Controls.Add(this.buttonCreateNewCryptSetting);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.comboBoxKey);
            this.Controls.Add(this.textBoxFrase);
            this.Controls.Add(this.buttonDebug);
            this.Controls.Add(this.buttonShowSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controllore Scimmia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegistrati.ResumeLayout(false);
            this.panelRegistrati.PerformLayout();
            this.panelNewCryptoSettings.ResumeLayout(false);
            this.panelNewCryptoSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label labelPorta;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Button btnConnetti;
        private System.Windows.Forms.Button btnDisconnetti;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnScrivi;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button buttonDebug;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button buttonHideSettingsUI;
        private System.Windows.Forms.Button buttonShowSettings;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Button buttonRegistrazione;
        private System.Windows.Forms.Button buttonConfermaLogin;
        private System.Windows.Forms.Label labelNomeUtente;
        private System.Windows.Forms.TextBox textBoxLoginUtente;
        private System.Windows.Forms.TextBox textBoxFrase;
        private System.Windows.Forms.Panel panelRegistrati;
        private System.Windows.Forms.Label labelRegUtente;
        private System.Windows.Forms.Label labelRegPassword;
        private System.Windows.Forms.TextBox textBoxRegPassword;
        private System.Windows.Forms.Label labelRegConfPassword;
        private System.Windows.Forms.TextBox textBoxRegConfermaPassword;
        private System.Windows.Forms.Button buttonBackToLogin;
        private System.Windows.Forms.Button buttonConfermaReg;
        private System.Windows.Forms.ComboBox comboBoxKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Button buttonCreateNewCryptSetting;
        private System.Windows.Forms.Label labelvalTransp;
        private System.Windows.Forms.Panel panelNewCryptoSettings;
        private System.Windows.Forms.Label labelCreateNewKey;
        private System.Windows.Forms.TextBox textBoxNewKey;
        private System.Windows.Forms.Button buttonConfirmCryptoSettings;
        private System.Windows.Forms.Button buttonSendSaveDb;
        private System.Windows.Forms.Button buttonDiscardNewCryptoSettings;
        private System.Windows.Forms.ComboBox comboBoxValTransp;
        private System.Windows.Forms.Label labelFrase;
        private System.Windows.Forms.Label labelNecessary;
        private System.Windows.Forms.Label labelopp;
        private System.Windows.Forms.Label labelk;
        private System.Windows.Forms.TextBox textBoxValK;
        private System.Windows.Forms.TextBox textBoxRegUtente;
    }
}

