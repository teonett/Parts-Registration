using System;
using Microsoft.Extensions.DependencyInjection;

namespace Parts.Registration.Domain.DependencyInjection
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddPartsRegistrationEventIntegration(this IServiceCollection services)
        {
            return services;
        }
    }
}
