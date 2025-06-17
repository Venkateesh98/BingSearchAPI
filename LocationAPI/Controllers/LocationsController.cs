using LocationsApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LocationAPI.Controllers
{
    [Route("api/locations")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly LocationRepository _repository = new();

        [HttpGet]
        public IActionResult GetAvailableLocations()
        {
            var availableLocations = _repository.GetAvailableLocations();
            if (availableLocations.Count == 0)
                return NotFound(new { message = "No locations available between 10 AM and 1 PM." });

            return Ok(availableLocations);
        }
    }
}