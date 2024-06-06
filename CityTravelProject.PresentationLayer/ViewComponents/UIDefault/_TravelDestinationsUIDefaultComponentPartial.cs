using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.PresentationLayer.ViewComponents.UIDefault
{
    public class _TravelDestinationsUIDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
