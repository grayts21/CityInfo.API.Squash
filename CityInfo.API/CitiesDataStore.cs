using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Models;

namespace CityInfo.API
{
    /// <summary>
    /// Cities Data Store Class
    /// To be replaced with real database at some time.
    /// </summary>
    public class CitiesDataStore
    {
        /// <summary>
        /// Used to get the members of the database store
        /// </summary>
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        /// <summary>
        /// Should not really be public, local list of cities
        /// </summary>
        public List<CityDto> Cities { get; set; }
        /// <summary>
        /// Data Store
        /// </summary>
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto
                {
                    Id          = 1,
                    Name        = "New York City",
                    Description = "Big master City",
                    PointsOfInterest = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto
                        {
                            Id = 10,
                            Name = "Statin Island",
                            Description = "an island in statin"
                        },
                        new PointsOfInterestDto
                        {
                            Id = 11,
                            Name = "empire state building",
                            Description = "No as tall"
                        }


                    }
                },
                new CityDto
                {
                    Id = 2,
                    Name = "Colorado Springs",
                    Description = "High City"
                },
                new CityDto
                {
                    Id = 3,
                    Name = "London",
                    Description = "Old City"
                },
                new CityDto
                {
                    Id = 4,
                    Name = "Chicago",
                    Description = "Windy City"
                }
            };
        }
    }
}
