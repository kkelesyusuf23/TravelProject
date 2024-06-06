using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.PresentationLayer.ViewComponents.UIDefault
{
    public class _FiltreUIDefaultComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
