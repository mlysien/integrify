using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Stocks.Core.Services;

internal sealed class StocksIntegration(ILogger<StocksIntegration> logger) : IStocksIntegration
{
    public async Task RunIntegration()
    {
        logger.LogInformation("Stocks integration started");
    }
}