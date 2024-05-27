using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.DtoLayer.RouteDetailDtos;
using CityTravelProject.DtoLayer.RouteDtos;
using CityTravelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityTravelProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouteDetailController : ControllerBase
    {
        private readonly IRouteDetailService _routeDetailService;

        public RouteDetailController(IRouteDetailService routeDetailService)
        {
            _routeDetailService = routeDetailService;
        }

        [HttpGet]
        public IActionResult RouteDetailList()
        {
            var values = _routeDetailService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRouteDetail(CreateRouteDetailDto createRouteDetailDto)
        {
            RouteDetail routeDetail = new RouteDetail()
            {
                RoutesID = createRouteDetailDto.RoutesID,
                LocationID = createRouteDetailDto.LocationID,
                Status = true,
                Order = createRouteDetailDto.Order,
            };
            _routeDetailService.TAdd(routeDetail);
            return Ok("Rota Detay bilgisi başarılı bir şekilde eklenmiştir.");
        }
        [HttpDelete]
        public IActionResult DeleteRouteDetail(int id)
        {
            var value = _routeDetailService.TGetById(id);
            _routeDetailService.TDelete(value);
            return Ok("Rota Detay bilgisi başarılı bir şekilde silinmiştir");
        }
        [HttpGet("{id}")]
        public IActionResult GetRouteDetail(int id)
        {
            var value = _routeDetailService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateRoute(UpdateRouteDetailDto updateRouteDetailDto)
        {
            RouteDetail route = new RouteDetail()
            {
                RouteDetailID = updateRouteDetailDto.RouteDetailID,
                LocationID=updateRouteDetailDto.LocationID,
                RoutesID=updateRouteDetailDto.RoutesID,
                Status = updateRouteDetailDto.Status,
                Order = updateRouteDetailDto.Order,
            };
            _routeDetailService.TUpdate(route);
            return Ok("Rota Detay bilgisi başarılı bir şekilde güncellenmiştir.");
        }
    }
}
