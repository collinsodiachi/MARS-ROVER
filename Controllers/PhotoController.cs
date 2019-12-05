using System;
using System.Threading.Tasks;
using MARS_ROVER.MarsRoverClients;
using MARS_ROVER.Model;
using MARS_ROVER.Services;
using Microsoft.AspNetCore.Mvc;

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
            try{
                var photoList = await _marsRoverClient.GetPhotoList(date);

                foreach(var photo in photoList.Photos)
                _marsRoverClient.SavePhoto(photo.Img_Src);
                 return Ok(photoList);
            }
            catch
            {
                return Ok();
            }
        }
    }
}

