using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.DtoLayer.CityMapsDtos;
using CityTravelProject.DtoLayer.FutureDtos;
using CityTravelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FutureController : ControllerBase
    {
        private readonly IFutureService _futureService;

        public FutureController(IFutureService futureService)
        {
            _futureService = futureService;
        }

        [HttpGet]
        public IActionResult FutureList()
        {
            var values = _futureService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddFuture(CreateFutureDto createFutureDto)
        {
            Future future = new Future()
            {
                Title = createFutureDto.Title,
                Description = createFutureDto.Description,
                ImageURL = createFutureDto.ImageURL,
            };
            _futureService.TAdd(future);
            return Ok("Future bilgisi başarılı bir şekilde eklenmiştir.");
        }

        [HttpDelete]
        public IActionResult DeleteFuture(int id)
        {
            var value = _futureService.TGetById(id);
            _futureService.TDelete(value);
            return Ok("Future bilgisi başarılı bir şekilde silinmiştir.");
        }

        [HttpGet("{id}")]
        public IActionResult GetFuture(int id)
        {
            var value = _futureService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateFuture(UpdateFutureDto updateFutureDto)
        {
            Future future = new Future()
            {
                FutureID = updateFutureDto.FutureID,
                Title = updateFutureDto.Title,
                Description = updateFutureDto.Description,
                ImageURL = updateFutureDto.ImageURL,
                Status = updateFutureDto.Status,
            };
            _futureService.TUpdate(future);
            return Ok("Güncelleme işlemi başarılı bir şekilde gerçekleştirilmiştir.");
        }
    }
}
