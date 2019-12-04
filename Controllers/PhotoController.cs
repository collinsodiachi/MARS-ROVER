using System;
using System.Linq;
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
           //Saving Photo
            foreach(var pp in photoList.Photos)
                await _marsRoverClient.GetPhoto(pp.Img_Src);

            return Ok(photoList);
        }
    }
}

