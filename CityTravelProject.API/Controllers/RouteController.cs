using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.DtoLayer.RouteDtos;
using CityTravelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private readonly IRouteService _routeService;

        public RouteController(IRouteService routeService)
        {
            _routeService = routeService;
        }
        [HttpGet]
        public IActionResult RouteList()
        {
            var values = _routeService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoute(CreateRouteDto createRouteDto)
        {
            Routes route = new Routes()
            {
                RouteName = createRouteDto.RouteName,
                Description = createRouteDto.Description,
                CreatedTime = DateTime.Now,
                Status = true
            };
            _routeService.TAdd(route);
            return Ok("Rota bilgisi başarılı bir şekilde eklenmiştir.");
        }
        [HttpDelete]
        public IActionResult DeleteRoute(int id)
        {
            var value = _routeService.TGetById(id);
            _routeService.TDelete(value);
            return Ok("Rota bilgisi başarılı bir şekilde silinmiştir");
        }
        [HttpGet("{id}")]
        public IActionResult GetRoute(int id)
        {
            var value = _routeService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateRoute(UpdateRouteDto updateRouteDto)
        {
            Routes route = new Routes()
            {
                RoutesID = updateRouteDto.RoutesID,
                RouteName = updateRouteDto.RouteName,
                Description = updateRouteDto.Description,
                Status = updateRouteDto.Status
            };
            _routeService.TUpdate(route);
            return Ok("Rota bilgisi başarılı bir şekilde güncellenmiştir.");
        }
    }
}
