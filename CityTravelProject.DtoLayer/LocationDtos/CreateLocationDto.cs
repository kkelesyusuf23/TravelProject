using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.DtoLayer.LocationDtos
{
    public class CreateLocationDto
    {
        //public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string PhotoURL { get; set; }
    }
}
