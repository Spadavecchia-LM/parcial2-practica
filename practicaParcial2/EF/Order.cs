using System;
using System.Collections.Generic;

namespace practicaParcial2.EF;

public partial class Order
{
    public long OrderId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public long OrderAmount { get; set; }

    public bool IsDeleted { get; set; }
}
