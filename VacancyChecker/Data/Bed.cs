using System;
using System.Collections.Generic;

namespace VacancyChecker.Data;

public partial class Bed
{
    public int Id { get; set; }

    public int? PatientId { get; set; }

    public int? WardId { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();

    public virtual Ward? Ward { get; set; }
}
