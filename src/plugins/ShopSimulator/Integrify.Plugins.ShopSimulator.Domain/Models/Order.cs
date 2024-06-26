﻿namespace Integrify.Plugins.ShopSimulator.Domain.Models;

public sealed class Order
{
    public Guid Id { get; init; }
    
    public DateTime CreatedAt { get; init; }

    public DateTime UpdatedAt { get; init; }

    public int Status { get; set; }
    
    public double TotalAmmount { get; init; }

    public Customer Customer { get; init; }

    public List<OrderItem> OrderItems { get; init; }
}