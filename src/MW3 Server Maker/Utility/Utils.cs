using System.Drawing;

namespace MW3_Server_Maker
{
    internal static class Utils
    {
        #region MAP

        public static MapType Map(string map)
        {
            string m = map.ToLower();
            if (m == "lockdown")
                return MapType.Lockdown;
            else if (m == "bootleg")
                return MapType.Bootleg;
            else if (m == "mission")
                return MapType.Mission;
            else if (m == "carbon")
                return MapType.Carbon;
            else if (m == "dome")
                return MapType.Dome;
            else if (m == "downturn")
                return MapType.Downturn;
            else if (m == "hardhat")
                return MapType.Hardhat;
            else if (m == "interchange")
                return MapType.Interchange;
            else if (m == "fallen")
                return MapType.Fallen;
            else if (m == "bakaara")
                return MapType.Bakaara;
            else if (m == "resistance")
                return MapType.Resistance;
            else if (m == "arkaden")
                return MapType.Arkaden;
            else if (m == "outpost")
                return MapType.Outpost;
            else if (m == "seatown")
                return MapType.Seatown;
            else if (m == "underground")
                return MapType.Underground;
            else if (m == "aground")
                return MapType.Aground;
            else if (m == "u-turn")
                return MapType.UTurn;
            else if (m == "foundation")
                return MapType.Foundation;
            else if (m == "erosion")
                return MapType.Erosion;
            else if (m == "intersection")
                return MapType.Intersection;
            else if (m == "getaway")
                return MapType.Getaway;
            else if (m == "piazza")
                return MapType.Piazza;
            else if (m == "sanctuary")
                return MapType.Sanctuary;
            else if (m == "black box")
                return MapType.BlackBox;
            else if (m == "parish")
                return MapType.Parish;
            else if (m == "overwatch")
                return MapType.Overwatch;
            else if (m == "liberation")
                return MapType.Liberation;
            else if (m == "oasis")
                return MapType.Oasis;
            else if (m == "lookout")
                return MapType.Lookout;
            else if (m == "roughneck")
                return MapType.Roughneck;
            else if (m == "shipbreaker")
                return MapType.Shipbreaker;
            else if (m == "vortex")
                return MapType.Vortex;
            else if (m == "terminal")
                return MapType.Terminal;
            else //if (m == "Village")
                return MapType.Village;
        }

        public static string Map(MapType map)
        {
            if (map == MapType.Lockdown)
                return "mp_alpha";
            else if (map == MapType.Bootleg)
                return "mp_bootleg";
            else if (map == MapType.Mission)
                return "mp_bravo";
            else if (map == MapType.Carbon)
                return "mp_carbon";
            else if (map == MapType.Dome)
                return "mp_dome";
            else if (map == MapType.Downturn)
                return "mp_exchange";
            else if (map == MapType.Hardhat)
                return "mp_hardhat";
            else if (map == MapType.Interchange)
                return "mp_interchange";
            else if (map == MapType.Fallen)
                return "mp_lambeth";
            else if (map == MapType.Bakaara)
                return "mp_mogadishu";
            else if (map == MapType.Resistance)
                return "mp_paris";
            else if (map == MapType.Arkaden)
                return "mp_plaza2";
            else if (map == MapType.Outpost)
                return "mp_radar";
            else if (map == MapType.Seatown)
                return "mp_seatown";
            else if (map == MapType.Underground)
                return "mp_underground";
            else if (map == MapType.Aground)
                return "mp_aground_ss";
            else if (map == MapType.UTurn)
                return "mp_burn_ss";
            else if (map == MapType.Foundation)
                return "mp_cement";
            else if (map == MapType.Erosion)
                return "mp_courtyard_ss";
            else if (map == MapType.Intersection)
                return "mp_crosswalk_ss";
            else if (map == MapType.Getaway)
                return "mp_hillside_ss";
            else if (map == MapType.Piazza)
                return "mp_italy";
            else if (map == MapType.Sanctuary)
                return "mp_meteora";
            else if (map == MapType.BlackBox)
                return "mp_morningwood";
            else if (map == MapType.Parish)
                return "mp_nola";
            else if (map == MapType.Overwatch)
                return "mp_overwatch";
            else if (map == MapType.Liberation)
                return "mp_park";
            else if (map == MapType.Oasis)
                return "mp_qadeem";
            else if (map == MapType.Lookout)
                return "mp_restrepo_ss";
            else if (map == MapType.Roughneck)
                return "mp_roughneck";
            else if (map == MapType.Shipbreaker)
                return "mp_shipbreaker";
            else if (map == MapType.Vortex)
                return "mp_six_ss";
            else if (map == MapType.Terminal)
                return "mp_terminal_cls";
            else //if (map == MapType.Village)
                return "mp_vilage";
        }

