using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;

using MARS_ROVER.MarsRoverClients;
using MARS_ROVER.Model;
using System.IO;

namespace MARS_ROVER.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarsRoverController: ControllerBase
    {
        private readonly MarsRoverHttpClient _marsRoverClient;
    
        public MarsRoverController(MarsRoverHttpClient marsRoverClient)
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


        [Route("~/api/GetAllPhoto")] 
        [HttpGet]
        public async Task<ActionResult<IList<Rover>>> GetPhotoList() 
        {  
            var photoList = await _marsRoverClient.GetPhotoList();
            return Ok(photoList);
        
        }

        
        // [Route("~/api/GetPhoto")] 
        // [HttpGet]
        // public async Task<Stream> GetPhoto(string url) 
        // {  
        //     var photo = await _marsRoverClient.GetPhoto(url);
        //     return photo;
        
        // }


        
    }
}