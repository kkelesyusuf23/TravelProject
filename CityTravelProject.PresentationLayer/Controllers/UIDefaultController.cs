using CityTravelProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CityTravelProject.PresentationLayer.Controllers
{
    public class UIDefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Return the initial view with an empty model
            return View(new List<GetHotelsViewModel.Datum>());
        }

        [HttpPost]
        public async Task<IActionResult> Index(DateTime checkinDate, DateTime checkoutDate)
        {
            if (checkinDate == default(DateTime) || checkoutDate == default(DateTime))
            {
                checkinDate = DateTime.Now;
                checkoutDate = checkinDate.AddDays(7);
            }

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com18.p.rapidapi.com/stays/search?locationId=eyJjaXR5X25hbWUiOiIiLCJjb3VudHJ5IjoiVHVya2V5IiwiZGVzdF9pZCI6IjIxNSIsImRlc3RfdHlwZSI6ImNvdW50cnkifQ%3D%3D&checkinDate={checkinDate:yyyy-MM-dd}&checkoutDate={checkoutDate:yyyy-MM-dd}&units=metric&temperature=c&languageCode=tr-tr"),
                Headers =
                {
                    { "x-rapidapi-key", "4de8241237msh5faa3d451873343p132993jsnec7cab1c5af4" },
                    { "x-rapidapi-host", "booking-com18.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var hotels = JsonConvert.DeserializeObject<GetHotelsViewModel.Rootobject>(body);
                var hotelList = new List<GetHotelsViewModel.Datum>(hotels.data);
                return View(hotelList);
            }
        }
    }
}
