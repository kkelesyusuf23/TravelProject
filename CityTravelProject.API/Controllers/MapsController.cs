using CityTravelProject.BusinessLayer;
using CityTravelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CityTravelProject.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MapsController : ControllerBase
	{
		private readonly GoogleMapsService _googleMapsService;
        private readonly ILocationService _locationService;

        public MapsController(GoogleMapsService googleMapsService, ILocationService locationService)
        {
            _googleMapsService = googleMapsService;
            _locationService = locationService;
        }

        [HttpGet("geocode")]
		public async Task<IActionResult> GetGeocode([FromQuery] string address)
		{
			try
			{
				var result = await _googleMapsService.GetGeocodeAsync(address);
				return Ok(result);
			}
			catch (Exception ex)
			{
				return BadRequest(new { error = ex.Message });
			}
		}

        [HttpGet]
        public IActionResult GetLocations()
        {
			var locations = _locationService.TGetListAll();
            return Ok(locations);
        }
    }
}
