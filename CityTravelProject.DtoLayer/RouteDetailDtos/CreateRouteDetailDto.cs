using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.DtoLayer.RouteDetailDtos
{
    public class CreateRouteDetailDto
    {
        public int RoutesID { get; set; }
        public int LocationID { get; set; }
        public int Order { get; set; }

    }
}
