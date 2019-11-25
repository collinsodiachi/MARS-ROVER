using System;
using System.Collections.Generic;
using MARS_ROVER_SOLUTION.Client;
using MARS_ROVER_SOLUTION.Model;

namespace MARS_ROVER_SOLUTION.Services
{
    public class RoverService
    {
        MarsRoverClient marsRoverClient;
        public List<RoverList> GetRoverList (){
            Console.WriteLine("Expected to return a photolist");
            List<RoverList> rovers = new List<RoverList>();
            return rovers;
         }
    }
}