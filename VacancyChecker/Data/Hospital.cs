using System;
using System.Collections.Generic;

namespace VacancyChecker.Data;

public partial class Hospital
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Ward> Wards { get; set; } = new List<Ward>();
}
