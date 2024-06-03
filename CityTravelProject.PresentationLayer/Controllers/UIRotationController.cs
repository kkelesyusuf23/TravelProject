using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using CityTravelProject.EntityLayer.Concrete;

namespace CityTravelProject.PresentationLayer.Controllers
{
    public class UIRotationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UIRotationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7188/api/Maps");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var locations = JsonConvert.DeserializeObject<List<Location>>(jsonData);
                ViewBag.Locations = locations;
                return View(locations);
            }
            else
            {
                ViewBag.Locations = new List<Location>();
            }
            return View();
        }
    }
}
