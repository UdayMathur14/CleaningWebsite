using Microsoft.AspNetCore.Mvc;

namespace CleaningWebsite.Controllers
{
    public class CleaningController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
