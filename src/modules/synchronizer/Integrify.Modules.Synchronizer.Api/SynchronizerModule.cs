﻿using Integrify.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Modules.Synchronizer.Api;

public class SynchronizerModule : IModule
{
    public string Name => "Synchrnizer";
    
    public Version? Version => new(0, 0, 1);
    
    public void Register(IServiceCollection services)
    {
     
    }

    public void Use(IApplicationBuilder app)
    {

    }
}