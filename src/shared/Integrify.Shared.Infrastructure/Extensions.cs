﻿using Integrify.Shared.Infrastructure.Initializer;
using Integrify.Shared.Infrastructure.Integrations;
using Integrify.Shared.Infrastructure.Logging;
using Integrify.Shared.Infrastructure.Options;
using Integrify.Shared.Infrastructure.Plugins;
using Integrify.Shared.Infrastructure.Time;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure;

public static class Extensions
{
    public static void AddInfrastructure(this IServiceCollection serviceCollection, 
        string integrationAssemblyPrefix,
        string pluginAssemblyPrefix)
    {
        serviceCollection.AddClock();
        serviceCollection.AddInitializer();
        serviceCollection.AddIntegrationOptionsProvider();
        serviceCollection.AddConsoleLogging();
        serviceCollection.AddPlugins(pluginAssemblyPrefix);
        serviceCollection.AddIntegrations(integrationAssemblyPrefix);
    }
}