using System;
using System.Collections.Generic;

namespace NPP.Models;

public partial class TypeEquipment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
