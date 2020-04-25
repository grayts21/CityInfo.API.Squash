using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    /// <summary>
    /// CityDto Class containing all the city information
    /// </summary>
    public class CityDto
    {
        /// <summary>
        /// The integer Id of the city
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// The Name of the City
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// The description of the city
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// The Calculated number of interest points for the City
        /// </summary>
        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }

        /// <summary>
        /// Points of Interest for City List
        /// </summary>
        public ICollection<PointsOfInterestDto> PointsOfInterest { get; set; }
        = new List<PointsOfInterestDto>();
    }
}
