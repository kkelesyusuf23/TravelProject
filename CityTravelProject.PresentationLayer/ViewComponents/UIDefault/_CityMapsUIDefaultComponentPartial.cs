using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.PresentationLayer.ViewComponents.UIDefault
{
    public class _CityMapsUIDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
