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
    public class ContactInformationManager : IContactInformationService
    {
        private readonly IContactInformationDal _contactInformationDal;

        public ContactInformationManager(IContactInformationDal contactInformationDal)
        {
            _contactInformationDal = contactInformationDal;
        }

        public void TAdd(ContactInformation entity)
        {
            _contactInformationDal.Add(entity);
        }

        public void TDelete(ContactInformation entity)
        {
            _contactInformationDal.Delete(entity);
        }

        public ContactInformation TGetById(int id)
        {
            return _contactInformationDal.GetById(id);
        }

        public List<ContactInformation> TGetListAll()
        {
            return _contactInformationDal.GetListAll();
        }

        public void TUpdate(ContactInformation entity)
        {
            _contactInformationDal.Update(entity);
        }
    }
}
