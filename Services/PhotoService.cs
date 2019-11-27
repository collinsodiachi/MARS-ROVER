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
        private readonly MarsRoverHttpClient _marsRoverClient;
        
        private static string IMAGE_CACHE_PATH = Path.GetTempPath(); 

        public Task<PhotoList> GetPhotoList() 
        {
            return _marsRoverClient.GetPhotoList();
        }
        public void GetPhoto(string url){ 
            
            //create a sha
            //gets the folder path and appends sha to it
            //creates a file variable: File image
            //Looks for file in image cache first
            //If file is not found then get it from API
        }
        
    }
}