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
    public class CityMapsManager : ICityMapsService
    {
        private readonly ICityMapsDal _cityMapsDal;

        public CityMapsManager(ICityMapsDal cityMapsDal)
        {
            _cityMapsDal = cityMapsDal;
        }

        public void TAdd(CityMaps entity)
        {
            _cityMapsDal.Add(entity);
        }

        public void TDelete(CityMaps entity)
        {
            _cityMapsDal.Delete(entity);
        }

        public CityMaps TGetById(int id)
        {
            return _cityMapsDal.GetById(id);
        }

        public List<CityMaps> TGetListAll()
        {
            return _cityMapsDal.GetListAll();
        }

        public void TUpdate(CityMaps entity)
        {
            _cityMapsDal.Update(entity);
        }
    }
}
