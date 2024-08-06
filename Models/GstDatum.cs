using System;
using System.Collections.Generic;

namespace Webfront.Models;

public partial class GstDatum
{
    public string? Chalanno { get; set; }

    public DateTime? Datex { get; set; }

    public string? Monthnamex { get; set; }

    public string? Yearnamex { get; set; }

    public string? Partyname { get; set; }

    public string? Site { get; set; }

    public string? Vehicleno { get; set; }

    public string? Drivername { get; set; }

    public string? Material { get; set; }

    public decimal? Qty { get; set; }

    public decimal? RateApplied { get; set; }

    public decimal Amount1 { get; set; }

    public decimal? GstAmount { get; set; }

    public decimal? Payablebillwithdiscount { get; set; }
}
