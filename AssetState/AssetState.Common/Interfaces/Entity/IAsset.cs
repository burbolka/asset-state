// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAsset.cs" company="Burbolka LLC">
//   © Burbolka LLC 2020
// </copyright>
// <summary>
//   Defines the IAsset type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AssetState.Common.Interfaces.Entity
{
    using System.Collections.Generic;

    /// <summary>
    /// The i asset.
    /// </summary>
    public interface IAsset
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the asset settings.
        /// </summary>
        ICollection<IAssetSetting> AssetSettings { get; set; }
    }
}
