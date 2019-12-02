using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using MARS_ROVER.MarsRoverClients;
using MARS_ROVER.Model;
using MARS_ROVER.Services;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace MARS_ROVER.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PhotoController: ControllerBase
    {
         private readonly IMarsRoverHttpClient _marsRoverClient;
         public PhotoController(IMarsRoverHttpClient marsRoverClient)
        {
            _marsRoverClient = marsRoverClient;
        }

        [Route("~/api/GetAllPhoto/{date}")] 
        [HttpGet]
        public async Task<ActionResult<PhotoList>> GetPhotoList(string date) 
        { 
            var photoList = await _marsRoverClient.GetPhotoList(date);
            return Ok(photoList);
        }

        // [Route("~/api/getphoto")] 
        // [HttpGet]
        // public async Task<IActionResult> GetPhoto() 
        // {  
        //     var photo = await _marsRoverClient.GetPhoto("http://mars.nasa.gov/mer/gallery/all/1/p/4037/1P486568465EFFCNJDP2407L2M1-BR.JPG");
        //     var image = System.IO.File.OpenRead(photo);
        //     return File(image, "image/jpeg");
        // }
    }
}

