using CityInfo.API.Entities;
using CityInfo.API.IServices;
using CityInfo.API.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        private readonly IHolidaysApiService _holidaysApiService;
        public CitiesController(IHolidaysApiService HolidaysApiService)
        {
            _holidaysApiService = HolidaysApiService;
        }
        [HttpGet()]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public JsonResult GetCity(int id)
        {
            return new JsonResult(CitiesDataStore.Current.Cities.Where(city=>city.Id==id).FirstOrDefault<cityDto>());
        }

        [HttpGet("Json/{id}")]
        public IActionResult Index(int id )
        {
            var jsonResult= _holidaysApiService.JsonReader(id);
            return Ok(jsonResult);
        }
    }
}
