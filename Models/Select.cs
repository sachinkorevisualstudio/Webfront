using System;
using System.Collections.Generic;

namespace Webfront.Models;

public partial class Select
{
    public DateTime? Datex { get; set; }

    public decimal? Payablebillwithdiscount { get; set; }

    public string? Chalanno { get; set; }

    public decimal? Discountpercent { get; set; }
}
