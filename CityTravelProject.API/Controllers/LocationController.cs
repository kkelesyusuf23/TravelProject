using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.DtoLayer.LocationDtos;
using CityTravelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {

        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]   
        public IActionResult LocationList()
        {
            var values = _locationService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddLocation(CreateLocationDto createLocationDto)
        {
            Location location = new Location()
            {
                //AppUserId = 1,
                Name = createLocationDto.Name,
                Description = createLocationDto.Description,
                Latitude = createLocationDto.Latitude,
                Longitude = createLocationDto.Longitude,
                PhotoURL = createLocationDto.PhotoURL,
                Status = true
            };
            _locationService.TAdd(location);
            return Ok("Lokasyon bilgisi başarılı bir şekilde eklenmiştir.");
        }

        [HttpDelete]
        public IActionResult DeleteLocation(int id)
        {
            var value = _locationService.TGetById(id);
            _locationService.TDelete(value);
            return Ok("Lokasyon bilgisi başarılı bir şekilde silinmiştir.");
        }

        [HttpGet("{id}")]
        public IActionResult GetLocation(int id)
        {
            var value = _locationService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateLocation(UpdateLocationDto updateLocationDto)
        {
            Location location = new Location()
            {
                LocationID = updateLocationDto.LocationID,
                //AppUserId = 1,
                Name = updateLocationDto.Name,
                Description = updateLocationDto.Description,
                Latitude = updateLocationDto.Latitude,
                Longitude = updateLocationDto.Longitude,
                PhotoURL = updateLocationDto.PhotoURL,
                Status = updateLocationDto.Status
            };
            _locationService.TUpdate(location);
            return Ok("Güncelleme işlemi başarılı bir şekilde gerçekleştirilmiştir.");
        }

        //[HttpGet("GetAllLocationWithUser")]
        //public IActionResult GetDrinkAveragePrice()
        //{
        //    return Ok(_locationService.TGetAllLocationWithUser());
        //}
    }
}
