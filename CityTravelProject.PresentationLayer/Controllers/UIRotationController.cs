using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.DtoLayer.RouteDtos;
using CityTravelProject.EntityLayer.Concrete;
using CityTravelProject.PresentationLayer.Dtos.RouteDetailDtos;
using CityTravelProject.PresentationLayer.Dtos.RouteDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
            var response = await client.GetAsync("https://localhost:7188/api/Location");
            List<Location> locations = new List<Location>();
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                locations = JsonConvert.DeserializeObject<List<Location>>(jsonData);
            }

            var locationsJson = JsonConvert.SerializeObject(locations);

            ViewBag.LocationsJson = locationsJson;

            return View(locations);
        }

        [HttpPost]
        public async Task<IActionResult> SaveRoute([FromBody] List<Location> locations)
        {
            if (locations == null || !locations.Any())
            {
                return BadRequest("No locations provided.");
            }

            try
            {
                var firstLocation = locations.FirstOrDefault();
                var lastLocation = locations.LastOrDefault();

                if (firstLocation == null || lastLocation == null)
                {
                    return BadRequest("Insufficient locations provided.");
                }

                var routeName = $"{firstLocation.Name}{firstLocation.Latitude}_{firstLocation.Longitude}-" +
                                $"{lastLocation.Name}{lastLocation.Latitude}_{lastLocation.Longitude}";

                var route = new Routes
                {
                    RouteName = routeName,
                    Description = "",
                    CreatedTime = DateTime.Now,
                    Status = true,
                };

                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(route);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7188/api/Route", content);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                return StatusCode((int)response.StatusCode, errorContent);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
