using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.DtoLayer.RouteDtos;
using CityTravelProject.EntityLayer.Concrete;
using CityTravelProject.PresentationLayer.Dtos.RouteDetailDtos;
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

            // Serialize the locations list to JSON
            var locationsJson = JsonConvert.SerializeObject(locations);

            // Pass the serialized JSON to the view using ViewBag
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
                var firstLocation = locations.First();
                var lastLocation = locations.Last();
                var routeName = $"{firstLocation.Name}{firstLocation.Latitude}_{firstLocation.Longitude}-" +
                                $"{lastLocation.Name}{lastLocation.Latitude}_{lastLocation.Longitude}";

                var route = new Routes
                {
                    RouteName = routeName,
                    Description = string.Empty,
                    CreatedTime = DateTime.Now,
                    Status = true,
                    RouteDetails = locations.Select((location, index) => new RouteDetail
                    {
                        LocationID = location.LocationID,
                        Order = index + 1,
                        Status = true
                    }).ToList()
                };

                // Save the route and route details to the database
                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(route);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7188/api/Routes", content);

                if (response.IsSuccessStatusCode)
                {
                    return Ok();
                }

                var errorContent = await response.Content.ReadAsStringAsync();
                return StatusCode((int)response.StatusCode, errorContent);
            }
            catch (Exception ex)
            {
                // Log the exception (ex) for further analysis
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
