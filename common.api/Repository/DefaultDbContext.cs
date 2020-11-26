using common.api.Entities;
using common.api.Repository.Mappers;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace common.api.Repository
{
    public sealed class DefaultDbContext : DbContext
    {
        public DbSet<Region> Regions { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        public DefaultDbContext([NotNullAttribute] DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RegionMap());
            modelBuilder.ApplyConfiguration(new StateMap());
            modelBuilder.ApplyConfiguration(new CityMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
