using Slick.Net.Core.Logging;
using Slick.Net.Core.Utilities;
using Slick.Net.Core.Utilities.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Slick.Net.EventSubscription.AspNetCore
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBasicSubscriptions(this IServiceCollection services)
        {
            return services
                .AddSingleton<IHostedService, EventSubscriptionService>()
                .AddSingleton(typeof(ILogger<>), typeof(MicrosoftLoggerWrapper<>))
                .AddSingleton<IJsonByteConverter, JsonByteConverter>()
                .AddSingleton<SubscriptionStatistics>()
                .AddSingleton<ISubscriptionStatistics>(x => x.GetRequiredService<SubscriptionStatistics>());
        }
    }
}
