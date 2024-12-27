using System;
using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs.Server;
using PluginAPI.Events;
using Server = Exiled.Events.Handlers.Server;
using Warhead = Exiled.Events.Handlers.Warhead;

namespace AutoFF
{
    internal class Plugin : Plugin<Config, Translation>
    {
        public override string Name => "Auto Frendly Fire";
        public override string Prefix => "AutoFF";
        public override string Author => "HidMan228";
        public override Version Version => base.Version;
        public static Plugin plugin { get; private set; }

        public static Item jailbird;

        public override void OnEnabled()
        {
            plugin = this;
            RegisteredEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            plugin = null;
            UnregisteredEvents();
            base.OnDisabled();
        }

        private void RegisteredEvents()
        {
            Warhead.Detonated += EventHandler.OnWarheadDetonated;
            Server.RoundEnded += EventHandler.OnRoundEnd;
            Server.RestartingRound += EventHandler.Reload;
        }

        private void UnregisteredEvents()
        {
            Warhead.Detonated -= EventHandler.OnWarheadDetonated;
            Server.RoundEnded -= EventHandler.OnRoundEnd;
            Server.RestartingRound -= EventHandler.Reload;
        }
    }
}
