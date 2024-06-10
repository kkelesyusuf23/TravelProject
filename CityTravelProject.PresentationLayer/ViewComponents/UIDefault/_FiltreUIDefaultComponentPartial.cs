using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CityTravelProject.PresentationLayer.ViewComponents.UIDefault
{
    public class FiltreUIDefaultComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            await Task.CompletedTask;
            return View();
        }
    }
}
