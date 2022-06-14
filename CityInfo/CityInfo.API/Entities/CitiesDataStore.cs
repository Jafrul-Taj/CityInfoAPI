using CityInfo.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Entities
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public CitiesDataStore()
        {
            Cities = new List<cityDto>()
            {
                new cityDto()
                {
                    Id=1,
                    Name = "New York City",
                    Description = "The one with the big park."
                },
                new cityDto()
                {
                    Id=2,
                    Name = "Antwerp",
                    Description = "The one with cathadral that was never really finished."
                },
                new cityDto()
                {
                    Id=3,
                    Name = "Paris",
                    Description = "The one with the big tower."
                },
            };
        }
        public List<cityDto> Cities { get; set; }
    }
}
