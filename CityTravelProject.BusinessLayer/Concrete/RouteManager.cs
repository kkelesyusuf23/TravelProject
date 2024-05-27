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

        public void TAdd(Route entity)
        {
            _routeDal.Add(entity);
        }

        public void TDelete(Route entity)
        {
            _routeDal.Delete(entity);
        }

        public Route TGetById(int id)
        {
            return _routeDal.GetById(id);
        }

        public List<Route> TGetListAll()
        {
            return _routeDal.GetListAll();
        }

        public void TUpdate(Route entity)
        {
            _routeDal.Update(entity);
        }
    }
}
