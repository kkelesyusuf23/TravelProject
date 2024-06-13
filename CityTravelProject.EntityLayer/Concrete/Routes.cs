using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.EntityLayer.Concrete
{
    public class Routes
    {
        public int RoutesID { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public string RouteName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool Status { get; set; }
        public List<RouteDetail> RouteDetails { get; set; }

    }
}
