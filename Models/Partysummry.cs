using System;
using System.Collections.Generic;

namespace Webfront.Models;

public partial class Partysummry
{
    public string? Chalanno { get; set; }

    public DateTime? Datex { get; set; }

    public string? Partyname { get; set; }

    public string? Vehicleno { get; set; }

    public string? Material { get; set; }

    public decimal? Qty { get; set; }

    public decimal? RateFromchart { get; set; }

    public decimal? TransportCharge { get; set; }

    public decimal? RateApplied { get; set; }

    public decimal? Payablebillwithdiscount { get; set; }
}
