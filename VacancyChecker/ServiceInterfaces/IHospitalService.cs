using VacancyChecker.Data;
using VacancyChecker.Models;

namespace VacancyChecker.ServiceInterfaces
{
    public interface IHospitalService
    {

        HospitalModel create(CreateHospitalModel model);
        HospitalModel update(HospitalModel model);
        HospitalModel delete(int id);
        HospitalModel get(int id);

        IEnumerable<Hospital> getByAvailableBeds();

    }
}
