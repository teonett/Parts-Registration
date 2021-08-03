using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Parts.Registration.Infrastructure.Database.Context;

namespace Parts.Registration.Infrastructure.Database.DependencyInjection
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddPartsRegistrationDbContext(
            this IServiceCollection services,
            Func<IConfiguration, string> connectionStringProvider)
        {
            services.AddDbContext<PartsRegistrationDbContext>();

            services.AddScoped(serviceProvider =>
            {
                var configuration = serviceProvider.GetRequiredService<IConfiguration>();
                var connectionString = connectionStringProvider(configuration);
                var options = new DbContextOptionsBuilder<PartsRegistrationDbContext>();

                //options.UseSqlServer(connectionString);
                return new PartsRegistrationDbContext(options.Options);
            });

            services.AddScoped<DbContext>(
                serviceProvider =>
                serviceProvider.GetRequiredService<PartsRegistrationDbContext>());
            return services;
        }
    }
}
