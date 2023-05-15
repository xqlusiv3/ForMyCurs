using System;
using System.Collections.Generic;

namespace NPP.Models;

public partial class Contract
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdWorker { get; set; }

    public int IdOrgProduct { get; set; }

    public int IdStatus { get; set; }

    public DateTime DateContract { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    public virtual OrgProduct IdOrgProductNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual Worker IdWorkerNavigation { get; set; } = null!;
}
