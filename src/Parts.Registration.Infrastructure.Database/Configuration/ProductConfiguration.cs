using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parts.Registration.Core;

namespace Parts.Registration.Infrastructure.Database.Configuration
{
    public class ProductConfiguration : BaseEntityConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.ToTable("Product");
            builder.Property(p => p.Id).HasColumnName("ProductId");
            builder.Property(p => p.Name).HasColumnType("varchar(100)");
            builder.Property(p => p.Description).HasColumnType("varchar(100)");
            builder.Property(p => p.PartNumber).HasColumnType("varchar(100)");
            builder.Property(p => p.ProviderId).HasColumnName("ProviderId");
        }
    }
}
