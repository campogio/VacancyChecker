using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VacancyChecker.Data;
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

        // GET: VacancyViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VacancyViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VacancyViewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VacancyViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VacancyViewController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VacancyViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VacancyViewController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
