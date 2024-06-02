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
    public class LocationManager:ILocationService
    {
        private readonly ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public void TAdd(Location entity)
        {
            _locationDal.Add(entity);
        }

        public void TDelete(Location entity)
        {
            _locationDal.Delete(entity);
        }

        //public List<Location> TGetAllLocationWithUser()
        //{
        //    return _locationDal.GetAllLocationWithUser();
        //}

        public Location TGetById(int id)
        {
            return _locationDal.GetById(id);
        }

        public List<Location> TGetListAll()
        {
            return _locationDal.GetListAll();
        }

        public void TUpdate(Location entity)
        {
            _locationDal.Update(entity);
        }
    }
}
