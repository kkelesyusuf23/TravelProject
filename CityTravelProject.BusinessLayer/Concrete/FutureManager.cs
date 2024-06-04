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
    public class FutureManager : IFutureService
    {
        private readonly IFutureDal _futureDal;

        public FutureManager(IFutureDal futureDal)
        {
            _futureDal = futureDal;
        }

        public void TAdd(Future entity)
        {
            _futureDal.Add(entity);
        }

        public void TDelete(Future entity)
        {
            _futureDal.Delete(entity);
        }

        public Future TGetById(int id)
        {
            return _futureDal.GetById(id);  
        }

        public List<Future> TGetListAll()
        {
            return _futureDal.GetListAll();
        }

        public void TUpdate(Future entity)
        {
            _futureDal.Update(entity);
        }
    }
}
