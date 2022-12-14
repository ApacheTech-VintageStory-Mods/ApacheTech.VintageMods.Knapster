using Gantry.Services.FileSystem.Features;
using Newtonsoft.Json;
using System.Collections.Generic;
using ApacheTech.VintageMods.Knapster.Abstractions;
using ApacheTech.VintageMods.Knapster.DataStructures;

namespace ApacheTech.VintageMods.Knapster.Features.EasySmithing
{
    /// <summary>
    ///     Represents user-controllable settings used for the mod.
    /// </summary>
    /// <seealso cref="FeatureSettings" />
    [JsonObject]
    public class EasySmithingSettings : FeatureSettings, IEasyFeatureSettings
    {
        /// <summary>
        ///     Determines whether the EasyClayForming Feature should be used.
        /// </summary>
        public AccessMode Mode { get; set; } = AccessMode.Enabled;

        /// <summary>
        ///     When the mode is set to `Whitelist`, only the players on this list will have the feature enabled.
        /// </summary>
        public List<Player> Whitelist { get; set; } = new();

        /// <summary>
        ///     When the mode is set to `Blacklist`, the players on this list will have the feature disabled.
        /// </summary>
        public List<Player> Blacklist { get; set; } = new();

        /// <summary>
        ///     Determines the amount of durability that is lost at one time, when using the Easy Smithing feature.
        /// </summary>
        public int CostPerClick { get; set; } = 5;
    }
}