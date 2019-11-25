using System.Collections.Generic;
using MARS_ROVER_SOLUTION.Model;
using MARS_ROVER_SOLUTION.Services;

namespace MARS_ROVER_SOLUTION.Endpoints
{
    public class RoverEndpoint
    {
        RoverService roverService;

        public List<RoverList> GetRovers(){
            return roverService.GetRoverList();
        }
    }
}