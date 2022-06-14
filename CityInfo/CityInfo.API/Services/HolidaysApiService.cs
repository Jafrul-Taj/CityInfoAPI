using CityInfo.API.IRepository;
using CityInfo.API.IServices;
using CityInfo.API.Model;
using Microsoft.AspNetCore.Http;
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
        public JSonApiResult JsonReader(int id, List<IFormFile> formFiles)
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com/todos/1");
           
            var request_postMan = new RestRequest();
            request_postMan.Method = Method.Post;
            request_postMan.AddHeader("", "");
            request_postMan.AddQueryParameter("", "");
            var body = new { 
                formFiles
            };
            request_postMan.AddJsonBody(body); 

            var response_postMan = client.Execute<JSonApiResult>(request_postMan);
            return response_postMan.Data;


        }
    }
}
