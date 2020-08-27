using JikanDotNet;
using Microsoft.Extensions.DependencyInjection;

namespace Disboard.Server
{
    public partial class Startup
    {
        private static void InjectDependencies(IServiceCollection services)
        {
            //services.AddTransient<CalendarService>();

            services.AddSingleton<IJikan, Jikan>();
        }
    }
}
