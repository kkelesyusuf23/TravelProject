using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.PresentationLayer.Controllers
{
	public class UIAboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
