using CityTravelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.DataAccessLayer.Concrete
{
    public class TravelContext:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YUSUF; initial catalog=DBTravel;integrated security=true;");
        }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<RouteDetail> RouteDetails { get; set; }

    }
}