        public static string FindMap(string map)
        {
            map = map.ToLower();
            if (map == "mp_alpha")
                return "Lockdown";
            else if (map == "mp_bootleg")
                return "Bootleg";
            else if (map == "mp_bravo")
                return "Mission";
            else if (map == "mp_carbon")
                return "Carbon";
            else if (map == "mp_dome" )
                return "Dome";
            else if (map == "mp_exchange")
                return "Downturn";
            else if (map == "mp_hardhat")
                return "Hardhat";
            else if (map == "mp_interchange")
                return "Interchange";
            else if (map == "mp_lambeth")
                return "Fallen";
            else if (map == "mp_mogadishu")
                return "Bakaara";
            else if (map == "mp_paris")
                return "Resistance";
            else if (map == "mp_plaza2")
                return "Arkaden";
            else if (map == "mp_radar")
                return "Outpost";
            else if (map == "mp_seatown")
                return "Seatown";
            else if (map == "mp_underground")
                return "Underground";
            else if (map == "mp_aground_ss")
                return "Aground";
            else if (map == "mp_burn_ss")
                return "U-Turn";
            else if (map == "mp_cement")
                return "Foundation";
            else if (map == "mp_courtyard_ss")
                return "Erosion";
            else if (map == "mp_crosswalk_ss")
                return "Intersection";
            else if (map == "mp_hillside_ss")
                return "Getaway";
            else if (map == "mp_italy")
                return "Piazza";
            else if (map == "mp_meteora")
                return "Sanctuary";
            else if (map == "mp_morningwood")
                return "Black Box";
            else if (map == "mp_nola")
                return "Parish";
            else if (map == "mp_overwatch")
                return "Overwatch";
            else if (map == "mp_park")
                return "Liberation";
            else if (map == "mp_qadeem")
                return "Oasis";
            else if (map == "mp_restrepo_ss")
                return "Lookout";
            else if (map == "mp_roughneck")
                return "Roughneck";
            else if (map == "mp_shipbreaker")
                return "Shipbreaker";
            else if (map == "mp_six_ss")
                return "Vortex";
            else if (map == "mp_terminal_cls")
                return "Terminal";
            else //if (map == "mp_vilage")
                return "Village";
        }

        #endregion

        #region MOD

        public static ModType Mod(string mod)
        {
            string m = mod.ToLower();
            if (m == "team deathmatch")
                return ModType.TeamDeathmatch;
            else if (m == "domination")
                return ModType.Domination;
            else if (m == "capture the flag")
                return ModType.CaptureTheFlag;
            else if (m == "drop zone")
                return ModType.DropZone;
            else if (m == "free for all")
                return ModType.FreeForAll;
            else if (m == "gun game")
                return ModType.GunGame;
            else if (m == "headquarters")
                return ModType.Headquarters;
            else if (m == "infected")
                return ModType.Infected;
            else if (m == "juggernaut")
                return ModType.Juggernaut;
            else if (m == "kill confirmed")
                return ModType.KillConfirmed;
            else if (m == "one in the chamber")
                return ModType.OneInTheChamber;
            else if (m == "sabotage")
                return ModType.Sabotage;
            else if (m == "search and destroy")
                return ModType.SearchAndDestroy;
            else if (m == "team defender")
                return ModType.TeamDefender;
            else
                return ModType.TeamJuggernaut;
        }

        public static string Mod(ModType mod, bool hardCore)
        {
            var type = (hardCore ? "Hardcore" : "Core");
            if (mod == ModType.TeamDeathmatch)
                return "TDM-" + type;
            else if (mod == ModType.Domination)
                return "DOM-" + type;
            else if (mod == ModType.CaptureTheFlag)
                return "CTF-" + type;
            else if (mod == ModType.DropZone)
                return "DZ-" + type;
            else if (mod == ModType.FreeForAll)
                return "FFA-" + type;
            else if (mod == ModType.GunGame)
                return "GG-" + type;
            else if (mod == ModType.Headquarters)
                return "HQ-" + type;
            else if (mod == ModType.Infected)
                return "INF-" + type;
            else if (mod == ModType.Juggernaut)
                return "JUG-" + type;
            else if (mod == ModType.KillConfirmed)
                return "KC-" + type;
            else if (mod == ModType.OneInTheChamber)
                return "OIC-" + type;
            else if (mod == ModType.Sabotage)
                return "SAB-" + type;
            else if (mod == ModType.SearchAndDestroy)
                return "SD-" + type;
            else if (mod == ModType.TeamDefender)
                return "TDEF-" + type;
            else
                return "TJ-" + type;
        }

