﻿using Disboard.Server.AniList;
using Microsoft.Extensions.DependencyInjection;

namespace Disboard.Server
{
    public partial class Startup
    {
        private static void InjectDependencies(IServiceCollection services)
        {
            services.AddSingleton<AniWrapper>();
        }
    }
}
