using System.ComponentModel.DataAnnotations;

namespace VacancyChecker.Models
{
    public class CreateHospitalModel
    {


        public CreateHospitalModel() { }

        [Required]
        public string name { get; set; }

    }
}