        public static string FindMod(string mod)
        {
            if (mod.StartsWith("TDM"))
                return "Team Deathmatch";
            else if (mod.StartsWith("DOM"))
                return "Domination";
            else if (mod.StartsWith("CTF"))
                return "Capture The Flag";
            else if (mod.StartsWith("DZ"))
                return "Drop Zone";
            else if (mod.StartsWith("FFA"))
                return "Free For All";
            else if (mod.StartsWith("GG"))
                return "Gun Game";
            else if (mod.StartsWith("HQ"))
                return "Headquarters";
            else if (mod.StartsWith("INF"))
                return "Infected";
            else if (mod.StartsWith("JUG"))
                return "Juggernaut";
            else if (mod.StartsWith("KC"))
                return "Kill Confirmed";
            else if (mod.StartsWith("OIC"))
                return "One In The Chamber";
            else if (mod.StartsWith("SAB"))
                return "Sabotage";
            else if (mod.StartsWith("SD"))
                return "Search And Destroy";
            else if (mod.StartsWith("TDEF"))
                return "Team Defender";
            else //if (mod.StartsWith("TJ"))
                return "Team Juggernaut";
        }

        #endregion

        #region IMAGE

        public static Image Image(MapType map)
        {
            if (map == MapType.Lockdown)
                return Properties.Resources.Lockdown;
            else if (map == MapType.Bootleg)
                return Properties.Resources.Bootleg;
            else if (map == MapType.Mission)
                return Properties.Resources.Mission;
            else if (map == MapType.Carbon)
                return Properties.Resources.Carbon;
            else if (map == MapType.Dome)
                return Properties.Resources.Dome;
            else if (map == MapType.Downturn)
                return Properties.Resources.Downturn;
            else if (map == MapType.Hardhat)
                return Properties.Resources.Hardhat;
            else if (map == MapType.Interchange)
                return Properties.Resources.Interchange;
            else if (map == MapType.Fallen)
                return Properties.Resources.Fallen;
            else if (map == MapType.Bakaara)
                return Properties.Resources.Bakaara;
            else if (map == MapType.Resistance)
                return Properties.Resources.Resistance;
            else if (map == MapType.Arkaden)
                return Properties.Resources.Arkaden;
            else if (map == MapType.Outpost)
                return Properties.Resources.Outpost;
            else if (map == MapType.Seatown)
                return Properties.Resources.Seatown;
            else if (map == MapType.Underground)
                return Properties.Resources.Underground;
            else if (map == MapType.Aground)
                return Properties.Resources.Aground;
            else if (map == MapType.UTurn)
                return Properties.Resources.UTurn;
            else if (map == MapType.Foundation)
                return Properties.Resources.Foundation;
            else if (map == MapType.Erosion)
                return Properties.Resources.Erosion;
            else if (map == MapType.Intersection)
                return Properties.Resources.Intersection;
            else if (map == MapType.Getaway)
                return Properties.Resources.Getaway;
            else if (map == MapType.Piazza)
                return Properties.Resources.Piazza;
            else if (map == MapType.Sanctuary)
                return Properties.Resources.Sanctuary;
            else if (map == MapType.BlackBox)
                return Properties.Resources.Black_Box;
            else if (map == MapType.Parish)
                return Properties.Resources.Parish;
            else if (map == MapType.Overwatch)
                return Properties.Resources.Overwatch;
            else if (map == MapType.Liberation)
                return Properties.Resources.Liberation;
            else if (map == MapType.Oasis)
                return Properties.Resources.Oasis;
            else if (map == MapType.Lookout)
                return Properties.Resources.Lookout;
            else if (map == MapType.Roughneck)
                return Properties.Resources.Roughneck;
            else if (map == MapType.Shipbreaker)
                return Properties.Resources.Shipbreaker;
            else if (map == MapType.Vortex)
                return Properties.Resources.Vortex;
            else if (map == MapType.Terminal)
                return Properties.Resources.Terminal;
            else
                return Properties.Resources.Village;
        }

        #endregion

        #region PRIORITY

        public static int Priority(string priority)
        {
            if (priority == "1")
                return 1;
            else if (priority == "100")
                return 100;
            else if (priority == "200")
                return 200;
            else if (priority == "300")
                return 300;
            else if (priority == "400")
                return 400;
            else if (priority == "500")
                return 500;
            else if (priority == "600")
                return 600;
            else if (priority == "700")
                return 700;
            else if (priority == "800")
                return 800;
            else if (priority == "900")
                return 900;
            else
                return 1000;
        }

        #endregion
    }
}
