namespace MW3_Server_Maker
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.chkLoader = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtHostName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSecureGamePort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMasterPort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtOpenGamePort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtAuthPort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPrivateClients = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtMaxClients = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtPrivatePassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cbServerVisibility = new MetroFramework.Controls.MetroComboBox();
            this.txtRconPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtServerPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtVoiceChat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtToggleVoting = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtDeadChat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtInactivity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txtKickTime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.btnClearScript = new MetroFramework.Controls.MetroButton();
            this.btnAddScript = new MetroFramework.Controls.MetroButton();
            this.txtScript = new MetroFramework.Controls.MetroTextBox();
            this.chkCammand = new MetroFramework.Controls.MetroCheckBox();
            this.btnCleaerCommand = new MetroFramework.Controls.MetroButton();
            this.btnAddCommand = new MetroFramework.Controls.MetroButton();
            this.txtCommand = new MetroFramework.Controls.MetroTextBox();
            this.listScripts = new System.Windows.Forms.ListBox();
            this.listCommands = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chkLoader
            // 
            this.chkLoader.AutoSize = true;
            this.chkLoader.Location = new System.Drawing.Point(31, 305);
            this.chkLoader.Margin = new System.Windows.Forms.Padding(4);
            this.chkLoader.Name = "chkLoader";
            this.chkLoader.Size = new System.Drawing.Size(63, 17);
            this.chkLoader.Style = MetroFramework.MetroColorStyle.Lime;
            this.chkLoader.TabIndex = 0;
            this.chkLoader.Text = "Scripts";
            this.chkLoader.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkLoader.UseSelectable = true;
            this.chkLoader.CheckedChanged += new System.EventHandler(this.chk_loader1_CheckedChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(31, 574);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(816, 43);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Save";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtHostName
            // 
            // 
            // 
            // 
            this.txtHostName.CustomButton.Image = null;
            this.txtHostName.CustomButton.Location = new System.Drawing.Point(626, 2);
            this.txtHostName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtHostName.CustomButton.Name = "";
            this.txtHostName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtHostName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHostName.CustomButton.TabIndex = 1;
            this.txtHostName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHostName.CustomButton.UseSelectable = true;
            this.txtHostName.CustomButton.Visible = false;
            this.txtHostName.Lines = new string[0];
            this.txtHostName.Location = new System.Drawing.Point(195, 71);
            this.txtHostName.Margin = new System.Windows.Forms.Padding(4);
            this.txtHostName.MaxLength = 32767;
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.PasswordChar = '\0';
            this.txtHostName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHostName.SelectedText = "";
            this.txtHostName.SelectionLength = 0;
            this.txtHostName.SelectionStart = 0;
            this.txtHostName.ShortcutsEnabled = true;
            this.txtHostName.Size = new System.Drawing.Size(652, 28);
            this.txtHostName.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtHostName.TabIndex = 5;
            this.txtHostName.UseSelectable = true;
            this.txtHostName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHostName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 74);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Server Name :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtSecureGamePort
            // 
            // 
            // 
            // 
            this.txtSecureGamePort.CustomButton.Image = null;
            this.txtSecureGamePort.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtSecureGamePort.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecureGamePort.CustomButton.Name = "";
            this.txtSecureGamePort.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSecureGamePort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSecureGamePort.CustomButton.TabIndex = 1;
            this.txtSecureGamePort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSecureGamePort.CustomButton.UseSelectable = true;
            this.txtSecureGamePort.CustomButton.Visible = false;
            this.txtSecureGamePort.Lines = new string[0];
            this.txtSecureGamePort.Location = new System.Drawing.Point(475, 249);
            this.txtSecureGamePort.Margin = new System.Windows.Forms.Padding(4);
            this.txtSecureGamePort.MaxLength = 32767;
            this.txtSecureGamePort.Name = "txtSecureGamePort";
            this.txtSecureGamePort.PasswordChar = '\0';
            this.txtSecureGamePort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSecureGamePort.SelectedText = "";
            this.txtSecureGamePort.SelectionLength = 0;
            this.txtSecureGamePort.SelectionStart = 0;
            this.txtSecureGamePort.ShortcutsEnabled = true;
            this.txtSecureGamePort.Size = new System.Drawing.Size(100, 28);
            this.txtSecureGamePort.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtSecureGamePort.TabIndex = 5;
            this.txtSecureGamePort.UseSelectable = true;
            this.txtSecureGamePort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSecureGamePort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSecureGamePort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(303, 252);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(129, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Secure Game Port :";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtMasterPort
            // 
            // 
            // 
            // 
            this.txtMasterPort.CustomButton.Image = null;
            this.txtMasterPort.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtMasterPort.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasterPort.CustomButton.Name = "";
            this.txtMasterPort.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMasterPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMasterPort.CustomButton.TabIndex = 1;
            this.txtMasterPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMasterPort.CustomButton.UseSelectable = true;
            this.txtMasterPort.CustomButton.Visible = false;
            this.txtMasterPort.Lines = new string[0];
            this.txtMasterPort.Location = new System.Drawing.Point(747, 249);
            this.txtMasterPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasterPort.MaxLength = 32767;
            this.txtMasterPort.Name = "txtMasterPort";
            this.txtMasterPort.PasswordChar = '\0';
            this.txtMasterPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMasterPort.SelectedText = "";
            this.txtMasterPort.SelectionLength = 0;
            this.txtMasterPort.SelectionStart = 0;
            this.txtMasterPort.ShortcutsEnabled = true;
            this.txtMasterPort.Size = new System.Drawing.Size(100, 28);
            this.txtMasterPort.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtMasterPort.TabIndex = 5;
            this.txtMasterPort.UseSelectable = true;
            this.txtMasterPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMasterPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMasterPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(583, 252);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(87, 20);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Master Port :";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtOpenGamePort
            // 
            // 
            // 
            // 
            this.txtOpenGamePort.CustomButton.Image = null;
            this.txtOpenGamePort.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtOpenGamePort.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpenGamePort.CustomButton.Name = "";
            this.txtOpenGamePort.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtOpenGamePort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOpenGamePort.CustomButton.TabIndex = 1;
            this.txtOpenGamePort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOpenGamePort.CustomButton.UseSelectable = true;
            this.txtOpenGamePort.CustomButton.Visible = false;
            this.txtOpenGamePort.Lines = new string[0];
            this.txtOpenGamePort.Location = new System.Drawing.Point(195, 106);
            this.txtOpenGamePort.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpenGamePort.MaxLength = 32767;
            this.txtOpenGamePort.Name = "txtOpenGamePort";
            this.txtOpenGamePort.PasswordChar = '\0';
            this.txtOpenGamePort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOpenGamePort.SelectedText = "";
            this.txtOpenGamePort.SelectionLength = 0;
            this.txtOpenGamePort.SelectionStart = 0;
            this.txtOpenGamePort.ShortcutsEnabled = true;
            this.txtOpenGamePort.Size = new System.Drawing.Size(100, 28);
            this.txtOpenGamePort.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtOpenGamePort.TabIndex = 5;
            this.txtOpenGamePort.UseSelectable = true;
            this.txtOpenGamePort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOpenGamePort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOpenGamePort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(31, 108);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(121, 20);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Open Game Port :";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAuthPort
            // 
            // 
            // 
            // 
            this.txtAuthPort.CustomButton.Image = null;
            this.txtAuthPort.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtAuthPort.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthPort.CustomButton.Name = "";
            this.txtAuthPort.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAuthPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAuthPort.CustomButton.TabIndex = 1;
            this.txtAuthPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAuthPort.CustomButton.UseSelectable = true;
            this.txtAuthPort.CustomButton.Visible = false;
            this.txtAuthPort.Lines = new string[0];
            this.txtAuthPort.Location = new System.Drawing.Point(475, 106);
            this.txtAuthPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthPort.MaxLength = 32767;
            this.txtAuthPort.Name = "txtAuthPort";
            this.txtAuthPort.PasswordChar = '\0';
            this.txtAuthPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuthPort.SelectedText = "";
            this.txtAuthPort.SelectionLength = 0;
            this.txtAuthPort.SelectionStart = 0;
            this.txtAuthPort.ShortcutsEnabled = true;
            this.txtAuthPort.Size = new System.Drawing.Size(100, 28);
            this.txtAuthPort.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtAuthPort.TabIndex = 5;
            this.txtAuthPort.UseSelectable = true;
            this.txtAuthPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAuthPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAuthPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(303, 108);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(74, 20);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Auth Port :";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPrivateClients
            // 
            // 
            // 
            // 
            this.txtPrivateClients.CustomButton.Image = null;
            this.txtPrivateClients.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtPrivateClients.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivateClients.CustomButton.Name = "";
            this.txtPrivateClients.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPrivateClients.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrivateClients.CustomButton.TabIndex = 1;
            this.txtPrivateClients.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrivateClients.CustomButton.UseSelectable = true;
            this.txtPrivateClients.CustomButton.Visible = false;
            this.txtPrivateClients.Lines = new string[0];
            this.txtPrivateClients.Location = new System.Drawing.Point(747, 106);
            this.txtPrivateClients.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivateClients.MaxLength = 32767;
            this.txtPrivateClients.Name = "txtPrivateClients";
            this.txtPrivateClients.PasswordChar = '\0';
            this.txtPrivateClients.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrivateClients.SelectedText = "";
            this.txtPrivateClients.SelectionLength = 0;
            this.txtPrivateClients.SelectionStart = 0;
            this.txtPrivateClients.ShortcutsEnabled = true;
            this.txtPrivateClients.Size = new System.Drawing.Size(100, 28);
            this.txtPrivateClients.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPrivateClients.TabIndex = 5;
            this.txtPrivateClients.UseSelectable = true;
            this.txtPrivateClients.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrivateClients.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrivateClients.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(583, 108);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(103, 20);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Private Clients :";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtMaxClients
            // 
            // 
            // 
            // 
            this.txtMaxClients.CustomButton.Image = null;
            this.txtMaxClients.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtMaxClients.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxClients.CustomButton.Name = "";
            this.txtMaxClients.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMaxClients.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaxClients.CustomButton.TabIndex = 1;
            this.txtMaxClients.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaxClients.CustomButton.UseSelectable = true;
            this.txtMaxClients.CustomButton.Visible = false;
            this.txtMaxClients.Lines = new string[0];
            this.txtMaxClients.Location = new System.Drawing.Point(195, 142);
            this.txtMaxClients.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxClients.MaxLength = 32767;
            this.txtMaxClients.Name = "txtMaxClients";
            this.txtMaxClients.PasswordChar = '\0';
            this.txtMaxClients.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaxClients.SelectedText = "";
            this.txtMaxClients.SelectionLength = 0;
            this.txtMaxClients.SelectionStart = 0;
            this.txtMaxClients.ShortcutsEnabled = true;
            this.txtMaxClients.Size = new System.Drawing.Size(100, 28);
            this.txtMaxClients.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtMaxClients.TabIndex = 5;
            this.txtMaxClients.UseSelectable = true;
            this.txtMaxClients.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaxClients.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMaxClients.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(31, 144);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 20);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Max Clients :";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(28, 256);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(110, 20);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel8.TabIndex = 6;
            this.metroLabel8.Text = "Server Visibility :";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPrivatePassword
            // 
            // 
            // 
            // 
            this.txtPrivatePassword.CustomButton.Image = null;
            this.txtPrivatePassword.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtPrivatePassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivatePassword.CustomButton.Name = "";
            this.txtPrivatePassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPrivatePassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrivatePassword.CustomButton.TabIndex = 1;
            this.txtPrivatePassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrivatePassword.CustomButton.UseSelectable = true;
            this.txtPrivatePassword.CustomButton.Visible = false;
            this.txtPrivatePassword.Lines = new string[0];
            this.txtPrivatePassword.Location = new System.Drawing.Point(475, 142);
            this.txtPrivatePassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivatePassword.MaxLength = 32767;
            this.txtPrivatePassword.Name = "txtPrivatePassword";
            this.txtPrivatePassword.PasswordChar = '\0';
            this.txtPrivatePassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrivatePassword.SelectedText = "";
            this.txtPrivatePassword.SelectionLength = 0;
            this.txtPrivatePassword.SelectionStart = 0;
            this.txtPrivatePassword.ShortcutsEnabled = true;
            this.txtPrivatePassword.Size = new System.Drawing.Size(100, 28);
            this.txtPrivatePassword.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPrivatePassword.TabIndex = 5;
            this.txtPrivatePassword.UseSelectable = true;
            this.txtPrivatePassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrivatePassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(303, 144);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(119, 20);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 6;
            this.metroLabel9.Text = "Private Password :";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbServerVisibility
            // 
            this.cbServerVisibility.FormattingEnabled = true;
            this.cbServerVisibility.ItemHeight = 24;
            this.cbServerVisibility.Items.AddRange(new object[] {
            "Lan",
            "Internet"});
            this.cbServerVisibility.Location = new System.Drawing.Point(195, 249);
            this.cbServerVisibility.Margin = new System.Windows.Forms.Padding(4);
            this.cbServerVisibility.Name = "cbServerVisibility";
            this.cbServerVisibility.Size = new System.Drawing.Size(99, 30);
            this.cbServerVisibility.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbServerVisibility.TabIndex = 7;
            this.cbServerVisibility.UseSelectable = true;
            this.cbServerVisibility.SelectedIndexChanged += new System.EventHandler(this.txt_sv_SelectedIndexChanged);
            // 
            // txtRconPassword
            // 
            // 
            // 
            // 
            this.txtRconPassword.CustomButton.Image = null;
            this.txtRconPassword.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtRconPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtRconPassword.CustomButton.Name = "";
            this.txtRconPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRconPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRconPassword.CustomButton.TabIndex = 1;
            this.txtRconPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRconPassword.CustomButton.UseSelectable = true;
            this.txtRconPassword.CustomButton.Visible = false;
            this.txtRconPassword.Lines = new string[0];
            this.txtRconPassword.Location = new System.Drawing.Point(747, 142);
            this.txtRconPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtRconPassword.MaxLength = 32767;
            this.txtRconPassword.Name = "txtRconPassword";
            this.txtRconPassword.PasswordChar = '\0';
            this.txtRconPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRconPassword.SelectedText = "";
            this.txtRconPassword.SelectionLength = 0;
            this.txtRconPassword.SelectionStart = 0;
            this.txtRconPassword.ShortcutsEnabled = true;
            this.txtRconPassword.Size = new System.Drawing.Size(100, 28);
            this.txtRconPassword.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtRconPassword.TabIndex = 5;
            this.txtRconPassword.UseSelectable = true;
            this.txtRconPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRconPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(583, 144);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(116, 20);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel10.TabIndex = 6;
            this.metroLabel10.Text = "RCON Password :";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtServerPassword
            // 
            // 
            // 
            // 
            this.txtServerPassword.CustomButton.Image = null;
            this.txtServerPassword.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtServerPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerPassword.CustomButton.Name = "";
            this.txtServerPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtServerPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServerPassword.CustomButton.TabIndex = 1;
            this.txtServerPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServerPassword.CustomButton.UseSelectable = true;
            this.txtServerPassword.CustomButton.Visible = false;
            this.txtServerPassword.Lines = new string[0];
            this.txtServerPassword.Location = new System.Drawing.Point(195, 177);
            this.txtServerPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerPassword.MaxLength = 32767;
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.PasswordChar = '\0';
            this.txtServerPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerPassword.SelectedText = "";
            this.txtServerPassword.SelectionLength = 0;
            this.txtServerPassword.SelectionStart = 0;
            this.txtServerPassword.ShortcutsEnabled = true;
            this.txtServerPassword.Size = new System.Drawing.Size(100, 28);
            this.txtServerPassword.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtServerPassword.TabIndex = 5;
            this.txtServerPassword.UseSelectable = true;
            this.txtServerPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServerPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(31, 180);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(118, 20);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel11.TabIndex = 6;
            this.metroLabel11.Text = "Server Password :";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtVoiceChat
            // 
            // 
            // 
            // 
            this.txtVoiceChat.CustomButton.Image = null;
            this.txtVoiceChat.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtVoiceChat.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoiceChat.CustomButton.Name = "";
            this.txtVoiceChat.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtVoiceChat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVoiceChat.CustomButton.TabIndex = 1;
            this.txtVoiceChat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVoiceChat.CustomButton.UseSelectable = true;
            this.txtVoiceChat.CustomButton.Visible = false;
            this.txtVoiceChat.Lines = new string[0];
            this.txtVoiceChat.Location = new System.Drawing.Point(475, 177);
            this.txtVoiceChat.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoiceChat.MaxLength = 32767;
            this.txtVoiceChat.Name = "txtVoiceChat";
            this.txtVoiceChat.PasswordChar = '\0';
            this.txtVoiceChat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVoiceChat.SelectedText = "";
            this.txtVoiceChat.SelectionLength = 0;
            this.txtVoiceChat.SelectionStart = 0;
            this.txtVoiceChat.ShortcutsEnabled = true;
            this.txtVoiceChat.Size = new System.Drawing.Size(100, 28);
            this.txtVoiceChat.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtVoiceChat.TabIndex = 5;
            this.txtVoiceChat.UseSelectable = true;
            this.txtVoiceChat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVoiceChat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtVoiceChat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(305, 180);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(82, 20);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel12.TabIndex = 6;
            this.metroLabel12.Text = "Voice Chat :";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtToggleVoting
            // 
            // 
            // 
            // 
            this.txtToggleVoting.CustomButton.Image = null;
            this.txtToggleVoting.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtToggleVoting.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtToggleVoting.CustomButton.Name = "";
            this.txtToggleVoting.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtToggleVoting.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtToggleVoting.CustomButton.TabIndex = 1;
            this.txtToggleVoting.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtToggleVoting.CustomButton.UseSelectable = true;
            this.txtToggleVoting.CustomButton.Visible = false;
            this.txtToggleVoting.Lines = new string[0];
            this.txtToggleVoting.Location = new System.Drawing.Point(747, 177);
            this.txtToggleVoting.Margin = new System.Windows.Forms.Padding(4);
            this.txtToggleVoting.MaxLength = 32767;
            this.txtToggleVoting.Name = "txtToggleVoting";
            this.txtToggleVoting.PasswordChar = '\0';
            this.txtToggleVoting.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtToggleVoting.SelectedText = "";
            this.txtToggleVoting.SelectionLength = 0;
            this.txtToggleVoting.SelectionStart = 0;
            this.txtToggleVoting.ShortcutsEnabled = true;
            this.txtToggleVoting.Size = new System.Drawing.Size(100, 28);
            this.txtToggleVoting.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtToggleVoting.TabIndex = 5;
            this.txtToggleVoting.UseSelectable = true;
            this.txtToggleVoting.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtToggleVoting.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtToggleVoting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(583, 180);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(100, 20);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel13.TabIndex = 6;
            this.metroLabel13.Text = "Toggle Voting :";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDeadChat
            // 
            // 
            // 
            // 
            this.txtDeadChat.CustomButton.Image = null;
            this.txtDeadChat.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtDeadChat.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeadChat.CustomButton.Name = "";
            this.txtDeadChat.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDeadChat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDeadChat.CustomButton.TabIndex = 1;
            this.txtDeadChat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDeadChat.CustomButton.UseSelectable = true;
            this.txtDeadChat.CustomButton.Visible = false;
            this.txtDeadChat.Lines = new string[0];
            this.txtDeadChat.Location = new System.Drawing.Point(195, 213);
            this.txtDeadChat.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeadChat.MaxLength = 32767;
            this.txtDeadChat.Name = "txtDeadChat";
            this.txtDeadChat.PasswordChar = '\0';
            this.txtDeadChat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDeadChat.SelectedText = "";
            this.txtDeadChat.SelectionLength = 0;
            this.txtDeadChat.SelectionStart = 0;
            this.txtDeadChat.ShortcutsEnabled = true;
            this.txtDeadChat.Size = new System.Drawing.Size(100, 28);
            this.txtDeadChat.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtDeadChat.TabIndex = 5;
            this.txtDeadChat.UseSelectable = true;
            this.txtDeadChat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDeadChat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeadChat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(31, 215);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(81, 20);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel14.TabIndex = 6;
            this.metroLabel14.Text = "Dead Chat :";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtInactivity
            // 
            // 
            // 
            // 
            this.txtInactivity.CustomButton.Image = null;
            this.txtInactivity.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtInactivity.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtInactivity.CustomButton.Name = "";
            this.txtInactivity.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtInactivity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInactivity.CustomButton.TabIndex = 1;
            this.txtInactivity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInactivity.CustomButton.UseSelectable = true;
            this.txtInactivity.CustomButton.Visible = false;
            this.txtInactivity.Lines = new string[0];
            this.txtInactivity.Location = new System.Drawing.Point(475, 213);
            this.txtInactivity.Margin = new System.Windows.Forms.Padding(4);
            this.txtInactivity.MaxLength = 32767;
            this.txtInactivity.Name = "txtInactivity";
            this.txtInactivity.PasswordChar = '\0';
            this.txtInactivity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInactivity.SelectedText = "";
            this.txtInactivity.SelectionLength = 0;
            this.txtInactivity.SelectionStart = 0;
            this.txtInactivity.ShortcutsEnabled = true;
            this.txtInactivity.Size = new System.Drawing.Size(100, 28);
            this.txtInactivity.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtInactivity.TabIndex = 5;
            this.txtInactivity.UseSelectable = true;
            this.txtInactivity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInactivity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInactivity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(305, 215);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(69, 20);
            this.metroLabel15.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel15.TabIndex = 6;
            this.metroLabel15.Text = "Inactivity :";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtKickTime
            // 
            // 
            // 
            // 
            this.txtKickTime.CustomButton.Image = null;
            this.txtKickTime.CustomButton.Location = new System.Drawing.Point(74, 2);
            this.txtKickTime.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtKickTime.CustomButton.Name = "";
            this.txtKickTime.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtKickTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKickTime.CustomButton.TabIndex = 1;
            this.txtKickTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKickTime.CustomButton.UseSelectable = true;
            this.txtKickTime.CustomButton.Visible = false;
            this.txtKickTime.Lines = new string[0];
            this.txtKickTime.Location = new System.Drawing.Point(747, 213);
            this.txtKickTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtKickTime.MaxLength = 32767;
            this.txtKickTime.Name = "txtKickTime";
            this.txtKickTime.PasswordChar = '\0';
            this.txtKickTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKickTime.SelectedText = "";
            this.txtKickTime.SelectionLength = 0;
            this.txtKickTime.SelectionStart = 0;
            this.txtKickTime.ShortcutsEnabled = true;
            this.txtKickTime.Size = new System.Drawing.Size(100, 28);
            this.txtKickTime.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtKickTime.TabIndex = 5;
            this.txtKickTime.UseSelectable = true;
            this.txtKickTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKickTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKickTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(583, 215);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(76, 20);
            this.metroLabel16.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel16.TabIndex = 6;
            this.metroLabel16.Text = "Kick Time :";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnClearScript
            // 
            this.btnClearScript.Enabled = false;
            this.btnClearScript.Location = new System.Drawing.Point(181, 508);
            this.btnClearScript.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearScript.Name = "btnClearScript";
            this.btnClearScript.Size = new System.Drawing.Size(143, 43);
            this.btnClearScript.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnClearScript.TabIndex = 4;
            this.btnClearScript.Text = "Clear";
            this.btnClearScript.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClearScript.UseSelectable = true;
            this.btnClearScript.Click += new System.EventHandler(this.btnClearScript_Click);
            // 
            // btnAddScript
            // 
            this.btnAddScript.Enabled = false;
            this.btnAddScript.Location = new System.Drawing.Point(31, 508);
            this.btnAddScript.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddScript.Name = "btnAddScript";
            this.btnAddScript.Size = new System.Drawing.Size(143, 43);
            this.btnAddScript.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnAddScript.TabIndex = 4;
            this.btnAddScript.Text = "Add";
            this.btnAddScript.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddScript.UseSelectable = true;
            this.btnAddScript.Click += new System.EventHandler(this.btnAddScript_Click);
            // 
            // txtScript
            // 
            // 
            // 
            // 
            this.txtScript.CustomButton.Image = null;
            this.txtScript.CustomButton.Location = new System.Drawing.Point(375, 2);
            this.txtScript.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtScript.CustomButton.Name = "";
            this.txtScript.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtScript.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtScript.CustomButton.TabIndex = 1;
            this.txtScript.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtScript.CustomButton.UseSelectable = true;
            this.txtScript.CustomButton.Visible = false;
            this.txtScript.Enabled = false;
            this.txtScript.Lines = new string[0];
            this.txtScript.Location = new System.Drawing.Point(31, 331);
            this.txtScript.Margin = new System.Windows.Forms.Padding(4);
            this.txtScript.MaxLength = 32767;
            this.txtScript.Name = "txtScript";
            this.txtScript.PasswordChar = '\0';
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtScript.SelectedText = "";
            this.txtScript.SelectionLength = 0;
            this.txtScript.SelectionStart = 0;
            this.txtScript.ShortcutsEnabled = true;
            this.txtScript.Size = new System.Drawing.Size(401, 28);
            this.txtScript.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtScript.TabIndex = 11;
            this.txtScript.UseSelectable = true;
            this.txtScript.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtScript.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkCammand
            // 
            this.chkCammand.AutoSize = true;
            this.chkCammand.Location = new System.Drawing.Point(440, 305);
            this.chkCammand.Margin = new System.Windows.Forms.Padding(4);
            this.chkCammand.Name = "chkCammand";
            this.chkCammand.Size = new System.Drawing.Size(90, 17);
            this.chkCammand.Style = MetroFramework.MetroColorStyle.Lime;
            this.chkCammand.TabIndex = 0;
            this.chkCammand.Text = "Commands";
            this.chkCammand.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkCammand.UseSelectable = true;
            this.chkCammand.CheckedChanged += new System.EventHandler(this.chkCammand_CheckedChanged);
            // 
            // btnCleaerCommand
            // 
            this.btnCleaerCommand.Enabled = false;
            this.btnCleaerCommand.Location = new System.Drawing.Point(591, 508);
            this.btnCleaerCommand.Margin = new System.Windows.Forms.Padding(4);
            this.btnCleaerCommand.Name = "btnCleaerCommand";
            this.btnCleaerCommand.Size = new System.Drawing.Size(143, 43);
            this.btnCleaerCommand.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnCleaerCommand.TabIndex = 4;
            this.btnCleaerCommand.Text = "Clear";
            this.btnCleaerCommand.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCleaerCommand.UseSelectable = true;
            this.btnCleaerCommand.Click += new System.EventHandler(this.btnCleaerCommand_Click);
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Enabled = false;
            this.btnAddCommand.Location = new System.Drawing.Point(440, 508);
            this.btnAddCommand.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(143, 43);
            this.btnAddCommand.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnAddCommand.TabIndex = 4;
            this.btnAddCommand.Text = "Add";
            this.btnAddCommand.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAddCommand.UseSelectable = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // txtCommand
            // 
            // 
            // 
            // 
            this.txtCommand.CustomButton.Image = null;
            this.txtCommand.CustomButton.Location = new System.Drawing.Point(381, 2);
            this.txtCommand.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommand.CustomButton.Name = "";
            this.txtCommand.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCommand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCommand.CustomButton.TabIndex = 1;
            this.txtCommand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCommand.CustomButton.UseSelectable = true;
            this.txtCommand.CustomButton.Visible = false;
            this.txtCommand.Enabled = false;
            this.txtCommand.Lines = new string[0];
            this.txtCommand.Location = new System.Drawing.Point(440, 331);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommand.MaxLength = 32767;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.PasswordChar = '\0';
            this.txtCommand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCommand.SelectedText = "";
            this.txtCommand.SelectionLength = 0;
            this.txtCommand.SelectionStart = 0;
            this.txtCommand.ShortcutsEnabled = true;
            this.txtCommand.Size = new System.Drawing.Size(407, 28);
            this.txtCommand.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtCommand.TabIndex = 11;
            this.txtCommand.UseSelectable = true;
            this.txtCommand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCommand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listScripts
            // 
            this.listScripts.Enabled = false;
            this.listScripts.FormattingEnabled = true;
            this.listScripts.ItemHeight = 16;
            this.listScripts.Location = new System.Drawing.Point(31, 367);
            this.listScripts.Margin = new System.Windows.Forms.Padding(4);
            this.listScripts.Name = "listScripts";
            this.listScripts.Size = new System.Drawing.Size(400, 132);
            this.listScripts.TabIndex = 12;
            // 
            // listCommands
            // 
            this.listCommands.Enabled = false;
            this.listCommands.FormattingEnabled = true;
            this.listCommands.ItemHeight = 16;
            this.listCommands.Location = new System.Drawing.Point(440, 368);
            this.listCommands.Margin = new System.Windows.Forms.Padding(4);
            this.listCommands.Name = "listCommands";
            this.listCommands.Size = new System.Drawing.Size(405, 132);
            this.listCommands.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 645);
            this.Controls.Add(this.listCommands);
            this.Controls.Add(this.listScripts);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.cbServerVisibility);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtToggleVoting);
            this.Controls.Add(this.txtKickTime);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtInactivity);
            this.Controls.Add(this.txtVoiceChat);
            this.Controls.Add(this.txtDeadChat);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtServerPassword);
            this.Controls.Add(this.txtRconPassword);
            this.Controls.Add(this.txtPrivatePassword);
            this.Controls.Add(this.txtMaxClients);
            this.Controls.Add(this.txtPrivateClients);
            this.Controls.Add(this.txtAuthPort);
            this.Controls.Add(this.txtOpenGamePort);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtMasterPort);
            this.Controls.Add(this.txtSecureGamePort);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.btnAddCommand);
            this.Controls.Add(this.btnAddScript);
            this.Controls.Add(this.btnCleaerCommand);
            this.Controls.Add(this.btnClearScript);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.chkCammand);
            this.Controls.Add(this.chkLoader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Setting";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox chkLoader;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtHostName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSecureGamePort;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtMasterPort;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtOpenGamePort;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtAuthPort;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPrivateClients;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtMaxClients;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtPrivatePassword;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox cbServerVisibility;
        private MetroFramework.Controls.MetroTextBox txtRconPassword;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtServerPassword;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtVoiceChat;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtToggleVoting;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtDeadChat;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtInactivity;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txtKickTime;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroButton btnClearScript;
        private MetroFramework.Controls.MetroButton btnAddScript;
        private MetroFramework.Controls.MetroTextBox txtScript;
        private MetroFramework.Controls.MetroCheckBox chkCammand;
        private MetroFramework.Controls.MetroButton btnCleaerCommand;
        private MetroFramework.Controls.MetroButton btnAddCommand;
        private MetroFramework.Controls.MetroTextBox txtCommand;
        private System.Windows.Forms.ListBox listScripts;
        private System.Windows.Forms.ListBox listCommands;
    }
}