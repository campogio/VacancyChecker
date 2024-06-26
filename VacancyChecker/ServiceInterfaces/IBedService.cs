﻿using VacancyChecker;
using VacancyChecker.Models;
using VacancyChecker.Data;

namespace VacancyChecker.ServiceInterfaces
{
    public interface IBedService
    {

        IEnumerable<BedModel> GetAll();

        IEnumerable<BedModel> Get(int id);

        IEnumerable<BedModel> Get(WardModel ward);

        Task<IEnumerable<Bed>> GetAvailable();

        IEnumerable<BedModel> GetAvailable(WardModel ward);

        IEnumerable<BedModel> GetAvailable(HospitalModel hospital);

    }
}
