using System;
using Exiled.API.Features;
using CommandSystem;
using Exiled.Permissions.Extensions;

namespace AutoFF
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Command : ICommand
    {
        public string[] Aliases { get; set; } = { "FF" };

        public string Description => "Enabled/Disabled FF";

        string ICommand.Command => "FriendlyFire";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("ff.togle"))
            {
                response = "You don't have enough permissions.";
                return false;
            } else if (Server.FriendlyFire)
            {
                Server.FriendlyFire = false;
                foreach (Player player in Player.List)
                {
                    player.ShowHint(Plugin.plugin.Translation.HintText2);
                }
                response = "Ok, FF is disabled";
                return true;
            }
            else
            {
                Server.FriendlyFire = true;
                foreach (Player player in Player.List)
                {
                    player.ShowHint(Plugin.plugin.Translation.HintText2);
                }
                response = "Ok, FF is enabled";
                return true;
            }
        }
    }
}
