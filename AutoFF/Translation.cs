using Exiled.API.Interfaces;
using System;
using System.ComponentModel;

namespace AutoFF
{
    public class Translation : ITranslation
    {
        [Description("What will be written when FF is enabled")]
        public string HintText { get; set; } = "Friendly Fire is <b><color=#23bf00>Enabled</color><b>";
        [Description("What will be written when FF is disabled")]
        public string HintText2 { get; set; } = "Friendly Fire is <b><color=red>Disabled</color><b>";
    }
}
