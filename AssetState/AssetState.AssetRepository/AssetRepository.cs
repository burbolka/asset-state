// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssetRepository.cs" company="Burbolka LLC">
//   © Burbolka LLC 2020
// </copyright>
// <summary>
//   Defines the AssetRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AssetState.AssetRepository
{
    using System.Collections.Generic;

    using AssetState.Common.Interfaces.Entity;
    using AssetState.Common.Interfaces.Services;

    using Microsoft.Extensions.Logging;

    /// <summary>
    /// The asset repository.
    /// </summary>
    public class AssetRepository : IAssetRepository
    {
        /// <summary>
        /// The logger.
        /// </summary>
        private readonly ILogger<AssetRepository> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetRepository"/> class.
        /// </summary>
        /// <param name="logger">
        /// The logger.
        /// </param>
        public AssetRepository(ILogger<AssetRepository> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// The get all assets.
        /// </summary>
        /// <returns>
        /// The <see cref="List{IAsset}"/>.
        /// </returns>
        public List<IAsset> GetAllAssets()
        {
            return new List<IAsset>();
        }
    }
}
