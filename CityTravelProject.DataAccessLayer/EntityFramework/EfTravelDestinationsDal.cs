using CityTravelProject.DataAccessLayer.Abstract;
using CityTravelProject.DataAccessLayer.Concrete;
using CityTravelProject.DataAccessLayer.Repositories;
using CityTravelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.DataAccessLayer.EntityFramework
{
    public class EfTravelDestinationsDal : GenericRepository<TravelDestinations>, ITravelDestinationsDal
    {
        public EfTravelDestinationsDal(TravelContext context) : base(context)
        {
        }
    }
}
