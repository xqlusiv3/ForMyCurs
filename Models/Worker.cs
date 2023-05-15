using System;
using System.Collections.Generic;

namespace NPP.Models;

public partial class Worker
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string? Patronymic { get; set; }

    public int IdDepartment { get; set; }

    public int? IdPost { get; set; }

    public DateTime Birthday { get; set; }

    public string Email { get; set; } = null!;

    public string Address { get; set; } = null!;

    public DateTime DateHiring { get; set; }

    public DateTime? DateDismissal { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual Department IdDepartmentNavigation { get; set; } = null!;

    public virtual Post? IdPostNavigation { get; set; }
}
