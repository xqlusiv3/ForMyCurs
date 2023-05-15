using System;
using System.Collections.Generic;

namespace NPP.Models;

public partial class Organization
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdContract { get; set; }

    public int? IdCountry { get; set; }

    public string City { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Website { get; set; }

    public int IdUserOrg { get; set; }

    public virtual County? IdCountryNavigation { get; set; }

    public virtual User IdUserOrgNavigation { get; set; } = null!;

    public virtual ICollection<OrgProduct> OrgProducts { get; set; } = new List<OrgProduct>();
}
