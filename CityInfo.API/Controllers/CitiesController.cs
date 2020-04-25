using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API;

namespace CityInfo.API.Controllers
{
    /// <summary>
    /// CitiesController
    /// </summary>
    [Route("api/cities")]
    //[Produces("application/json")]
    //[Produces("application/xml")]
    public class CitiesController : Controller
    {
        /// <summary>
        /// Get all cities
        /// </summary>
        /// <returns>Json format of all cities</returns>
        [HttpGet()]
        [Produces("application/xml")]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }
        /// <summary>
        /// Get specified city
        /// </summary>
        /// <param name="id">The unique id of the City you want to retrieve</param>
        /// <returns>CityDto instance</returns>
        [HttpGet("{id}")]
        //[Produces("application/json")]
        public IActionResult GetCity(int id)
        {
            Models.CityDto city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }

        /// <summary>
        /// Get values for city
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="description">description</param>
        /// <returns></returns>
        [HttpPost("{id}/{name}/{description}")]
        public IActionResult CreateCity(int id, string name, string description)
        {
            Models.CityDto theCity = new Models.CityDto();
            theCity.Id = id;
            theCity.Name = name;
            theCity.Description = description;

            return StatusCode(201, theCity);
        }
    }
}
