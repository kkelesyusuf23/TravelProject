using CityTravelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            try
            {
                var client = _httpClientFactory.CreateClient();
                var response = await client.GetAsync("https://localhost:7188/api/Location");

                if (response.IsSuccessStatusCode)
                {
                    var jsonData = await response.Content.ReadAsStringAsync();
                    var locations = JsonConvert.DeserializeObject<List<Location>>(jsonData);

                    var locationsJson = JsonConvert.SerializeObject(locations);
                    ViewBag.LocationsJson = locationsJson;

                    return View(locations);
                }
                else
                {
                    return BadRequest("Failed to retrieve locations from the API.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while fetching locations: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> SaveRoute([FromBody] List<Location> locations)
        {
            try
            {
                if (locations == null || !locations.Any())
                {
                    return BadRequest("No locations provided.");
                }

                var firstLocation = locations.FirstOrDefault();
                var lastLocation = locations.LastOrDefault();

                if (firstLocation == null || lastLocation == null)
                {
                    return BadRequest("Insufficient locations provided.");
                }

                var routeName = $"{firstLocation.Name}_{lastLocation.Name}";
                var routeDescription = $"{firstLocation.Latitude}_{firstLocation.Longitude}-{lastLocation.Latitude}_{lastLocation.Longitude}";

                var route = new Routes
                {
                    RouteName = routeName,
                    Description = routeDescription,
                    CreatedTime = DateTime.Now,
                    Status = true,
                };

                var client = _httpClientFactory.CreateClient();
                var jsonData = JsonConvert.SerializeObject(route);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7188/api/Route", content);

                if (!response.IsSuccessStatusCode)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    return StatusCode((int)response.StatusCode, errorContent);
                }

                

                return Ok("Route and RouteDetails saved successfully.");
            }
            catch (JsonException jsonEx)
            {
                return StatusCode(500, $"JSON Deserialization Error: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
