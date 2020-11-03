// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAssetRepository.cs" company="Burbolka LLC">
//   © Burbolka LLC 2020
// </copyright>
// <summary>
//   Defines the IAssetRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AssetState.Common.Interfaces.Services
{
    using System.Collections.Generic;

    using AssetState.Common.Interfaces.Entity;

    /// <summary>
    /// The AssetRepository interface.
    /// </summary>
    public interface IAssetRepository
    {
        /// <summary>
        /// The get all assets.
        /// </summary>
        /// <returns>
        /// The <see cref="List{IAsset}"/>.
        /// </returns>
        List<IAsset> GetAllAssets();
    }
}
