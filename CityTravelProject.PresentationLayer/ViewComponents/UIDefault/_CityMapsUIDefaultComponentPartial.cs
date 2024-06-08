using CityTravelProject.PresentationLayer.Dtos.CityMapsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CityTravelProject.PresentationLayer.ViewComponents.UIDefault
{
    public class _CityMapsUIDefaultComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _CityMapsUIDefaultComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7188/api/CityMaps");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCityMapsDto>>(jsonData);
                return View(values);
            }
            return View();
        }


        
    }
}
