using CityTravelProject.EntityLayer.Concrete;

namespace CityTravelProject.PresentationLayer.Dtos.RouteDtos
{
    public class ResultRouteDto
    {
        public int RoutesID { get; set; }
        //public int AppUserID { get; set; }
        //public AppUser AppUser { get; set; }
        public string RouteName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool Status { get; set; }
    }
}
