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
    public class RouteDetailManager:IRouteDetailService
    {
        private readonly IRouteDetailDal _routeDetailDal;

        public RouteDetailManager(IRouteDetailDal routeDetailDal)
        {
            _routeDetailDal = routeDetailDal;
        }

        public void TAdd(RouteDetail entity)
        {
            _routeDetailDal.Add(entity);
        }

        public void TDelete(RouteDetail entity)
        {
            _routeDetailDal.Delete(entity);
        }

        public RouteDetail TGetById(int id)
        {
            return _routeDetailDal.GetById(id);
        }

        public List<RouteDetail> TGetListAll()
        {
            return _routeDetailDal.GetListAll();
        }

        public void TUpdate(RouteDetail entity)
        {
            _routeDetailDal.Update(entity);
        }
    }
}
