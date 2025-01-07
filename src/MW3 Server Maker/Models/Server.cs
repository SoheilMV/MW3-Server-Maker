using System.Collections.Generic;
using System.Text;

namespace MW3_Server_Maker
{
    internal class Server
    {
        public List<string> Cammand { get; set; } = new List<string>();
        public List<string> Script { get; set; } = new List<string>();
        public string ServerName { get; set; } = "Your Server Name";
        public int SecureGamePort { get; set; } = 27015;
        public int MasterPort { get; set; } = 27016;
        public int OpenGamePort { get; set; } = 27014;
        public int AuthPort { get; set; } = 8766;
        public int PrivateClients { get; set; } = 0;
        public int MaxClient { get; set; } = 18;
        public string PrivatePassword { get; set; } = string.Empty;
        public string RconPassword { get; set; } = string.Empty;
        public string ServerPassword { get; set; } = string.Empty;
        public int VoiceChat { get; set; } = 1;
        public int ToggleVoting { get; set; } = 1;
        public int DeadChat { get; set; } = 1;
        public int Inactivity { get; set; } = 0;
        public int KickTime { get; set; } = 0;
        public ServerType ServerVisibility { get; set; } = ServerType.Lan;

        public string Create()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("// Modern Warfare 3 Server Configuration");
            sb.AppendLine();
            sb.AppendLine("//////////////////////////////////////////////////////////");
            sb.AppendLine("// Server command-line parameters (this section is for documentation only)");
            sb.AppendLine();
            sb.AppendLine("// Specify server configuration file (this file)");
            sb.AppendLine("//+set sv_config \"filename\" (default \"server.cfg\")");
            sb.AppendLine();
            sb.AppendLine("// Specify server visibility (1 = LAN, 2 = Internet (default) )");
            sb.AppendLine("+set dedicated 1");
            sb.AppendLine();
            sb.AppendLine("// Open game port (Steam-visible server game port)");
            sb.AppendLine("+set net_queryPort 27014");
            sb.AppendLine();
            sb.AppendLine("// Secure game port");
            sb.AppendLine("+set net_port 27015");
            sb.AppendLine();
            sb.AppendLine("// Steam authentication port");
            sb.AppendLine("+set net_authPort 8766");
            sb.AppendLine();
            sb.AppendLine("// Steam master server (server browser) port");
            sb.AppendLine("+set net_masterServerPort 27016");
            sb.AppendLine();
            sb.AppendLine("// Toggle voting for [player kick/map restart/next map] (0 or 1 (default) )");
            sb.AppendLine("+set g_allowVote 1");
            sb.AppendLine();
            sb.AppendLine("//    Valid game options are controlled via DSR (dedicated server recipe) specified in the DSPL.");
            sb.AppendLine("+set sv_maprotation \"default\"");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine("//////////////////////////////////////////////////////////");
            sb.AppendLine("// Server.cfg-configurable settings");
            sb.AppendLine();
            sb.AppendLine("// Server host name. This should always be set by the server admin.");
            sb.AppendLine("set sv_hostname \"" + ServerName + "\"");
            sb.AppendLine();
            sb.AppendLine("// Dedicated server play list (DSPL) specifying server map rotation.");
            sb.AppendLine("//    Valid game options are controlled via DSR (dedicated server recipe) specified in the DSPL.");
            sb.AppendLine("set sv_maprotation \"default\"");
            sb.AppendLine();
            sb.AppendLine("// Maximum number of clients that may connect to this server (range 1-18)");
            sb.AppendLine("set sv_maxclients " + MaxClient);
            sb.AppendLine();
            sb.AppendLine("// Server password. If set, users will be prompted on join attempt.");
            sb.AppendLine("set g_password \"" + ServerPassword + "\"");
            sb.AppendLine();
            sb.AppendLine("// Maximum number of private clients allowed on the server (range 0-18 (clamped to sv_maxclients) )");
            sb.AppendLine("set sv_privateClients " + PrivateClients);
            sb.AppendLine();
            sb.AppendLine("// Password for the private slots on this server. If set, users will be prompted on join attempt.");
            sb.AppendLine("//    Users providing this password will have access to all slots.");
            sb.AppendLine("//    Users providing an incorrect password will have access to the (sv_maxClients - sv_privateClients) public slots.");
            sb.AppendLine("set sv_privatePassword \"" + PrivatePassword + "\"");
            sb.AppendLine();
            sb.AppendLine("// Remote console password. If set, users will have access to a remote console, allowing server administration from a connected client.");
            sb.AppendLine("set rcon_password \"" + RconPassword + "\"");
            sb.AppendLine();
            sb.AppendLine("// Server voice chat configuration ( 0 = \"No Chat\", 1 = \"Free Chat\", 2 = \"Team Chat\" (default) )");
            sb.AppendLine("set sv_voice " + VoiceChat);
            sb.AppendLine();
            sb.AppendLine("// Toggle voting for [player kick/map restart/next map] (0 or 1 (default) )");
            sb.AppendLine("set g_allowVote " + ToggleVoting);
            sb.AppendLine();
            sb.AppendLine("// Toggle allowing dead players to chat with living players (0 (default) or 1)");
            sb.AppendLine("set g_deadChat " + DeadChat);
            sb.AppendLine();
            sb.AppendLine("// Time in seconds before the server will kick a user for inactivity (range 0 - 10000)");
            sb.AppendLine("set g_inactivity " + Inactivity);
            sb.AppendLine();
            sb.AppendLine("// Time in seconds for a player temporary ban (on kick/tempban) (range 0 - 3600)");
            sb.AppendLine("set sv_kickBanTime " + KickTime);
            sb.AppendLine();
            sb.AppendLine("// Toggle flood protection (throttling of user commands - should be enabled for non-password-protected Internet servers) (0 or 1 (default))");
            sb.AppendLine("set sv_floodProtect 0");
            sb.AppendLine();
            sb.AppendLine("// Specify server visibility (1 = LAN, 2 = Internet (default) )");
            sb.AppendLine("set dedicated " + (int)ServerVisibility);
            sb.AppendLine();
            sb.AppendLine("// Open game port (Steam-visible server game port)");
            sb.AppendLine("set net_queryPort " + OpenGamePort);
            sb.AppendLine();
            sb.AppendLine("// Secure game port");
            sb.AppendLine("set net_port " + SecureGamePort);
            sb.AppendLine();
            sb.AppendLine("// Steam authentication port");
            sb.AppendLine("set net_authPort " + AuthPort);
            sb.AppendLine();
            sb.AppendLine("// Steam master server (server browser) port");
            sb.AppendLine("set net_masterServerPort " + MasterPort);
            sb.AppendLine();
            if (Script.Count > 0)
            {
                sb.AppendLine("// Load Script");
                foreach (var script in Script)
                {
                    sb.AppendLine($"loadScript {script}");
                }
                sb.AppendLine();
            }
            if (Cammand.Count > 0)
            {
                sb.AppendLine("//Other Command");
                foreach (var cmd in Cammand)
                {
                    sb.AppendLine(cmd);
                }
                sb.AppendLine();
            }
            sb.AppendLine("//map rotation");
            sb.AppendLine("start_map_rotate");
            return sb.ToString();
        }
    }
}
