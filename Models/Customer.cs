using System;
using System.Collections.Generic;

namespace DbFirst.Models;

public partial class Customer
{
    public decimal CustId { get; set; }

    public string CustName { get; set; } = null!;

    public decimal CustAge { get; set; }

    public decimal? CustPhone { get; set; }
}
