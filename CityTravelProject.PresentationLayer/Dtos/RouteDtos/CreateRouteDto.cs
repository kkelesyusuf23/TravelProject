using CityTravelProject.EntityLayer.Concrete;

namespace CityTravelProject.PresentationLayer.Dtos.RouteDtos
{
    public class CreateRouteDto
    {
        public string RouteName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
