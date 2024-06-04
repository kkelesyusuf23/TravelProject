using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.DtoLayer.RouteDtos;
using CityTravelProject.EntityLayer.Concrete;
using CityTravelProject.PresentationLayer.Dtos.RouteDetailDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            var response = await client.GetAsync("https://localhost:7188/api/Maps");
            List<Location> locations = new List<Location>();
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                locations = JsonConvert.DeserializeObject<List<Location>>(jsonData);
            }
            return View(locations);
        }

        [HttpPost]
        public async Task<IActionResult> SaveRoute(List<Location> routeLocations)
        {
            List<ResultRouteDetailDto> routeDetails = new List<ResultRouteDetailDto>();
            foreach (var location in routeLocations)
            {
                routeDetails.Add(new ResultRouteDetailDto
                {
                    LocationID = location.LocationID,

                });
            }

            CreateRouteDto routeDto = new CreateRouteDto
            {
                RouteName = "Kullanıcı Rotası",
                Description = "Kullanıcı tarafından oluşturulan rota",
            };

            try
            {
                var client = _httpClientFactory.CreateClient();
                var json = JsonConvert.SerializeObject(routeDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:7188/api/Route/AddRoute", content);

                if (response.IsSuccessStatusCode)
                {
                    return Ok("Rota başarılı bir şekilde kaydedildi!");
                }
                else
                {
                    return BadRequest("Rota kaydedilirken hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Rota kaydedilirken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
