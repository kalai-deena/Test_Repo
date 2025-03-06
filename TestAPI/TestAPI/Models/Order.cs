using System;
using System.Collections.Generic;

namespace TestAPI.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public int ShippingAddressId { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Address ShippingAddress { get; set; } = null!;
}
