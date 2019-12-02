using System.Collections.Generic;
using System.Threading.Tasks;
using MARS_ROVER.MarsRoverClients;
using MARS_ROVER.Model;
using Microsoft.AspNetCore.Mvc;

namespace MARS_ROVER.Controllers
{
    public class RoverController: ControllerBase
    {
         private readonly IMarsRoverHttpClient _marsRoverClient;
         public RoverController(IMarsRoverHttpClient marsRoverClient)
        {
            _marsRoverClient = marsRoverClient;
        }

        [Route("~/api/GetAllRover")] 
        [HttpGet]
        public async Task<ActionResult<RoverList>> GetRoverList() 
        {  
            var roverList = await _marsRoverClient.GetRoverList();
            return Ok(roverList);
        }

    }
}