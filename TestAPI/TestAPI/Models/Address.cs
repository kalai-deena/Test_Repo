using System;
using System.Collections.Generic;

namespace TestAPI.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public int CustomerId { get; set; }

    public string AddressLine1 { get; set; } = null!;

    public string? AddressLine2 { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string Country { get; set; } = null!;

    public bool? IsDefault { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
