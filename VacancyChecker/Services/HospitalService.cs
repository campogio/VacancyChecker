using VacancyChecker.Models;
using VacancyChecker.ServiceInterfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VacancyChecker.Data;

namespace VacancyChecker.Services
{
    public class HospitalService : IHospitalService
    {



        public HospitalService() {
   
        }

        public HospitalModel create(CreateHospitalModel model)
        {



            Hospital hospital = new Hospital()
            {
                Name = model.name
            };

            return new HospitalModel();
        }

        public HospitalModel delete(int id)
        {
            throw new NotImplementedException();
        }

        public HospitalModel get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hospital> getByAvailableBeds()
        {

            using(VacancyCheckerContext e = new VacancyCheckerContext())
            {

                IEnumerable<Hospital> hospitals;

                var query = from Hospital in e.Hospitals select Hospital;

                hospitals = query.Include(x => x.Wards).ThenInclude(x => x.Beds.Where(y => y.PatientId == null)).ToList();

                return hospitals;
            }
        }

        public IEnumerable<Hospital> getByAvailableBeds(DateTime patientArrival)
        {
            using (VacancyCheckerContext e = new VacancyCheckerContext())
            {

                IEnumerable<Hospital> hospitals;

                var query = from Hospital in e.Hospitals select Hospital;

                hospitals = query.Include(x => x.Wards).ThenInclude(x => x.Beds.Where(y => y.PatientId == null || y.PatientLeavingAt < patientArrival)).ToList();

                return hospitals;
            }
        }

        public HospitalModel update(HospitalModel model)
        {
            throw new NotImplementedException();
        }
    }
}
