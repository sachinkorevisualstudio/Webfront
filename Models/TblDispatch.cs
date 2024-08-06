using System;
using System.Collections.Generic;

namespace Webfront.Models;

public partial class TblDispatch
{
    public int? Id { get; set; }

    public string? Chalanno { get; set; }

    public string? RegOrStock { get; set; } = null!;

    public DateTime? Datex { get; set; } //date time included
   // public DateOnly? Datex { get; set; }   //dateonly
    public string? Timex { get; set; }

    public string? Monthnamex { get; set; }

    public string? Yearnamex { get; set; }

    public string? Partyname { get; set; }

    public string? Txtpartynamesearched { get; set; }

    public string? Site { get; set; }

    public string? Vehicleno { get; set; }

    public string? Drivername { get; set; }

    public string? Supervisorname { get; set; }

    public string? Material { get; set; }

    public string? Trip { get; set; }

    public decimal? Ton { get; set; }

    public decimal? Qty { get; set; }

    public decimal? RateFromchart { get; set; }

    public decimal? TransportCharge { get; set; }

    public decimal? RateApplied { get; set; }

    public decimal? Amount1 { get; set; }

    public string? Gstcustomer { get; set; }

    public decimal? GstAmount { get; set; }

    public decimal? TotalAmountBill { get; set; }

    public decimal? Discountpercent { get; set; }

    public decimal? Royalty { get; set; }

    public decimal? Payablebillwithdiscount { get; set; }

    public decimal? CashPaymentRs { get; set; }

    public decimal? OnlinePaymentRs { get; set; }

    public string? Summary { get; set; }

    public decimal? JamaAmt { get; set; }

    public int? Monthnumber { get; set; }
}
