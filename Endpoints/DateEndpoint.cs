using System;
using System.Collections.Generic;
using MARS_ROVER_SOLUTION.Services;

namespace MARS_ROVER_SOLUTION.Endpoints
{
    public class DateEndpoint
    {
        private DateService dateService;

        public List<String> GetDates(){
            return dateService.GetDates();
        }
    }
}