using CityTravelProject.EntityLayer.Concrete;

namespace CityTravelProject.PresentationLayer.Dtos.RouteDetailDtos
{
    public class ResultRouteDetailDto
    {
        public int RouteDetailID { get; set; }
        public int RoutesID { get; set; }
        public int LocationID { get; set; }
        public int Order { get; set; }
        public bool Status { get; set; }
    }
}
