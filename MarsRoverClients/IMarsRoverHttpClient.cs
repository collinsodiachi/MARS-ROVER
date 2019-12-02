using System;
using System.Threading.Tasks;
using MARS_ROVER.Model;
using System.IO;

namespace MARS_ROVER.MarsRoverClients
{
    public interface IMarsRoverHttpClient
    {
         Task<PhotoList> GetPhotoList(String date);
         Task<RoverList> GetRoverList();
        //  Task<FileStream> GetPhoto(String url);
        
    }
}