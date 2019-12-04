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
            string sDateTime;
            bool valid = true;
            try{
                newDate= DateTime.ParseExact(date, pattern, CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                
            }
            catch
            {
                // String[] sDate = date.Split(' ');
                // sDateTime = sDate[1] + '/' + sDate[0] + '/' + sDate[2];
                // newDate = Convert.ToDateTime(sDateTime).ToString("yyyy-MM-dd");
                valid = false;
                throw new Exception("invalid format" + date);
            }
            return newDate;
        }
        public List<string> GetDates(){
            var dates = AllDatesInTextFile();
            string  newDate;
            foreach(var date in dates){
                newDate= ParseDates(date);
                this.dates.Add(newDate);
            }
                
            return this.dates;
        }
    }
}

 