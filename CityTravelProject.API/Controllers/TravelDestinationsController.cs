using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.DtoLayer.FutureDtos;
using CityTravelProject.DtoLayer.TravelDestinationsDtos;
using CityTravelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelDestinationsController : ControllerBase
    {
        private readonly ITravelDestinationsService _travelDestinationsService;

        public TravelDestinationsController(ITravelDestinationsService travelDestinationsService)
        {
            _travelDestinationsService = travelDestinationsService;
        }

        [HttpGet]
        public IActionResult TravelDestinationsList()
        {
            var values = _travelDestinationsService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddTravelDestinations(CreateTravelDestinationsDto createTravelDestinationsDto)
        {
            TravelDestinations travelDestinations = new TravelDestinations()
            {
                Title = createTravelDestinationsDto.Title,
                Description = createTravelDestinationsDto.Description,
                ImageURL = createTravelDestinationsDto.ImageURL,
                Status = createTravelDestinationsDto.Status,
            };
            _travelDestinationsService.TAdd(travelDestinations);
            return Ok("Gezi bilgisi başarılı bir şekilde eklenmiştir.");
        }

        [HttpDelete]
        public IActionResult DeleteTravelDestinations(int id)
        {
            var value = _travelDestinationsService.TGetById(id);
            _travelDestinationsService.TDelete(value);
            return Ok("Gezi bilgisi başarılı bir şekilde silinmiştir.");
        }

        [HttpGet("{id}")]
        public IActionResult GetTravelDestinations(int id)
        {
            var value = _travelDestinationsService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateTravelDestinations(UpdateTravelDestinationsDto updateTravelDestinationsDto)
        {
            TravelDestinations travelDestinations = new TravelDestinations()
            {
                TravelDestinationsID = updateTravelDestinationsDto.TravelDestinationsID,
                Title = updateTravelDestinationsDto.Title,
                Description = updateTravelDestinationsDto.Description,
                ImageURL = updateTravelDestinationsDto.ImageURL,
                Status = updateTravelDestinationsDto.Status,
            };
            _travelDestinationsService.TUpdate(travelDestinations);
            return Ok("Güncelleme işlemi başarılı bir şekilde gerçekleştirilmiştir.");
        }
    }
}
