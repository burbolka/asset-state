// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssetController.cs" company="Burbolka LLC">
//   © Burbolka LLC 2020
// </copyright>
// <summary>
//   The asset controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AssetState.Controllers.V1
{
    using AssetState.Common.Interfaces.Services;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// The asset controller.
    /// </summary>
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        /// <summary>
        /// The logger.
        /// </summary>
        private readonly ILogger<AssetController> logger;

        /// <summary>
        /// The asset repository.
        /// </summary>
        private readonly IAssetRepository assetRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetController"/> class.
        /// </summary>
        /// <param name="logger">
        /// The logger.
        /// </param>
        /// <param name="assetRepository">
        /// The asset Repository.
        /// </param>
        public AssetController(ILogger<AssetController> logger, IAssetRepository assetRepository)
        {
            this.logger = logger;
            this.assetRepository = assetRepository;
        }

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        [HttpGet]
        [Route("all")]
        public IActionResult GetAll()
        {
            return this.Ok(this.assetRepository.GetAllAssets());
        }
    }
}
