namespace MW3_Server_Maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_mod = new MetroFramework.Controls.MetroComboBox();
            this.cb_map = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.btn_start = new MetroFramework.Controls.MetroButton();
            this.btn_options = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cb_priority = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listDspl = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAbout = new MetroFramework.Controls.MetroButton();
            this.cb_hardCore = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MW3_Server_Maker.Properties.Resources.Aground;
            this.pictureBox1.Location = new System.Drawing.Point(31, 287);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cb_mod
            // 
            this.cb_mod.FormattingEnabled = true;
            this.cb_mod.ItemHeight = 24;
            this.cb_mod.Items.AddRange(new object[] {
            "Capture The Flag",
            "Domination",
            "Drop Zone",
            "Free For All",
            "Gun Game",
            "Headquarters",
            "Infected",
            "Juggernaut",
            "Kill Confirmed",
            "One In The Chamber",
            "Sabotage",
            "Search And Destory",
            "Team Defender",
            "Team Deathmatch",
            "Team Juggernaut"});
            this.cb_mod.Location = new System.Drawing.Point(335, 544);
            this.cb_mod.Margin = new System.Windows.Forms.Padding(4);
            this.cb_mod.Name = "cb_mod";
            this.cb_mod.Size = new System.Drawing.Size(217, 30);
            this.cb_mod.Style = MetroFramework.MetroColorStyle.Lime;
            this.cb_mod.TabIndex = 9;
            this.cb_mod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cb_mod.UseSelectable = true;
            this.cb_mod.SelectedIndexChanged += new System.EventHandler(this.cb_mod_SelectedIndexChanged);
            // 
            // cb_map
            // 
            this.cb_map.FormattingEnabled = true;
            this.cb_map.ItemHeight = 24;
            this.cb_map.Items.AddRange(new object[] {
            "Aground",
            "Arkaden",
            "Lockdown",
            "Bootleg",
            "Mission",
            "Carbon",
            "Dome",
            "Downturn",
            "Hardhat",
            "Interchange",
            "Fallen",
            "Bakaara",
            "Resistance",
            "Outpost",
            "Seatown",
            "Underground",
            "Village",
            "U-Turn",
            "Foundation",
            "Erosion",
            "Intersection",
            "Getaway",
            "Piazza",
            "Sanctuary",
            "Black Box",
            "Parish",
            "Overwatch",
            "Liberation",
            "Oasis",
            "Lookout",
            "Roughneck",
            "Shipbreaker",
            "Vortex",
            "Terminal"});
            this.cb_map.Location = new System.Drawing.Point(79, 544);
            this.cb_map.Margin = new System.Windows.Forms.Padding(4);
            this.cb_map.Name = "cb_map";
            this.cb_map.Size = new System.Drawing.Size(199, 30);
            this.cb_map.Style = MetroFramework.MetroColorStyle.Lime;
            this.cb_map.TabIndex = 8;
            this.cb_map.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cb_map.UseSelectable = true;
            this.cb_map.SelectedIndexChanged += new System.EventHandler(this.cb_map_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(286, 550);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Mod ";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(31, 550);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Map ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(333, 598);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(143, 43);
            this.btn_clear.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(182, 598);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(143, 43);
            this.btn_add.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(31, 598);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(143, 43);
            this.btn_start.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_start.TabIndex = 14;
            this.btn_start.Text = "Start";
            this.btn_start.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_start.UseSelectable = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_options
            // 
            this.btn_options.Location = new System.Drawing.Point(674, 598);
            this.btn_options.Margin = new System.Windows.Forms.Padding(4);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(143, 43);
            this.btn_options.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_options.TabIndex = 15;
            this.btn_options.Text = "Setting";
            this.btn_options.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_options.UseSelectable = true;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(789, 550);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 20);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Priority  ";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cb_priority
            // 
            this.cb_priority.FormattingEnabled = true;
            this.cb_priority.ItemHeight = 24;
            this.cb_priority.Items.AddRange(new object[] {
            "1",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.cb_priority.Location = new System.Drawing.Point(856, 544);
            this.cb_priority.Margin = new System.Windows.Forms.Padding(4);
            this.cb_priority.Name = "cb_priority";
            this.cb_priority.Size = new System.Drawing.Size(111, 30);
            this.cb_priority.Style = MetroFramework.MetroColorStyle.Lime;
            this.cb_priority.TabIndex = 17;
            this.cb_priority.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cb_priority.UseSelectable = true;
            this.cb_priority.SelectedIndexChanged += new System.EventHandler(this.cb_priority_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 78);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(937, 202);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // listDspl
            // 
            this.listDspl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listDspl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listDspl.FullRowSelect = true;
            this.listDspl.Location = new System.Drawing.Point(483, 287);
            this.listDspl.Margin = new System.Windows.Forms.Padding(4);
            this.listDspl.Name = "listDspl";
            this.listDspl.OwnerDraw = true;
            this.listDspl.Size = new System.Drawing.Size(484, 249);
            this.listDspl.Style = MetroFramework.MetroColorStyle.Lime;
            this.listDspl.TabIndex = 19;
            this.listDspl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.listDspl.UseCompatibleStateImageBehavior = false;
            this.listDspl.UseSelectable = true;
            this.listDspl.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Map";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mod";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "HardCore";
            this.columnHeader3.Width = 89;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(825, 598);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(143, 43);
            this.btnAbout.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnAbout.TabIndex = 20;
            this.btnAbout.Text = "About";
            this.btnAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAbout.UseSelectable = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // cb_hardCore
            // 
            this.cb_hardCore.FormattingEnabled = true;
            this.cb_hardCore.ItemHeight = 24;
            this.cb_hardCore.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.cb_hardCore.Location = new System.Drawing.Point(653, 544);
            this.cb_hardCore.Margin = new System.Windows.Forms.Padding(4);
            this.cb_hardCore.Name = "cb_hardCore";
            this.cb_hardCore.Size = new System.Drawing.Size(128, 30);
            this.cb_hardCore.Style = MetroFramework.MetroColorStyle.Lime;
            this.cb_hardCore.TabIndex = 22;
            this.cb_hardCore.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cb_hardCore.UseSelectable = true;
            this.cb_hardCore.SelectedIndexChanged += new System.EventHandler(this.cb_hardCore_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(560, 550);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(85, 20);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Hard Core   ";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Priority";
            this.columnHeader4.Width = 89;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 670);
            this.Controls.Add(this.cb_hardCore);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.listDspl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cb_priority);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btn_options);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cb_mod);
            this.Controls.Add(this.cb_map);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "MW3 Server Maker";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox cb_mod;
        private MetroFramework.Controls.MetroComboBox cb_map;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_add;
        private MetroFramework.Controls.MetroButton btn_start;
        private MetroFramework.Controls.MetroButton btn_options;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cb_priority;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroListView listDspl;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroButton btnAbout;
        private MetroFramework.Controls.MetroComboBox cb_hardCore;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

