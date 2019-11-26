using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MARS_ROVER.MarsRoverClients;
using MARS_ROVER.Model;

namespace MARS_ROVER.Services
{
    public class RoverService
    {
        MarsRoverHttpClient _marsRoverClient;
        public Task<RoverList> GetRoverList (){
            return _marsRoverClient.GetRoverList();
        }
    }
}