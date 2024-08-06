using System;
using System.Collections.Generic;

namespace Webfront.Models;

public partial class Paidamount
{
    public int? Id { get; set; }

    public DateTime? Datex { get; set; }

    public string? Partyname { get; set; }

    public decimal? Paid { get; set; }

    public string? Otherdetail { get; set; }
}
