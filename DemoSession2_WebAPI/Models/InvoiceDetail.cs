using System;
using System.Collections.Generic;

namespace DemoSession2_WebAPI.Models;

public partial class InvoiceDetail
{
    public int InvoiceId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
