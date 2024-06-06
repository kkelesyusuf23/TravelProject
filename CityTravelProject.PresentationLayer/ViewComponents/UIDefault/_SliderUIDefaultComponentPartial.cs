using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.PresentationLayer.ViewComponents.UIDefault
{
    public class _SliderUIDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
