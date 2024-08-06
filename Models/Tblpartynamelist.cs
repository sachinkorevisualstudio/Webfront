using System;
using System.Collections.Generic;

namespace Webfront.Models;

public partial class Tblpartynamelist
{
    public string Partyname { get; set; } = null!;

    public string GstCustomer { get; set; } = null!;

    public decimal? Transcharge { get; set; }

    public int? Discount { get; set; }
}
