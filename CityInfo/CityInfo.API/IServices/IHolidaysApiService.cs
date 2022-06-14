using CityInfo.API.Entities;
using CityInfo.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.IServices
{
    public interface IHolidaysApiService
    {
        public JSonApiResult JsonReader(int id);
    }

    
}
