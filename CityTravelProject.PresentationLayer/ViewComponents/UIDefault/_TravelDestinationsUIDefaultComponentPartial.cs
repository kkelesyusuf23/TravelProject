using CityTravelProject.PresentationLayer.Dtos.TravelDestinationsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CityTravelProject.PresentationLayer.ViewComponents.UIDefault
{
    public class _TravelDestinationsUIDefaultComponentPartial:ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _TravelDestinationsUIDefaultComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7188/api/TravelDestinations");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTravelDestinationsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
