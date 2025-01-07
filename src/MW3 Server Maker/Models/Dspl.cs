using System.Text;

namespace MW3_Server_Maker
{
    internal class Dspl
    {
        private readonly StringBuilder sb = new StringBuilder();

        public string Name { get; set; } = "default";

        public Dspl()
        {
            sb.AppendLine("///////////////////////////////////////////////////////////////////////////");
            sb.AppendLine("///////////Modern Warfare 3 dedicated server default playlist//////////////");
            sb.AppendLine("///////////////////////////////////////////////////////////////////////////");
            sb.AppendLine();
            sb.AppendLine("//format is ");
            sb.AppendLine("//<mapname>, <dsr filename>, <weight>");
            sb.AppendLine();
            sb.AppendLine("//<mapname>");
            sb.AppendLine("//valid mapnames:");
            sb.AppendLine("//*");
            sb.AppendLine("//mp_alpha");
            sb.AppendLine("//mp_bootleg");
            sb.AppendLine("//mp_bravo");
            sb.AppendLine("//mp_carbon");
            sb.AppendLine("//mp_dome");
            sb.AppendLine("//mp_exchange");
            sb.AppendLine("//mp_hardhat");
            sb.AppendLine("//mp_interchange");
            sb.AppendLine("//mp_labmeth");
            sb.AppendLine("//mp_mogadishu");
            sb.AppendLine("//mp_paris");
            sb.AppendLine("//mp_plaza2");
            sb.AppendLine("//mp_radar");
            sb.AppendLine("//mp_seatown");
            sb.AppendLine("//mp_underground");
            sb.AppendLine("//mp_village");
            sb.AppendLine("//<dlc maps> (included under '*')");
            sb.AppendLine();
            sb.AppendLine("//dsr filename");
            sb.AppendLine("//name of recipe file without the dsr extension");
            sb.AppendLine("//included in this package are the following recipe defaults:");
            sb.AppendLine("//TDM_default 	(Team Deathmatch)");
            sb.AppendLine("//DOM_default 	(Domination)");
            sb.AppendLine("//CTF_default 	(Capture The Flag)");
            sb.AppendLine("//DZ_default  	(Drop Zone)");
            sb.AppendLine("//FFA_default 	(Free For All)");
            sb.AppendLine("//GG_default	(Gun Game)");
            sb.AppendLine("//HQ_default	(Headquarters)");
            sb.AppendLine("//INF_default	(Infected)");
            sb.AppendLine("//JUG_default	(Juggernaut)");
            sb.AppendLine("//KC_default	(Kill Confirmed)");
            sb.AppendLine("//OIC_default	(One In The Chamber)");
            sb.AppendLine("//SAB_default	(Sabotage)");
            sb.AppendLine("//SD_default	(Search and Destroy)");
            sb.AppendLine("//TDEF_default	(Team Defender)");
            sb.AppendLine("//TJ_default	(Team Juggernaut)");
            sb.AppendLine();
            sb.AppendLine("// Weight (1->1000)");
            sb.AppendLine("// Selection is weighted random (higher weights increase selection chance)");
            sb.AppendLine();
        }

        public void Add(string map, string mod, int priority)
        {
            sb.AppendLine($"{map},{mod},{priority}");
        }

        public override string ToString()
        {
            return sb.ToString();
        }
    }
}
