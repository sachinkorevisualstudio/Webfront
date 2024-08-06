using System;
using System.Collections.Generic;

namespace Webfront.Models;

public partial class TblRateChartPartywise
{
    public int? Indexnum { get; set; }

    public string Partyname { get; set; } = null!;

    public decimal? RateGsb { get; set; }

    public decimal? RateWmm { get; set; }

    public decimal? Rate60mm { get; set; }

    public decimal? Rate40mm { get; set; }

    public decimal? Rate26mm { get; set; }

    public decimal? Rate20mm { get; set; }

    public decimal? Rate10mm { get; set; }

    public decimal? Rate8by6 { get; set; }

    public decimal? RateMsand { get; set; }

    public decimal? RateDust { get; set; }

    public decimal? RateWsand { get; set; }

    public decimal? RateWpsand { get; set; }

    public decimal? RateStone { get; set; }

    public short? RateRoboSand { get; set; }

    public int? RateSander { get; set; }
}
