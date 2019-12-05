using System;
using System.Collections.Generic;
using MARS_ROVER.Services;
using Microsoft.AspNetCore.Mvc;

namespace MARS_ROVER.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DateController: ControllerBase
    {
        [Route("~/api/GetAllDate")] 
        [HttpGet]
        public  ActionResult<List<String>> GetAllDate()
        {
            DateService dateService = new DateService();

            List<String> dates = dateService.GetDates();
            
            return Ok(dates);
        }
    }
}