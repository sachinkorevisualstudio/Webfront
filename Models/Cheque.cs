using System;
using System.Collections.Generic;

namespace Webfront.Models;

public partial class Cheque
{
    public int? Id { get; set; }

    public DateTime? Datex { get; set; }

    public string? Partyname { get; set; }

    public string? Chequeno { get; set; }

    public double? Rs { get; set; }
}
