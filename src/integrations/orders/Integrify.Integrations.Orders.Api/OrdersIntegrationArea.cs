﻿using Integrify.Integrations.Orders.Api.Public;
using Integrify.Integrations.Orders.Core;
using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Orders.Api;

internal sealed class OrdersIntegrationArea : IIntegrationArea
{
    public string Name => "Orders";
    
    public void AddIntegrationDependencies(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IOrdersIntegrationApi, OrdersIntegrationApi>();
        serviceCollection.AddOrdersIntegrationCoreLayer();
    }
}