using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.DtoLayer.CityMapsDtos;
using CityTravelProject.DtoLayer.LocationDtos;
using CityTravelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityMapsController : ControllerBase
    {
        private readonly ICityMapsService _cityMapsService;

        public CityMapsController(ICityMapsService cityMapsService)
        {
            _cityMapsService = cityMapsService;
        }

        [HttpGet]
        public IActionResult CityMapsList()
        {
            var values = _cityMapsService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddCityMap(CreateContactsDto createCityMapsDto)
        {
            CityMaps cityMaps = new CityMaps()
            {
                City = createCityMapsDto.City,
                ImageURL = createCityMapsDto.ImageURL,
                Status = createCityMapsDto.Status,
            };
            _cityMapsService.TAdd(cityMaps);
            return Ok("Harita bilgisi başarılı bir şekilde eklenmiştir.");
        }

        [HttpDelete]
        public IActionResult DeleteCityMap(int id)
        {
            var value = _cityMapsService.TGetById(id);
            _cityMapsService.TDelete(value);
            return Ok("Harita bilgisi başarılı bir şekilde silinmiştir.");
        }

        [HttpGet("{id}")]
        public IActionResult GetCityMap(int id)
        {
            var value = _cityMapsService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateCityMap(UpdateCityMapDto updateCityMapDto)
        {
            CityMaps cityMaps = new CityMaps()
            {
                CityMapsID = updateCityMapDto.CityMapsID,
                City = updateCityMapDto.City,
                Status = updateCityMapDto.Status,
                ImageURL = updateCityMapDto.ImageURL,
            };
            _cityMapsService.TUpdate(cityMaps);
            return Ok("Güncelleme işlemi başarılı bir şekilde gerçekleştirilmiştir.");
        }
    }
}
