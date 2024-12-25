using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Player;
using PluginAPI.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoFF
{
    public static class EventHandler
    {
        public static void Reload()
        {
            Server.FriendlyFire = false;
        }

        public static void OnRoundEnd(RoundEndedEventArgs eventArgs)
        {
            Server.FriendlyFire = true;
            foreach (Player player in Player.List)
            {
                if (Plugin.plugin.Config.Jailbirt)
                {
                    player.AddItem(Plugin.jailbird);
                    player.ShowHint(Plugin.plugin.Translation.HintText);
                }
            }
        }

        public static void OnWarheadDetonated()
        {
            Server.FriendlyFire = true;
        }
    }
}
