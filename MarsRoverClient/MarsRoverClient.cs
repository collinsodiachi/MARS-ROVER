using System;
using System.Collections.Generic;
using System.Net.Http;

using System.Text.Json;
using System.Threading.Tasks;
using MARS_ROVER_SOLUTION.Model;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace MARS_ROVER_SOLUTION.Client
{
    public class MarsRoverClient
        {
        private static String REST_URI =  "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?earth_date=2015-6-3&api_key=";
        private static String API_KEY = "edLAgagb3KFP1QN4hIlZkMKvFGIjihEqZ89bAcFE";
        private static String API_KEY_PARAM_NAME = "api_key";
        private static String EARTH_DATE_PARAM_NAME = "earth_date";


        private readonly HttpClient _httpClient;
        
    
        public MarsRoverClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://api.nasa.gov/mars-photos/api/v1");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-NasaApi");
            _httpClient = httpClient;
        }



        public async Task<string> GetRoverList()
        {
           
            var queryString = $"https://api.nasa.gov/mars-photos/api/v1/rovers?earth_date=2015-6-3&api_key=edLAgagb3KFP1QN4hIlZkMKvFGIjihEqZ89bAcFE";
            var response =  await _httpClient.GetAsync(queryString);
            var content =  await response.Content.ReadAsStringAsync();
            return content;
        }

         public List<Photo> GetPhotoList(){
            List<Photo> photos= new List<Photo>();
            return photos;
        }

        public Photo GetPhoto(){
            Photo photo = new Photo();
            return photo;
        }
    }
}