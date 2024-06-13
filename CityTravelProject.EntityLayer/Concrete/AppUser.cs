using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public DateTime BirthDay { get; set; }
        public List<Routes> Routes { get; set; }
        //public List<Location> Locations { get; set; }
    }
}
