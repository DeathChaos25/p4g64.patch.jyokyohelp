using System.ComponentModel;
using p4g64.patch.jyokyohelp.Template.Configuration;
using Reloaded.Mod.Interfaces.Structs;

namespace p4g64.patch.jyokyohelp.Configuration
{
    public class Config : Configurable<Config>
    {
        [DisplayName("Debug")]
        [Description("Display extra messages for debugging purposes")]
        [DefaultValue(false)]
        public bool Debug { get; set; } = false;
    }

    /// <summary>
    /// Allows you to override certain aspects of the configuration creation process (e.g. create multiple configurations).
    /// Override elements in <see cref="ConfiguratorMixinBase"/> for finer control.
    /// </summary>
    public class ConfiguratorMixin : ConfiguratorMixinBase
    {
        // 
    }
}
