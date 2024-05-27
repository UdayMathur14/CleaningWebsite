using Microsoft.AspNetCore.Mvc;

namespace DrivingSchoolWebsite.Controllers
{
    public class DrivingSchoolController : Controller
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
