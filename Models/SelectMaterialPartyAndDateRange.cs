using System;
using System.Collections.Generic;

namespace Webfront.Models;

public partial class SelectMaterialPartyAndDateRange
{
    public DateTime? Datex { get; set; }

    public string? Chalanno { get; set; }

    public string? Partyname { get; set; }

    public string? Material { get; set; }

    public decimal? Qty { get; set; }

    public decimal? RateApplied { get; set; }

    public decimal? Bill { get; set; }
}
