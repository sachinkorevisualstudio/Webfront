using System;
using System.Collections.Generic;

namespace Webfront.Models;

public partial class Codetabledispatch
{
    public int Chalanno { get; set; }

    public string RegOrStock { get; set; } = null!;

    public DateTime Datex { get; set; }

    public string Partyname { get; set; } = null!;

    public string Site { get; set; } = null!;

    public string Vehicleno { get; set; } = null!;

    public decimal? TGsb { get; set; }

    public decimal? RateGsb { get; set; }

    public decimal? AmtGsb { get; set; }

    public decimal? TWmm { get; set; }

    public decimal? RateWmm { get; set; }

    public decimal? AmtWmm { get; set; }

    public decimal? T60mm { get; set; }

    public decimal? Rate60Mm { get; set; }

    public decimal? Amt60mm { get; set; }

    public decimal? T40mm { get; set; }

    public decimal? Rate40Mm { get; set; }

    public decimal? Amt40mm { get; set; }

    public decimal? T26mm { get; set; }

    public decimal? Rate26Mm { get; set; }

    public decimal? Amt26mm { get; set; }

    public decimal? T20mm { get; set; }

    public decimal? Rate20Mm { get; set; }

    public decimal? Amt20mm { get; set; }

    public decimal? T10mm { get; set; }

    public decimal? Rate10Mm { get; set; }

    public decimal? Amt10mm { get; set; }

    public decimal? T8b6 { get; set; }

    public decimal? Rate8b6 { get; set; }

    public decimal? Amt8b6 { get; set; }

    public decimal? TMsand { get; set; }

    public decimal? RateMsand { get; set; }

    public decimal? AmtMsand { get; set; }

    public decimal? TDust { get; set; }

    public decimal? RateDust { get; set; }

    public decimal? AmtDust { get; set; }

    public decimal? TWashSand { get; set; }

    public decimal? RateWashSand { get; set; }

    public decimal? AmtWashSand { get; set; }

    public decimal? TWashPlSand { get; set; }

    public decimal? RateWashPlSand { get; set; }

    public decimal? AmtWashPlSand { get; set; }

    public decimal? TransportCharge { get; set; }

    public decimal? Amount1 { get; set; }

    public string? Gstcustomer { get; set; }

    public decimal? Amountwith5Gst { get; set; }

    public decimal? AmountReceived { get; set; }

    public decimal? RemainingAsDiscountRs { get; set; }

    public string? PaymentPartyType { get; set; }

    public string? PaymentMode { get; set; }
}
