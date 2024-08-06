using System;
using System.Collections.Generic;

namespace Webfront.Models;

public partial class TblPartyYeneBaki
{
    public string Partyname { get; set; } = null!;

    public decimal? Yenebaki { get; set; }
}
