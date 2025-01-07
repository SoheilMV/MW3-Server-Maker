using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MW3_Server_Maker
{
    public partial class Form1 : MetroForm
    {
        private readonly string configPath = $"{Environment.CurrentDirectory}\\config.mv";
        private readonly string commandsPath = $"{Environment.CurrentDirectory}\\commands.mv";
        private readonly string defaultPath = $"{Environment.CurrentDirectory}\\players2\\default.dspl";

        private Dspl dspl = new Dspl();
        private string map = string.Empty;
        private string mod = string.Empty;
        private int priority;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(configPath))
            {
                cb_map.SelectedIndex = 0;
                cb_mod.SelectedIndex = 0;
                cb_priority.SelectedIndex = 0;
            }
            else
            {
                IniReader iniReader = new IniReader(configPath);
                cb_map.Text = iniReader.ReadString("Server", "MAP", "");
                cb_mod.Text = iniReader.ReadString("Server", "MOD", "");
                cb_priority.SelectedIndex = 0;
            }
        }

        private void cb_map_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = Convertor.Map(cb_map.SelectedItem.ToString());
            pictureBox1.Image = Convertor.Image(type);
            map = Convertor.Map(type);
        }

        private void cb_mod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = Convertor.Mod(cb_mod.SelectedItem.ToString());
            mod = Convertor.Mod(type);
        }

        private void cb_priority_SelectedIndexChanged(object sender, EventArgs e)
        {
            priority = Convertor.Priority(cb_priority.SelectedItem.ToString());
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listDspl.Items.Clear();
            dspl = new Dspl();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dspl.Add(map, mod, priority);
            listDspl.Items.Add(new ListViewItem(new string[] { cb_map.SelectedItem.ToString(), cb_mod.SelectedItem.ToString(), cb_priority.SelectedItem.ToString() }));
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (File.Exists("TeknoMW3_Server_Launcher.exe"))
            {
                using (StreamWriter sw = new StreamWriter(defaultPath, false))
                {
                    sw.Write(dspl.ToString());
                }

                IniReader iniReader = new IniReader(configPath);
                iniReader.Write("Server", "MAP", cb_map.Text);
                iniReader.Write("Server", "MOD", cb_mod.Text);

                string[] commands = File.ReadAllLines(commandsPath);
                StringBuilder arguments = new StringBuilder();
                foreach (var command in commands)
                {
                    arguments.Append($"{command} ");
                }

                Process.Start("TeknoMW3_Server_Launcher.exe", arguments.ToString());

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
            MetroMessageBox.Show(this, "Coded By Soheil MV\nVersion: 3.2", "MW3 Server Maker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
