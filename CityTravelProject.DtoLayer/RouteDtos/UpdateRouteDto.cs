using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.DtoLayer.RouteDtos
{
    public class UpdateRouteDto
    {
        public int RoutesID { get; set; }
        public string RouteName { get; set; }
        public string Description { get; set; }
    }
}
