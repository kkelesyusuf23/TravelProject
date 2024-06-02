using CityTravelProject.DataAccessLayer.Abstract;
using CityTravelProject.DataAccessLayer.Concrete;
using CityTravelProject.DataAccessLayer.Repositories;
using CityTravelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.DataAccessLayer.EntityFramework
{
    public class EfLocationDal : GenericRepository<Location>, ILocationDal
    {
        public EfLocationDal(TravelContext context) : base(context)
        {
        }

        //public List<Location> GetAllLocationWithUser()
        //{
        //    var context = new TravelContext();
        //    var valeus = context.Locations.Include(x => x.AppUser).ToList();
        //    return valeus;
        //}
    }
}
