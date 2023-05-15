using System;
using System.Collections.Generic;

namespace NPP.Models;

public partial class Delivery
{
    public int Id { get; set; }

    public int IdContract { get; set; }

    public string Comment { get; set; } = null!;

    public virtual Contract IdContractNavigation { get; set; } = null!;
}
