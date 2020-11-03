// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AssetDbContext.cs" company="Burbolka LLC">
//   © Burbolka LLC 2020
// </copyright>
// <summary>
//   Defines the AssetDbContext type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AssetState.AssetRepository
{
    using System;

    using AssetState.AssetRepository.Entity;

    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The asset db context.
    /// </summary>
    public class AssetDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDbContext"/> class.
        /// </summary>
        /// <param name="dbContext">
        /// The db context.
        /// </param>
        public AssetDbContext(DbContextOptions<AssetDbContext> dbContext)
            : base(dbContext)
        {
        }

        /// <summary>
        /// The on model creating.
        /// </summary>
        /// <param name="modelBuilder">
        /// The model builder.
        /// </param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asset>().HasData(
                new Asset() { Id = 1, Name = "first asset" },
                new Asset() { Id = 2, Name = "second asset" });

            modelBuilder.Entity<AssetSetting>().HasData(
                new AssetSetting() { Id = Guid.NewGuid(), Key = "is fix income", Value = true, AssetId = 1 },
                new AssetSetting() { Id = Guid.NewGuid(), Key = "is convertible", Value = false, AssetId = 1 },
                new AssetSetting() { Id = Guid.NewGuid(), Key = "is swap", Value = true, AssetId = 1 },
                new AssetSetting() { Id = Guid.NewGuid(), Key = "is cash", Value = false, AssetId = 1 },
                new AssetSetting() { Id = Guid.NewGuid(), Key = "is future", Value = false, AssetId = 1 },
                new AssetSetting() { Id = Guid.NewGuid(), Key = "is fix income", Value = false, AssetId = 2 },
                new AssetSetting() { Id = Guid.NewGuid(), Key = "is convertible", Value = true, AssetId = 2 },
                new AssetSetting() { Id = Guid.NewGuid(), Key = "is swap", Value = true, AssetId = 2 },
                new AssetSetting() { Id = Guid.NewGuid(), Key = "is cash", Value = true, AssetId = 2 },
                new AssetSetting() { Id = Guid.NewGuid(), Key = "is future", Value = true, AssetId = 2 });



            modelBuilder.Entity<Asset>().HasMany<AssetSetting>(asset => asset.AssetSettings).WithOne(assetSetting => assetSetting.Asset);
            //modelBuilder.Entity<Asset>().OwnsMany(asset => asset.AssetSettings, assetSetting =>
            //    {
            //        assetSetting.WithOwner().HasForeignKey("AssetId");
            //        assetSetting.Property<int>("Id");
            //        assetSetting.HasKey("Id");
            //    });

            //modelBuilder.Entity<AssetSetting>().HasData(
            //    new AssetSetting() { Key = "is fix income", Value = true, AssetId = 1 },
            //    new AssetSetting() { Key = "is convertible", Value = false, AssetId = 1 },
            //    new AssetSetting() { Key = "is swap", Value = true, AssetId = 1 },
            //    new AssetSetting() { Key = "is cash", Value = false, AssetId = 1 },
            //    new AssetSetting() { Key = "is future", Value = false, AssetId = 1 },
            //    new AssetSetting() { Key = "is fix income", Value = false, AssetId = 2 },
            //    new AssetSetting() { Key = "is convertible", Value = true, AssetId = 2 },
            //    new AssetSetting() { Key = "is swap", Value = true, AssetId = 2 },
            //    new AssetSetting() { Key = "is cash", Value = true, AssetId = 2 },
            //    new AssetSetting() { Key = "is future", Value = true, AssetId = 2 });

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Gets or sets the asset.
        /// </summary>
        public DbSet<Asset> Asset { get; set; }

        /// <summary>
        /// Gets or sets the asset setting.
        /// </summary>
        public DbSet<AssetSetting> AssetSetting { get; set; }
    }
}
