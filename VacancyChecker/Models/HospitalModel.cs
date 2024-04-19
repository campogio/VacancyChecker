namespace VacancyChecker.Models
{
    public class HospitalModel
    {

        public int id { get; set; }

        public string name { get; set; }

        public IEnumerable<WardModel> wards { get; set; }

    }
}
