using System;
using System.Collections.Generic;

namespace VacancyChecker.Data;

public partial class Patient
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? BedId { get; set; }

    public virtual Bed? Bed { get; set; }
}
