using System;
using System.Collections.Generic;

namespace TestAPI.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int OrderId { get; set; }

    public DateTime? PaymentDate { get; set; }

    public decimal Amount { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public string? TransactionId { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Order Order { get; set; } = null!;
}
