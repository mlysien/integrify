using Integrify.Shared.Abstractions.Events;

namespace Integrify.Modules.Orders.Core.Events;

internal record OrdersSynchronisationFinished(DateTime finishedAt) : IEvent;