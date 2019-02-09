using ColossalFramework;
using ColossalFramework.PlatformServices;
using ColossalFramework.UI;

namespace TrafficManager.Util {
    public class ModCompatibilityHelper {
        public static bool IsSteamWorkshopItemSubscribed(ulong itemId) {
                return ContentManagerPanel.subscribedItemsTable.Contains(new PublishedFileId(itemId));
        }
        
        // TODO more checks for incompatible workshop content
        public static void CheckForOriginalTMPE() {
            if (IsSteamWorkshopItemSubscribed(583429740)) {
                string msg = $"Traffic Manager: President Edition - Improved v.{TrafficManagerMod.Version} detected that you are subscribing to older version of TM:PE (steam id -> 583429740) made by @LinuxFan. \nPlease unsubscribe it from Steam Workshop and restart the game.";
                UIView.GetAView().panelsLibrary.ShowModal<ExceptionPanel>("ExceptionPanel").SetMessage("Detected Original TM:PE subscription", msg, false);
            }
        }
    }
}
