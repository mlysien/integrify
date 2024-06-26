using Integrify.Clients.Cli.Interpreter.Abstractions;
using Integrify.Clients.Cli.Interpreter.Commands;
using Integrify.Clients.Cli.Interpreter.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Clients.Cli.Interpreter;

public static class Extensions
{
    public static void AddCommandsInterpreter(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddCommands();
        serviceCollection.AddScoped<IInterpreter, CommandsInterpreter>();
    }
}