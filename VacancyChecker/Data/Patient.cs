using System;
using System.Collections.Generic;

namespace VacancyChecker.Data;

public partial class Patient
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Bed> Beds { get; set; } = new List<Bed>();
}
