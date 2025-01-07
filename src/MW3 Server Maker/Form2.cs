using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MW3_Server_Maker
{
    public partial class Form2 : MetroForm
    {
        private readonly string serverPath = $"{Environment.CurrentDirectory}\\players2\\server.cfg";
        private readonly string configPath = $"{Environment.CurrentDirectory}\\config.mv";
        private readonly string scriptsPath = $"{Environment.CurrentDirectory}\\scripts.mv";
        private readonly string commandsPath = $"{Environment.CurrentDirectory}\\commands.mv";
        private ServerType serverType = ServerType.Lan;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadConfig();
            LoadScripts();
            LoadCommands();
        }

        private void chk_loader1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoader.Checked)
            {
                txtScript.Enabled = true;
                listScripts.Enabled = true;
                btnAddScript.Enabled = true;
                btnClearScript.Enabled = true;
            }
            else
            {
                txtScript.Enabled = false;
                listScripts.Enabled = false;
                btnAddScript.Enabled = false;
                btnClearScript.Enabled = false;
            }
        }

        private void chkCammand_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCammand.Checked)
            {
                txtCommand.Enabled = true;
                listCommands.Enabled = true;
                btnAddCommand.Enabled = true;
                btnCleaerCommand.Enabled = true;
            }
            else
            {
                txtCommand.Enabled = false;
                listCommands.Enabled = false;
                btnAddCommand.Enabled = false;
                btnCleaerCommand.Enabled = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SaveServerCfg();
            SaveConfig();
            SaveScripts();
            SaveCommands();
            MetroMessageBox.Show(this, "\nConfiguration Saved In \"server.cfg\" File!", "MW3 Server Maker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_sv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbServerVisibility.SelectedItem.ToString() == "Lan")
                serverType = ServerType.Lan;
            else
                serverType = ServerType.Internet;
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void btnAddScript_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScript.Text))
            {
                listScripts.Items.Add(txtScript.Text.Trim());
                txtScript.Clear();
            }
        }

        private void btnClearScript_Click(object sender, EventArgs e)
        {
            listScripts.Items.Clear();
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCommand.Text))
            {
                listCommands.Items.Add(txtCommand.Text.Trim());
                txtCommand.Clear();
            }
        }

        private void btnCleaerCommand_Click(object sender, EventArgs e)
        {
            listCommands.Items.Clear();
        }

        private void SaveServerCfg()
        {
            using (StreamWriter sw = new StreamWriter(serverPath, false))
            {
                sw.WriteLine("// Modern Warfare 3 Server Configuration");
                sw.WriteLine();
                sw.WriteLine("//////////////////////////////////////////////////////////");
                sw.WriteLine("// Server command-line parameters (this section is for documentation only)");
                sw.WriteLine();
                sw.WriteLine("// Specify server configuration file (this file)");
                sw.WriteLine("// +set sv_config \"filename\" (default \"server.cfg\")");
                sw.WriteLine();
                sw.WriteLine("// Specify server visibility (1 = LAN, 2 = Internet (default) )");
                sw.WriteLine("// +set dedicated 1");
                sw.WriteLine();
                sw.WriteLine("// Open game port (Steam-visible server game port)");
                sw.WriteLine("// +set net_queryPort 27014");
                sw.WriteLine();
                sw.WriteLine("// Secure game port");
                sw.WriteLine("// +set net_port 27015");
                sw.WriteLine();
                sw.WriteLine("// Steam authentication port");
                sw.WriteLine("// +set net_authPort 8766");
                sw.WriteLine();
                sw.WriteLine("// Steam master server (server browser) port");
                sw.WriteLine("// +set net_masterServerPort 27016");
                sw.WriteLine();
                sw.WriteLine("// Toggle voting for [player kick/map restart/next map] (0 or 1 (default) )");
                sw.WriteLine("// +set g_allowVote 1");
                sw.WriteLine();
                sw.WriteLine("// Valid game options are controlled via DSR (dedicated server recipe) specified in the DSPL.");
                sw.WriteLine("// +set sv_maprotation \"default\"");
                sw.WriteLine();
                sw.WriteLine();
                sw.WriteLine();
                sw.WriteLine("//////////////////////////////////////////////////////////");
                sw.WriteLine("// Server.cfg-configurable settings");
                sw.WriteLine();
                sw.WriteLine("// Server host name. This should always be set by the server admin.");
                sw.WriteLine("set sv_hostname \"" + txtHostName.Text + "\"");
                sw.WriteLine();
                sw.WriteLine("// Dedicated server play list (DSPL) specifying server map rotation.");
                sw.WriteLine("//    Valid game options are controlled via DSR (dedicated server recipe) specified in the DSPL.");
                sw.WriteLine("set sv_maprotation \"default\"");
                sw.WriteLine();
                sw.WriteLine("// Maximum number of clients that may connect to this server (range 1-18)");
                sw.WriteLine("set sv_maxclients " + txtMaxClients.Text);
                sw.WriteLine();
                sw.WriteLine("// Server password. If set, users will be prompted on join attempt.");
                sw.WriteLine("set g_password \"" + txtServerPassword.Text + "\"");
                sw.WriteLine();
                sw.WriteLine("// Maximum number of private clients allowed on the server (range 0-18 (clamped to sv_maxclients) )");
                sw.WriteLine("set sv_privateClients " + txtPrivateClients.Text);
                sw.WriteLine();
                sw.WriteLine("// Password for the private slots on this server. If set, users will be prompted on join attempt.");
                sw.WriteLine("//    Users providing this password will have access to all slots.");
                sw.WriteLine("//    Users providing an incorrect password will have access to the (sv_maxClients - sv_privateClients) public slots.");
                sw.WriteLine("set sv_privatePassword \"" + txtPrivatePassword.Text + "\"");
                sw.WriteLine();
                sw.WriteLine("// Remote console password. If set, users will have access to a remote console, allowing server administration from a connected client.");
                sw.WriteLine("set rcon_password \"" + txtRconPassword.Text + "\"");
                sw.WriteLine();
                sw.WriteLine("// Server voice chat configuration ( 0 = \"No Chat\", 1 = \"Free Chat\", 2 = \"Team Chat\" (default) )");
                sw.WriteLine("set sv_voice " + txtVoiceChat.Text);
                sw.WriteLine();
                sw.WriteLine("// Toggle voting for [player kick/map restart/next map] (0 or 1 (default) )");
                sw.WriteLine("set g_allowVote " + txtToggleVoting.Text);
                sw.WriteLine();
                sw.WriteLine("// Toggle allowing dead players to chat with living players (0 (default) or 1)");
                sw.WriteLine("set g_deadChat " + txtDeadChat.Text);
                sw.WriteLine();
                sw.WriteLine("// Time in seconds before the server will kick a user for inactivity (range 0 - 10000)");
                sw.WriteLine("set g_inactivity " + txtInactivity.Text);
                sw.WriteLine();
                sw.WriteLine("// Time in seconds for a player temporary ban (on kick/tempban) (range 0 - 3600)");
                sw.WriteLine("set sv_kickBanTime " + txtKickTime.Text);
                sw.WriteLine();
                sw.WriteLine("// Toggle flood protection (throttling of user commands - should be enabled for non-password-protected Internet servers) (0 or 1 (default))");
                sw.WriteLine("set sv_floodProtect 0");
                sw.WriteLine();
                sw.WriteLine("// Specify server visibility (1 = LAN, 2 = Internet (default) )");
                if (serverType == ServerType.Lan)
                    sw.WriteLine("set dedicated 1");
                else
                    sw.WriteLine("set dedicated 2");
                sw.WriteLine();
                sw.WriteLine("// Open game port (Steam-visible server game port)");
                sw.WriteLine("set net_queryPort " + txtOpenGamePort.Text);
                sw.WriteLine();
                sw.WriteLine("// Secure game port");
                sw.WriteLine("set net_port " + txtSecureGamePort.Text);
                sw.WriteLine();
                sw.WriteLine("// Steam authentication port");
                sw.WriteLine("set net_authPort " + txtAuthPort.Text);
                sw.WriteLine();
                sw.WriteLine("// Steam master server (server browser) port");
                sw.WriteLine("set net_masterServerPort " + txtMasterPort.Text);
                sw.WriteLine();
                if (chkLoader.Checked)
                {
                    sw.WriteLine("// Load Script");
                    StringBuilder sb = new StringBuilder();
                    foreach (string item in listScripts.Items)
                    {
                        sb.AppendLine($"loadScript {item}");
                    }
                    sw.WriteLine(sb.ToString());
                }
                sw.WriteLine();
                sw.WriteLine("//map rotation");
                sw.WriteLine("start_map_rotate");
            }
        }

        private void LoadConfig()
        {
            if (File.Exists(configPath))
            {
                IniReader iniReader = new IniReader(configPath);
                txtHostName.Text = iniReader.ReadString("Configuration", "Servare Name", "");
                txtSecureGamePort.Text = iniReader.ReadString("Configuration", "Secure Game Port", "");
                txtMasterPort.Text = iniReader.ReadString("Configuration", "Master Port", "");
                txtOpenGamePort.Text = iniReader.ReadString("Configuration", "Open Game Port", "");
                txtAuthPort.Text = iniReader.ReadString("Configuration", "Auth Port", "");
                txtPrivateClients.Text = iniReader.ReadString("Configuration", "Private Clients", "");
                txtMaxClients.Text = iniReader.ReadString("Configuration", "Max Clients", "");
                txtPrivatePassword.Text = iniReader.ReadString("Configuration", "Private Password", "");
                txtRconPassword.Text = iniReader.ReadString("Configuration", "RCON Password", "");
                txtServerPassword.Text = iniReader.ReadString("Configuration", "Server Password", "");
                txtVoiceChat.Text = iniReader.ReadString("Configuration", "Voice Chat", "");
                txtToggleVoting.Text = iniReader.ReadString("Configuration", "Toggle Voting", "");
                txtDeadChat.Text = iniReader.ReadString("Configuration", "Dead Chat", "");
                txtInactivity.Text = iniReader.ReadString("Configuration", "Inactivity", "");
                txtKickTime.Text = iniReader.ReadString("Configuration", "Kick Time", "");
                cbServerVisibility.Text = iniReader.ReadString("Configuration", "Server Visibility", "");
                string loader1;
                loader1 = iniReader.ReadString("Configuration", "Check Loader", "");
                if (loader1 == "true")
                {
                    chkLoader.Checked = true;
                    chkLoader.CheckState = CheckState.Checked;
                }
                else if (loader1 == "false")
                {
                    chkLoader.Checked = false;
                    chkLoader.CheckState = CheckState.Unchecked;
                }
            }
            else
            {
                txtHostName.Text = "Your Server Name";
                txtSecureGamePort.Text = "27015";
                txtMasterPort.Text = "27016";
                txtOpenGamePort.Text = "27014";
                txtAuthPort.Text = "8766";
                txtPrivateClients.Text = "0";
                txtMaxClients.Text = "18";
                txtPrivatePassword.Text = "";
                txtRconPassword.Text = "";
                txtServerPassword.Text = "";
                txtVoiceChat.Text = "1";
                txtToggleVoting.Text = "1";
                txtDeadChat.Text = "1";
                txtInactivity.Text = "0";
                txtKickTime.Text = "0";
                cbServerVisibility.Text = "Lan";
            }
        }

        private void SaveConfig()
        {
            IniReader iniReader = new IniReader(configPath);
            iniReader.Write("Configuration", "Servare Name", txtHostName.Text);
            iniReader.Write("Configuration", "Secure Game Port", txtSecureGamePort.Text);
            iniReader.Write("Configuration", "Master Port", txtMasterPort.Text);
            iniReader.Write("Configuration", "Open Game Port", txtOpenGamePort.Text);
            iniReader.Write("Configuration", "Auth Port", txtAuthPort.Text);
            iniReader.Write("Configuration", "Private Clients", txtPrivateClients.Text);
            iniReader.Write("Configuration", "Max Clients", txtMaxClients.Text);
            iniReader.Write("Configuration", "Private Password", txtPrivatePassword.Text);
            iniReader.Write("Configuration", "RCON Password", txtRconPassword.Text);
            iniReader.Write("Configuration", "Server Password", txtServerPassword.Text);
            iniReader.Write("Configuration", "Voice Chat", txtVoiceChat.Text);
            iniReader.Write("Configuration", "Toggle Voting", txtToggleVoting.Text);
            iniReader.Write("Configuration", "Dead Chat", txtDeadChat.Text);
            iniReader.Write("Configuration", "Inactivity", txtInactivity.Text);
            iniReader.Write("Configuration", "Kick Time", txtKickTime.Text);
            iniReader.Write("Configuration", "Server Visibility", cbServerVisibility.Text);
            if (chkLoader.Checked)
            {
                iniReader.Write("Configuration", "Check Loader", "true");
            }
            else
            {
                iniReader.Write("Configuration", "Check Loader", "false");
            }
        }

        private void LoadScripts()
        {
            if (File.Exists(scriptsPath))
            {
                string[] scripts = File.ReadAllLines(scriptsPath);
                foreach (string script in scripts)
                {
                    if (!string.IsNullOrEmpty(script))
                        listScripts.Items.Add(script);
                }
            }
        }

        private void SaveScripts()
        {
            if (listScripts.Items.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter(scriptsPath, false))
                {
                    foreach (string script in listScripts.Items)
                    {
                        sw.WriteLine(script);
                    }
                }
            }
            else
            {
                File.Delete(scriptsPath);
            }
        }

        private void LoadCommands()
        {
            if (File.Exists(commandsPath))
            {
                string[] commands = File.ReadAllLines(commandsPath);
                foreach (string command in commands)
                {
                    if (!string.IsNullOrEmpty(command))
                        listCommands.Items.Add(command);
                }
            }
        }

        private void SaveCommands()
        {
            if (listCommands.Items.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter(commandsPath, false))
                {
                    foreach (string command in listCommands.Items)
                    {
                        sw.WriteLine(command);
                    }
                }
            }
            else
            {
                File.Delete(commandsPath);
            }
        }
    }
}
