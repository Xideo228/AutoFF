using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFF
{
    internal class Config : IConfig
    {
        [Description("Plugin on/off")]
        public bool IsEnabled { get; set; } = true;
        [Description("Debug mode")]
        public bool Debug { get; set; } = false;
        [Description("Give everyone a Jailbird when the round ends")]
        public bool Jailbirt { get; set; } = true;
    }
}
