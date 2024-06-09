using CityTravelProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CityTravelProject.PresentationLayer.Controllers
{
    public class UIDefaultController : Controller
    {
        public async Task<IActionResult> Index(DateTime CheckIn, DateTime CheckOut)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com18.p.rapidapi.com/stays/search?locationId=eyJjaXR5X25hbWUiOiIiLCJjb3VudHJ5IjoiVHVya2V5IiwiZGVzdF9pZCI6IjIxNSIsImRlc3RfdHlwZSI6ImNvdW50cnkifQ%3D%3D&checkinDate={CheckIn}&checkoutDate={CheckOut}&units=metric&temperature=c&languageCode=tr-tr"),
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
                return View(body.ToList());
            }
        }
    }
}