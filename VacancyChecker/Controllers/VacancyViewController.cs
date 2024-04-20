using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VacancyChecker;
using VacancyChecker.Models;
using VacancyChecker.ServiceInterfaces;

namespace VacancyChecker.Controllers
{
    public class VacancyViewController : Controller
    {

        IBedService bedService;
        IHospitalService hospitalService;

        public VacancyViewController(IBedService _bedService, IHospitalService _hospitalService) {
        
            bedService = _bedService;
            hospitalService = _hospitalService;
        
        }

        // GET: VacancyViewController
        public async Task<ActionResult> Index()
        {

            BedSearchModel model = new BedSearchModel();

            model.results = hospitalService.getByAvailableBeds();

            return View(model);
        }

        // GET: VacancyViewController
        public async Task<ActionResult> IndexByArrivalTime(DateTime dateTime)
        {

            BedSearchModel model = new BedSearchModel();

            try
            {
                model.results = hospitalService.getByAvailableBeds(dateTime);
            }catch (Exception ex)
            {
                //Handle SQL Datetime Overflow Exception
                return View();
            }
 

            return View(model);
        }

    }
}
