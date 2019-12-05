using System;
using System.Collections.Generic;
using MARS_ROVER.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MARS_ROVER.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DateController: ControllerBase
    {
        private readonly ILogger _logger;

        public DateController(ILogger<DateController> logger){
            _logger = logger;
        }

        [Route("~/api/GetAllDate")] 
        [HttpGet]
        public  ActionResult<List<String>> GetAllDate()
        {
            DateService dateService = new DateService();

            List<String> dates = dateService.GetDates();

            _logger.LogInformation("All dates is returned from text file as they are");
            
            return Ok(dates);
        }
    }
}