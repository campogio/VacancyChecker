using System;
using System.Collections.Generic;

namespace VacancyChecker.Data;

public partial class Ward
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? HospitalId { get; set; }

    public virtual ICollection<Bed> Beds { get; set; } = new List<Bed>();

    public virtual Hospital? Hospital { get; set; }
}
