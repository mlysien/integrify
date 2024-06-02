using Integrify.Integrations.Customers.Model;
using Integrify.Integrations.Customers.Port.Driving;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Plugins.ShopSimulator.Customers.Adapter.Driving;

public class CustomersShopSimulatorDrivingAdapter : ICustomersIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<CustomerIntegrationModel>> FetchCollectionAsync()
    {
        return await Task.Run(() => new List<CustomerIntegrationModel>()
        {
            new()
            {
                Id = new IntegrationId(Guid.NewGuid()),
                IsActive = true,
                Name = "Ludwika Misiek"
            },
            new()
            {
                Id = new IntegrationId(Guid.NewGuid()),
                IsActive = false,
                Name = "Andrzej Zyzik"
            },
            new()
            {
                Id = new IntegrationId(Guid.NewGuid()),
                IsActive = true,
                Name = "Aleksander Surdel"
            }
        });
    }

    public async Task<CustomerIntegrationModel> GetSingleAsync(Guid id)
    {
        return await Task.Run(() => new CustomerIntegrationModel()
        {
            Id = new IntegrationId(Guid.NewGuid()),
            IsActive = true,
            Name = "Aleksander Surdel"
        });
    }
}