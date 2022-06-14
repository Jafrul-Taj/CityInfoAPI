using CityInfo.API.IRepository;
using CityInfo.API.IServices;
using CityInfo.API.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class HolidaysApiService : IHolidaysApiService
    {
        private readonly IHolidaysApiRepostory _holidaysApiRepostory;

        private  RestClient restClient; 
        public HolidaysApiService(IHolidaysApiRepostory holidaysApiRepostory)
        {
            _holidaysApiRepostory = holidaysApiRepostory;
        }
        public JSonApiResult JsonReader(int id)
        {
            restClient = new RestClient("https://jsonplaceholder.typicode.com");

            var request = new RestRequest("/todos/1");

            var response = restClient.Execute<JSonApiResult>(request);

           // return response.Data;
            //throw new NotImplementedException();

            var client = new RestClient("https://jsonplaceholder.typicode.com/todos/1");
           
            var request_postMan = new RestRequest();
            var response_postMan = client.Execute<JSonApiResult>(request_postMan);
            // Console.WriteLine(response.Content);
            return response_postMan.Data;
        }
    }
}
