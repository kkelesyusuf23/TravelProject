using CityTravelProject.BusinessLayer.Abstract;
using CityTravelProject.DataAccessLayer.Abstract;
using CityTravelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.BusinessLayer.Concrete
{
    public class TravelDestinationsManager : ITravelDestinationsService
    {
        private readonly ITravelDestinationsDal _travelDestinationsDal;

        public TravelDestinationsManager(ITravelDestinationsDal travelDestinationsDal)
        {
            _travelDestinationsDal = travelDestinationsDal;
        }

        public void TAdd(TravelDestinations entity)
        {
            _travelDestinationsDal.Add(entity);
        }

        public void TDelete(TravelDestinations entity)
        {
            _travelDestinationsDal.Delete(entity);
        }

        public TravelDestinations TGetById(int id)
        {
            return _travelDestinationsDal.GetById(id);
        }

        public List<TravelDestinations> TGetListAll()
        {
            return _travelDestinationsDal.GetListAll();
        }

        public void TUpdate(TravelDestinations entity)
        {
            _travelDestinationsDal.Update(entity);
        }
    }
}
