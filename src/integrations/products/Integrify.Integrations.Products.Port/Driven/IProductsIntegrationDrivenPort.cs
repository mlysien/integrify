using Integrify.Integrations.Products.Model;
using Integrify.Shared.Abstractions.Ports;

namespace Integrify.Integrations.Products.Port.Driven;

/// <summary>
/// Marker interface for products integration driven port
/// </summary>
public interface IProductsIntegrationDrivenPort : IDrivenPort<ProductIntegrationModel>;