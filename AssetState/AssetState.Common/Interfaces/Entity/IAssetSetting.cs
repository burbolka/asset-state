// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAssetSetting.cs" company="Burbolka LLC">
//   © Burbolka LLC 2020
// </copyright>
// <summary>
//   Defines the IAssetSetting type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AssetState.Common.Interfaces.Entity
{
    using System;

    /// <summary>
    /// The AssetSetting interface.
    /// </summary>
    public interface IAssetSetting
    {
        /// <summary>
        /// Gets or sets the asset id.
        /// </summary>
        IAsset Asset { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        string Key { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        string Value { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        DateTime Timestamp { get; set; }
    }
}
