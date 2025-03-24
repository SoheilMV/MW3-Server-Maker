using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MW3_Server_Maker
{
    public partial class Form2 : MetroForm
    {
        private readonly string serverPath = $"{Environment.CurrentDirectory}\\players2\\server.cfg";
        private readonly string scriptsPath = $"{Environment.CurrentDirectory}\\scripts.mv";
        private readonly string commandsPath = $"{Environment.CurrentDirectory}\\commands.mv";
        private readonly Server server;

        public Form2()
        {
            InitializeComponent();
            server = new Server(serverPath);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            server.Read();
            LoadConfig();
            LoadScripts();
            LoadCommands();
        }

        private void chk_loader1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkScripts.Checked)
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
            SaveConfig();
            SaveScripts();
            SaveCommands();
            server.Write();
            MetroMessageBox.Show(this, "\nConfiguration Saved In \"server.cfg\" File!", "MW3 Server Maker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private new void KeyPress(object sender, KeyPressEventArgs e)
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
            server.ClearScrips();
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
            server.ClearCommands();
        }

        private void LoadConfig()
        {
            txtHostName.Text = server.HostName;
            txtMapRotation.Text = server.MapRotation;
            txtMaxClients.Text = server.MaxClients;
            txtServerPassword.Text = server.Password;
            txtPrivateClients.Text = server.PrivateClients;
            txtPrivatePassword.Text = server.PrivatePassword;
            txtRconPassword.Text = server.RconPassword;
            cboVoice.SelectedIndex = int.Parse(server.Voice);
            cboAllowVote.SelectedIndex = int.Parse(server.AllowVote);
            cboDeadChat.SelectedIndex = int.Parse(server.DeadChat);
            txtInactivity.Text = server.Inactivity;
            txtKickTime.Text = server.KickBanTime;
            cboFloodProtect.SelectedIndex = int.Parse(server.FloodProtect);
            txtMaxPing.Text = server.MaxPing;
            cboBanByGuid.SelectedIndex = int.Parse(server.BanByGuid);
            cboBanByIp.SelectedIndex = int.Parse(server.BanByIp);
            txtClanWebsite.Text = server.ClanWebsite;
            txtDiscord.Text = server.Discord;
            txtFullMessage.Text = server.ServerFullMessage;
            cbServerVisibility.SelectedIndex = int.Parse(server.SpecifyServerVisibility) - 1;
            txtOpenGamePort.Text = server.OpenGamePort;
            txtSecureGamePort.Text = server.SecureGamePort;
            txtAuthPort.Text = server.AuthenticationPort;
            txtMasterPort.Text = server.MasterServerPort;

            if (File.Exists(scriptsPath))
            {
                chkScripts.Checked = true;
                chkScripts.CheckState = CheckState.Checked;
            }
            else
            {
                chkScripts.Checked = false;
                chkScripts.CheckState = CheckState.Unchecked;
            }

            if (File.Exists(commandsPath))
            {
                chkCammand.Checked = true;
                chkCammand.CheckState = CheckState.Checked;
            }
            else
            {
                chkCammand.Checked = false;
                chkCammand.CheckState = CheckState.Unchecked;
            }
        }

        private void SaveConfig()
        {
            server.HostName = txtHostName.Text;
            server.MapRotation = txtMapRotation.Text;
            server.MaxClients = txtMaxClients.Text;
            server.Password = txtServerPassword.Text;
            server.PrivateClients = txtPrivateClients.Text;
            server.PrivatePassword = txtPrivatePassword.Text;
            server.RconPassword = txtRconPassword.Text;
            server.Voice = cboVoice.SelectedIndex.ToString();
            server.AllowVote = cboAllowVote.SelectedIndex.ToString();
            server.DeadChat = cboDeadChat.SelectedIndex.ToString();
            server.Inactivity = txtInactivity.Text;
            server.KickBanTime = txtKickTime.Text;
            server.FloodProtect = cboFloodProtect.SelectedIndex.ToString();
            server.MaxPing = txtMaxPing.Text;
            server.BanByGuid = cboBanByGuid.SelectedIndex.ToString();
            server.BanByIp = cboBanByIp.SelectedIndex.ToString();
            server.ClanWebsite = txtClanWebsite.Text;
            server.Discord = txtDiscord.Text;
            server.ServerFullMessage = txtFullMessage.Text;
            server.SpecifyServerVisibility = (cbServerVisibility.SelectedIndex + 1).ToString();
            server.OpenGamePort = txtOpenGamePort.Text;
            server.SecureGamePort = txtSecureGamePort.Text;
            server.AuthenticationPort = txtAuthPort.Text;
            server.MasterServerPort = txtMasterPort.Text;
        }

        private void LoadScripts()
        {
            if (File.Exists(scriptsPath))
            {
                string[] scripts = File.ReadAllLines(scriptsPath);
                foreach (string script in scripts)
                {
                    if (!string.IsNullOrEmpty(script))
                    {
                        listScripts.Items.Add(script);
                        server.AddScript(script);
                    }
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
                    {
                        listCommands.Items.Add(command);
                        server.AddCommand(command);
                    }
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
