using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MW3_Server_Maker
{
    public partial class Form1 : MetroForm
    {
        private readonly string configPath = $"{Environment.CurrentDirectory}\\config.mv";
        private readonly string defaultPath = $"{Environment.CurrentDirectory}\\players2\\default.dspl";

        private Default dspl;
        private string map = string.Empty;
        private string mod = string.Empty;
        private bool hardCore = false;
        private int priority;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dspl = new Default(defaultPath);
            if (File.Exists(defaultPath))
            {
                dspl.Read();
                foreach (var rotation in dspl.Rotations)
                {
                    string[] result = rotation.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    var map = Utils.FindMap(result[0].Trim());
                    var mod = Utils.FindMod(result[1].Trim());
                    var hc = result[1].Contains("Hardcore");
                    var priority = result[2].Trim();
                    listDspl.Items.Add(new ListViewItem(new string[] { map, mod, hc.ToString(), priority }));
                }
            }

            if (!File.Exists(configPath))
            {
                cb_map.SelectedIndex = 0;
                cb_mod.SelectedIndex = 0;
                cb_hardCore.SelectedIndex = 0;
                cb_priority.SelectedIndex = 0;
            }
            else
            {
                IniReader iniReader = new IniReader(configPath);
                cb_map.Text = iniReader.ReadString("Server", "Map", "Aground");
                cb_mod.Text = iniReader.ReadString("Server", "Mod", "Capture The Flag");
                cb_hardCore.Text = iniReader.ReadString("Server", "HardCore", "Enable");
                cb_priority.Text = iniReader.ReadString("Server", "Priority", "1");
            }
        }

        private void cb_map_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = Utils.Map(cb_map.SelectedItem.ToString());
            pictureBox1.Image = Utils.Image(type);
            map = Utils.Map(type);
        }

        private void cb_mod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = Utils.Mod(cb_mod.SelectedItem.ToString());
            mod = Utils.Mod(type, hardCore);
        }

        private void cb_hardCore_SelectedIndexChanged(object sender, EventArgs e)
        {
            hardCore = cb_hardCore.SelectedIndex == 0;
        }

        private void cb_priority_SelectedIndexChanged(object sender, EventArgs e)
        {
            priority = Utils.Priority(cb_priority.SelectedItem.ToString());
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dspl.Rotations.Clear();
            listDspl.Items.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dspl.Add(map, mod, priority);
            listDspl.Items.Add(new ListViewItem(new string[] { cb_map.SelectedItem.ToString(), cb_mod.SelectedItem.ToString(), (cb_hardCore.SelectedIndex == 0).ToString(), cb_priority.SelectedItem.ToString() }));
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (File.Exists("TeknoMW3_Server_Launcher.exe"))
            {
                IniReader iniReader = new IniReader(configPath);
                iniReader.Write("Server", "Map", cb_map.Text);
                iniReader.Write("Server", "Mod", cb_mod.Text);
                iniReader.Write("Server", "HardCore", cb_hardCore.Text);
                iniReader.Write("Server", "Priority", cb_priority.Text);
                dspl.Write();
                Process.Start("TeknoMW3_Server_Launcher.exe", "start_map_rotate");
                Application.Exit();
            }
            else
            {
                MetroMessageBox.Show(this, "\nTeknoMW3_Server_Launcher.exe Not Found!", "MW3 Server Maker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            MetroMessageBox.Show(this, $"Developer: Soheil MV\nGithub: https://github.com/SoheilMV\nRepository: https://github.com/SoheilMV/MW3-Server-Maker\nVersion: {version.Major}.{version.Minor}", "MW3 Server Maker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
