using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Parts.Registration.Core;

namespace Parts.Registration.Infrastructure.Database.Configuration
{
    public class ProviderConfiguration : BaseEntityConfiguration<Provider>
    {
        public override void Configure(EntityTypeBuilder<Provider> builder)
        {
            base.Configure(builder);

            builder.ToTable("Provider");
            builder.Property(p => p.Id).HasColumnName("ProviderId");
            builder.Property(p => p.Name).HasColumnType("varchar(100)");
            builder.Property(p => p.Alias).HasColumnType("varchar(50)");
        }
    }
}
