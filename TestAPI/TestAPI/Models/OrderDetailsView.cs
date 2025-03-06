using System;
using System.Collections.Generic;

namespace TestAPI.Models;

public partial class OrderDetailsView
{
    public int OrderId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? OrderStatus { get; set; }

    public string CustomerName { get; set; } = null!;

    public string ShippingAddress { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal TotalPrice { get; set; }
}
