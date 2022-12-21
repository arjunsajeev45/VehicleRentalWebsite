using Microsoft.AspNetCore.Mvc;

namespace VehicleRentalWebsite.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
