using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.PresentationLayer.Controllers
{
	public class UIContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
