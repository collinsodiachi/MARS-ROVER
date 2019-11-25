using System;
using System.Collections.Generic;
using MARS_ROVER_SOLUTION.Client;
using MARS_ROVER_SOLUTION.Model;

namespace MARS_ROVER_SOLUTION.Services
{
    public class PhotoService
    {
        private static string IMAGE_CACHE_PATH ="/temp/";

        MarsRoverClient marsRoverClient;

        public List<PhotoList> PhotoList(string name, string date) {
            //Just a placeholder
            List<PhotoList> photos = new List<PhotoList>();
            return photos;
        }
        public void GetPhoto(string url){ 
            Console.WriteLine("Expected to return image file");
        }
    }
}