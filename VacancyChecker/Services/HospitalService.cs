using VacancyChecker.Data;
using VacancyChecker.Models;
using VacancyChecker.ServiceInterfaces;
using System.Linq;

namespace VacancyChecker.Services
{
    public class HospitalService : IHospitalService
    {


        VacancyCheckerContext _context;

        public HospitalService(VacancyCheckerContext context) {
        
        _context = context;
        
        }

        public HospitalModel create(CreateHospitalModel model)
        {

            Hospital hospital = new Hospital()
            {
                Name = model.name
            };

            _context.Add<Hospital>(hospital);
            _context.SaveChanges();

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

        public HospitalModel update(HospitalModel model)
        {
            throw new NotImplementedException();
        }
    }
}
