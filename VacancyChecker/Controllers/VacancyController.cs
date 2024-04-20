using Microsoft.AspNetCore.Mvc;
using VacancyChecker.Data;
using VacancyChecker.Models;
using VacancyChecker.ServiceInterfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VacancyChecker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacancyController : ControllerBase
    {

        IBedService bedService;

        public VacancyController(IBedService _bedService) {
        
            bedService = _bedService;

        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Bed> Get()
        {
            return bedService.GetAvailable().Result;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
