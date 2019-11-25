using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using MARS_ROVER_SOLUTION.Client;
using MARS_ROVER_SOLUTION.Model;

namespace MARS_ROVER_SOLUTION.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarsRoverController: ControllerBase
    {
        private readonly MarsRoverClient _marsRoverClient;
    
        public MarsRoverController(MarsRoverClient marsRoverClient)
        {
            _marsRoverClient = marsRoverClient;
        }
        [Route("~/api/GetAllRover")] 
        [HttpGet]
        public async Task<ActionResult<IList<Rover>>> GetRoverList() 
        {  
            var roverList = await _marsRoverClient.GetRoverList();
            return Ok(roverList);
        
        }
       
        
    }
}