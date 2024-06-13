using CityTravelProject.EntityLayer.Concrete;

namespace CityTravelProject.PresentationLayer.Dtos.RouteDtos
{
    public class CreateRouteDto
    {
        public int AppUserID { get; set; }
        public string RouteName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
