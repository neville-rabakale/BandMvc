using BandMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandMvc.Controllers
{
    public class BandsController : Controller
    {
        DataService service;
        public BandsController()
        {
            service= new DataService();
        }
        [HttpGet("")]
        [HttpGet("index")]
        public IActionResult Index()
        {
            var model = service.GetAlBands();
            return View(model);
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var model = service.GetBandById(id);
            return View(model);
        }

    }
}
