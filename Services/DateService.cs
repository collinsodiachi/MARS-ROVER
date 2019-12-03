using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MARS_ROVER.Model;
using Newtonsoft.Json;

namespace MARS_ROVER.Services
{
    public class DateService
    {
        string dateTxtFile = Path.GetFileName("Date.txt");
        public  List<String> GetAllDates() 
        {
            List<String> dates = File.ReadAllLines(dateTxtFile).ToList();
            return dates;
        }
        public  String ParseDates(String date) 

        {
            
            string[] pattern = {"MM/dd/yy","MMMM d, yyyy","MMM-dd-yyyy","MMMM dd, yyyy"};
            var newDate= DateTime.ParseExact(date, pattern, CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            return newDate;
        }
    }
}

 