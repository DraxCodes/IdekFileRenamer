using Microsoft.Extensions.DependencyInjection;

namespace StarWarsApiSharp.Extensions
{
    public static class DependencyExtension
    {
        public static IServiceCollection UseStarwarsApi(this IServiceCollection services)
        {
            services.AddSingleton<IStarwarsApiClient, StarwarsApiClient>();
            return services;
        }
    }
}
