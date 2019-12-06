using System.Threading.Tasks;
using MARS_ROVER.MarsRoverClients;
using MARS_ROVER.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MARS_ROVER.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PhotoController: ControllerBase
    {
        private readonly IMarsRoverHttpClient _marsRoverClient;
        private readonly ILogger _logger;
        public PhotoController(IMarsRoverHttpClient marsRoverClient, ILogger<PhotoController> logger)
        {
            _marsRoverClient = marsRoverClient;
            _logger = logger;
        }

        [Route("~/api/rover-photos/{date}")] 
        [HttpGet]
        public async Task<ActionResult<PhotoList>> GetPhotoList(string date) 
        { 
            try{
                var photoList = await _marsRoverClient.GetPhotoList(date);
                _logger.LogInformation("Photo list is returned successful from API");
                
                foreach(var photo in photoList.Photos)
                    _marsRoverClient.SavePhoto(photo.Img_Src);
                    _logger.LogInformation("Photo is saved and sent to view");

                if(photoList == null)
                    return NotFound();
                return Ok(photoList);
            }
            catch
            {
                _logger.LogInformation("An invalid date formate was given");
                return BadRequest();
            }
        }
    }
}

