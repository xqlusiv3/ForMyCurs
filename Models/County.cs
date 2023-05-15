using System;
using System.Collections.Generic;

namespace NPP.Models;

public partial class County
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();
}
