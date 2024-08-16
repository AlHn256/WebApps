using Microsoft.AspNetCore.Mvc;
using MVCWebTestApl.Models;
using System.Diagnostics;

namespace MVCWebTestApl.Controllers
{
    public class HomeController : Controller
    {
        private ISingletonService _singleton;
        private IScopedService _scoped;
        private ITrancientService _trancient;

        public HomeController(ISingletonService singleton, IScopedService scoped, ITrancientService trancient)
        {
            _singleton = singleton;
            _scoped = scoped;
            _trancient = trancient;
        }


        public IActionResult Index()
        {
            return View("Index" , _singleton.GetGuid());
        }
        [HttpPost]
        public ActionResult Scoped(string firstName)
        {
            return Content("Hello, " + firstName+"!");
        }


        [HttpGet]
        public IActionResult Scoped()
        {
            return View("Scoped", _scoped.GetGuid());
        }

        [HttpPost]
        public ActionResult MyAction(string product, string action)
        {
            if (action == "add")
            {

            }
            else if (action == "delete")
            {

            }
            // остальной код метода

            return View("GetGuid - ", _scoped.GetGuid());
        }

        public IActionResult Transcient()
        {
            return View("Trancient", _trancient.GetGuid());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
