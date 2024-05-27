using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.EntityLayer.Concrete
{
    public class RouteDetail
    {
        public int RouteDetailID { get; set; }
        public int RouteID { get; set; }
        public Route Route { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
        public int Order { get; set; }
        public bool Status { get; set; }
    }
}
