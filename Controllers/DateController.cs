using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MARS_ROVER.Model;
using MARS_ROVER.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MARS_ROVER.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DateController: ControllerBase
    {
        [Route("~/api/GetAllDate")] 
        [HttpGet]
        public  ActionResult<List<String>> GetAllDate(){
            DateService dateService = new DateService();
            List<String> dates = dateService.GetDates();
            // var AllDatesFromTextFile = dateService.GetAllDates();
            // foreach(string date in AllDatesFromTextFile)
            //     dates.Add(dateService.ParseDates(date)); 
            return Ok(dates);
        }
    }
}