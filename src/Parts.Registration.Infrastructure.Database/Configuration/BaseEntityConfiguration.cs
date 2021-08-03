using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parts.Registration.Core;

namespace Parts.Registration.Infrastructure.Database.Configuration
{
    public abstract class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity<Guid>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Id).HasColumnType("uniqueidentifier");
            builder.Property(prop => prop.CreationDate).HasColumnType("datetime").HasColumnName("CreationDate");
            builder.Property(prop => prop.LastUpdate).HasColumnType("datetime").HasColumnName("LastUpdate");
            builder.Property(prop => prop.CreatedBy).HasColumnType("string").HasColumnName("CreatedBy");
        }
    }
}
