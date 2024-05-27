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
    public class RouteManager:IRouteService
    {
        private readonly IRouteDal _routeDal;

        public RouteManager(IRouteDal routeDal)
        {
            _routeDal = routeDal;
        }

        public void TAdd(Routes entity)
        {
            _routeDal.Add(entity);
        }

        public void TDelete(Routes entity)
        {
            _routeDal.Delete(entity);
        }

        public Routes TGetById(int id)
        {
            return _routeDal.GetById(id);
        }

        public List<Routes> TGetListAll()
        {
            return _routeDal.GetListAll();
        }

        public void TUpdate(Routes entity)
        {
            _routeDal.Update(entity);
        }
    }
}
