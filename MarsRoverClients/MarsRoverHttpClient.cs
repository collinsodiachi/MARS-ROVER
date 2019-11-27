using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using MARS_ROVER.Model;

namespace MARS_ROVER.MarsRoverClients
{
   
    public class MarsRoverHttpClient
    {
        private static String REST_URI =  "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?earth_date=2015-6-3&api_key=";
        private static String API_KEY = "edLAgagb3KFP1QN4hIlZkMKvFGIjihEqZ89bAcFE";
        private static String API_KEY_PARAM_NAME = "api_key";
        private static String EARTH_DATE_PARAM_NAME = "earth_date";


        private readonly HttpClient _httpClient;
        
    
        public MarsRoverHttpClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://api.nasa.gov/mars-photos/api/v1");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-NasaApi");
            _httpClient = httpClient;
        }



        public async Task<RoverList> GetRoverList()
        {
        
            var queryString = $"https://api.nasa.gov/mars-photos/api/v1/rovers?earth_date=2015-6-3&api_key=edLAgagb3KFP1QN4hIlZkMKvFGIjihEqZ89bAcFE";
        
            var request = new HttpRequestMessage(HttpMethod.Get, queryString);

            var response =  await _httpClient.SendAsync(request);

            return response.IsSuccessStatusCode
            ? await response.Content.ReadAsAsync<RoverList>()
            : null;
        }

        //add this arg to methode later string name, string date
        public async Task<PhotoList> GetPhotoList()
        {
            var queryString = $"https://api.nasa.gov/mars-photos/api/v1/rovers/opportunity/photos?earth_date=2015-6-3&api_key=edLAgagb3KFP1QN4hIlZkMKvFGIjihEqZ89bAcFE";
            var request = new HttpRequestMessage(HttpMethod.Get, queryString);

            var response =  await _httpClient.SendAsync(request);

            return response.IsSuccessStatusCode
            ? await response.Content.ReadAsAsync<PhotoList>()
            : null;
        }

       

        // public async Task<Stream> GetPhoto(string url){

        //     var queryString = $"https://api.nasa.gov/mars-photos/api/v1/rovers/opportunity/photos?earth_date=2015-6-3&api_key=edLAgagb3KFP1QN4hIlZkMKvFGIjihEqZ89bAcFE";

        //     var request = new HttpRequestMessage(HttpMethod.Get, queryString);

        //     var response =  await _httpClient.SendAsync(request);


        //     Stream contentStream = await response.Content.ReadAsStreamAsync();

        //     var stream = new FileStream(url, FileMode.Open);

        //         await contentStream.CopyToAsync(stream);
        //     return contentStream;

        // }
    }
}


