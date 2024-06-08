using CityTravelProject.PresentationLayer.Dtos.FutureDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CityTravelProject.PresentationLayer.ViewComponents.UIDefault
{
    public class _SliderUIDefaultComponentPartial:ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _SliderUIDefaultComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7188/api/Future");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFutureDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
