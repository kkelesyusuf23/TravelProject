using CityTravelProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CityTravelProject.PresentationLayer.ViewComponents.UIDefault
{
    public class _FiltreUIDefaultComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> Invoke()
        {
            return View();
        }
    }
}
