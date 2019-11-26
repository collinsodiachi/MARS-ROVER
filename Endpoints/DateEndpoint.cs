using System;
using System.Collections.Generic;
using MARS_ROVER.Services;


namespace MARS_ROVER.Endpoints
{
    public class DateEndpoint
    {
        private DateService dateService;

        public List<String> GetDates(){
            return dateService.GetDates();
        }
    }
}