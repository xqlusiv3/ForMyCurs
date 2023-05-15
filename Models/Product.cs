using System;
using System.Collections.Generic;

namespace NPP.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdTypeEquipment { get; set; }

    public double Count { get; set; }

    public string Description { get; set; } = null!;

    public virtual TypeEquipment IdTypeEquipmentNavigation { get; set; } = null!;

    public virtual ICollection<OrgProduct> OrgProducts { get; set; } = new List<OrgProduct>();
}
