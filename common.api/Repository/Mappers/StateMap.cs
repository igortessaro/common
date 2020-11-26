using common.api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace common.api.Repository.Mappers
{
    public class StateMap : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(entity => entity.Id).HasColumnName("Id");
            builder.Property(entity => entity.Name).HasColumnName("Name");
            builder.Property(entity => entity.Initials).HasColumnName("Initials");
            builder.Property(entity => entity.RegionId).HasColumnName("RegionId");

            builder.ToTable(nameof(State), "dbo");
        }
    }
}
