using System;
using System.Collections.Generic;

namespace BookStore.Dal.Models;

public partial class Orderitem
{
    public int OrderItemId { get; set; }

    public int? OrderId { get; set; }

    public int? BookId { get; set; }

    public int? Quantity { get; set; }

    public decimal? PricePerUnit { get; set; }

    public virtual Book Book { get; set; }

    public virtual Order Order { get; set; }
}
