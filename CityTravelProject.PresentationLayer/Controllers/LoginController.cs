using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
