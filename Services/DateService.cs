using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;


namespace MARS_ROVER.Services
{
    public class DateService
    {
        string dateInTextFile = Path.GetFileName("Date.txt");
        string[] pattern = {"MM/dd/yy","MMMM d, yyyy","MMM-dd-yyyy","MMMM dd, yyyy"};
        List<String> dates;
        public DateService()
        {
            dates = new List<String>();
        }

        public  List<String> AllDatesInTextFile() 
        {
            List<String> datesFromTextFile = File.ReadAllLines(dateInTextFile).ToList();
            return datesFromTextFile;
        }
       
       public  String ParseDates(String date) 
        {
        
           string newDate;
            try
            {
                newDate= DateTime.ParseExact(date, pattern, CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            }
            catch
            {
                
                return date;
                
            }
            
            return newDate;
        }
        public List<string> GetDates(){

            string  newDate;
            var dates = AllDatesInTextFile();
           
            foreach(var date in dates){
                newDate= ParseDates(date);
                this.dates.Add(newDate);
            }
                
            return this.dates;
        }
    }
}

 