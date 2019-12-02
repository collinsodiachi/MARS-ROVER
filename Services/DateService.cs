using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MARS_ROVER.Model;
using Newtonsoft.Json;

namespace MARS_ROVER.Services
{
    public class DateService
    {
        private List<string> lines;
        string dateTxtFile = Path.GetFileName("Date.txt");
        public DateService()
        {
            lines = new List<string>();
        }
        // public async Task<List<Date>> GetDateFromFile(){
        //     string source = "";
        //     using (StreamReader sourceReader= new StreamReader(dateTxtFile)){
        //         source = await sourceReader.ReadToEndAsync();
                
        //     }
        //     return await Task.FromResult(JsonConvert.DeserializeObject<List<Date>>(source));
        // }
        public  List<String> GetAllDates() 
        {
            List<String> dates = File.ReadAllLines(dateTxtFile).ToList();
            return dates;
        }

       
        

        
    }
}