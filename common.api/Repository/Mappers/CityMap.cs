using common.api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace common.api.Repository.Mappers
{
    public sealed class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(entity => entity.Id).HasColumnName("Id");
            builder.Property(entity => entity.Name).HasColumnName("Name");
            builder.Property(entity => entity.StateId).HasColumnName("StateId");

            builder.ToTable(nameof(City), "dbo");
        }
    }
}
