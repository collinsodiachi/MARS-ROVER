using System;
using System.Collections.Generic;

namespace MARS_ROVER.Services
{
    public class DateService
    {
        private List<String> dateList;
        public DateService()
        {
            this.dateList = new List<string>();
        }
        public List<string> GetDates() 
        {
            return dateList;
        }

         public void InitialiseDate()
        {
            Console.WriteLine("Date is being Initialised...");
        }
    }
}