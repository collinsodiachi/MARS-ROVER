using System;
using MARS_ROVER.Services;


namespace MARS_ROVER.Endpoints
{
    public class PhotoEndpoint
    {
        private PhotoService photoService;

        public void GetMarsRoverPhotos(){
            Console.WriteLine("Expected to return a list of Photos");
        }

        public void GetImmgUrl(){
            Console.WriteLine("Expected to return image url");
        }
    }
}