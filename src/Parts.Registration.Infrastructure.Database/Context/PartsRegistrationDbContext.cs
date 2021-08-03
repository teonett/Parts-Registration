using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Parts.Registration.Infrastructure.Database.Configuration;

namespace Parts.Registration.Infrastructure.Database.Context
{
    public class PartsRegistrationDbContext : DbContext
    {
        public PartsRegistrationDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProviderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
