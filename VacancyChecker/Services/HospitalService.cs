using VacancyChecker.Models;
using VacancyChecker.ServiceInterfaces;
using System.Linq;
using VacancyChecker.Data;
using Microsoft.EntityFrameworkCore;

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

                var query = from Hospital in e.Hospitals
                            join Ward in e.Wards on Hospital.Id equals Ward.HospitalId
                            join Bed in e.Beds on Ward.Id equals Bed.WardId
                            where Bed.PatientId == null
                            select Hospital;

                hospitals = query.Include(x => x.Wards).ThenInclude(x => x.Beds).ToList();

                return hospitals;
            }
        }

        public HospitalModel update(HospitalModel model)
        {
            throw new NotImplementedException();
        }
    }
}
