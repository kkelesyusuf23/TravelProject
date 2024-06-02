using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.PresentationLayer.Controllers
{
	public class UIRotationController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
