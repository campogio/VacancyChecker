using System;
using System.Collections.Generic;

namespace VacancyChecker.Data;

public partial class Bed
{
    public int Id { get; set; }

    public int? PatientId { get; set; }

    public int? WardId { get; set; }

    public DateTime? PatientLeavingAt { get; set; }

    public virtual Patient? Patient { get; set; }

    public virtual Ward? Ward { get; set; }
}
