using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.EntityLayer.Concrete
{
    public class CityMaps
    {
        public int CityMapsID { get; set; }
        public string City { get; set; }
        public string ImageURL { get; set; }
        public bool Status { get; set; }
    }
}
