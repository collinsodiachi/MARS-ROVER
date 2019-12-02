using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using MARS_ROVER.MarsRoverClients;
using MARS_ROVER.Model;
using System.Net.Http;


namespace MARS_ROVER.Services
{
    public class PhotoService
    {
        private readonly IMarsRoverHttpClient _marsRoverClient;
        
        private static string IMAGE_CACHE_PATH = Path.GetTempPath(); 

        public Task<PhotoList> GetPhotoList(String date) 
        {
            return _marsRoverClient.GetPhotoList(date);
        }
        public void GetPhoto(){ 
            Console.WriteLine("Hello from services");
            //create a sha
            //gets the folder path and appends sha to it
            //creates a file variable: File image
            //Looks for file in image cache first
            //If file is not found then get it from API
        }
        
    }
}