using System;
using System.Collections.Generic;

namespace Webfront.Models;

public partial class Qjama
{
    public int? Id { get; set; }

    public string? Monthname { get; set; }

    public short? Year { get; set; }

    public DateTime? Datex { get; set; }

    public string? Partyname { get; set; }

    public decimal? Paid { get; set; }

    public string? Otherdetail { get; set; }
}
