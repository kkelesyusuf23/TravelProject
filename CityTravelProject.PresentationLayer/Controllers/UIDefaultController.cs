using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.PresentationLayer.Controllers
{
	public class UIDefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
