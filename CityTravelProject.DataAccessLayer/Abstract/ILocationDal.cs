﻿using CityTravelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTravelProject.DataAccessLayer.Abstract
{
    public interface ILocationDal:IGenericDal<Location>
    {
        //public List<Location> GetAllLocationWithUser();

    }
}
