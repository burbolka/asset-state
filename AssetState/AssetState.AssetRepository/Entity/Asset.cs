// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Asset.cs" company="Burbolka LLC">
//   © Burbolka LLC 2020
// </copyright>
// <summary>
//   Defines the Asset type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AssetState.AssetRepository.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The asset.
    /// </summary>
    public class Asset
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), DefaultValue(true)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Column("Name")]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the asset settings.
        /// </summary>
        public ICollection<AssetSetting> AssetSettings { get; set; }
    }
}
