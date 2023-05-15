using System;
using System.Collections.Generic;

namespace NPP.Models;

public partial class OrgProduct
{
    public int Id { get; set; }

    public int IdOrg { get; set; }

    public int IdProduct { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual Organization IdOrgNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
