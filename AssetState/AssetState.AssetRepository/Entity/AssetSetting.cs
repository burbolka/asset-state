// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssetSetting.cs" company="Burbolka LLC">
//   © Burbolka LLC 2020
// </copyright>
// <summary>
//   Defines the AssetSetting type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AssetState.AssetRepository.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The asset setting.
    /// </summary>
    public class AssetSetting
    {
        /// <summary>
        /// Gets or sets the asset id.
        /// </summary>
        [ForeignKey("AssetId")]
        [Required]
        public Asset Asset { get; set; }

        /// <summary>
        /// Gets or sets the asset id.
        /// </summary>
        [Required]
        public int AssetId { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        [Column("Key")]
        [Required]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether value.
        /// </summary>
        [Column("Value")]
        [Required]
        public bool Value { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        [Column("Timestamp")]
        [Required]
        public DateTime Timestamp { get; set; }
    }
}
