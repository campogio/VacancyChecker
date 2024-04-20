using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using VacancyChecker.Models;
using VacancyChecker.ServiceInterfaces;
using VacancyChecker.Data;

namespace VacancyChecker.Services
{
    public class BedService : IBedService
    {

        public BedService() { }

        public IEnumerable<BedModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BedModel> Get(WardModel ward)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BedModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Bed>> GetAvailable()
        {

            IEnumerable<Bed> bedList;

            using (VacancyCheckerContext e = new VacancyCheckerContext())
            {

                return await e.Beds.Where(x => x.PatientId == null).ToListAsync();

            }

        }

        public IEnumerable<BedModel> GetAvailable(WardModel ward)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BedModel> GetAvailable(HospitalModel hospital)
        {
            throw new NotImplementedException();
        }
    }
}
