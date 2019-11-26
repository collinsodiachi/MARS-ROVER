using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MARS_ROVER.MarsRoverClients;
using MARS_ROVER.Model;


namespace MARS_ROVER.Services
{
    public class PhotoService
    {
        private static string IMAGE_CACHE_PATH ="/temp/";

        MarsRoverHttpClient marsRoverClient;

        public Task<PhotoList> GetPhotoList(string name, string date) {
            //Just a placeholder
            return marsRoverClient.GetPhotoList();
        }
        // public void GetPhoto(string url){ 
        //     //create a sha
        //     //gets the folder path and appends sha to it
        //     //creates a file variable: File image
        //     //Looks for file in image cache first
        //     //If file is not found then get it from API
        // }
        
    }
}