using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// test
namespace CityInfo.API.Models
{
    public class PointsOfInterestForCreationDto
    {
        /// <summary>
        /// The Name of the City
        /// </summary>
        [Required(ErrorMessage = "The POI name was not specified")]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the city
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

    }
}
