using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using MARS_ROVER.Model;


namespace MARS_ROVER.MarsRoverClients
{
   
    public class MarsRoverHttpClient: IMarsRoverHttpClient
    {
        private static String REST_URI =  "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?earth_date=2015-6-3&api_key=";
        private static String API_KEY = "edLAgagb3KFP1QN4hIlZkMKvFGIjihEqZ89bAcFE";
        private static String API_KEY_PARAM_NAME = "api_key";
        private static String EARTH_DATE_PARAM_NAME = "earth_date";


        private readonly HttpClient _httpClient;
        
    
        public MarsRoverHttpClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://api.nasa.gov/mars-photos/api/v1/");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "HttpClientFactory-NasaApi");
            _httpClient = httpClient;
        }



        public async Task<RoverList> GetRoverList()
        {
        
            var queryString = "https://api.nasa.gov/mars-photos/api/v1/rovers?earth_date=2015-6-3&api_key=edLAgagb3KFP1QN4hIlZkMKvFGIjihEqZ89bAcFE";
        
            var request = new HttpRequestMessage(HttpMethod.Get, queryString);

            var response =  await _httpClient.SendAsync(request);

            return response.IsSuccessStatusCode
            ? await response.Content.ReadAsAsync<RoverList>()
            : null;
        }

        //add this arg to methode later string name, string date
        public async Task<PhotoList> GetPhotoList(String date)
        {
            var queryString = $"rovers/opportunity/photos?{EARTH_DATE_PARAM_NAME}={date}&{API_KEY_PARAM_NAME}={API_KEY}";
            var request = new HttpRequestMessage(HttpMethod.Get, queryString);

            var response =  await _httpClient.SendAsync(request);

            return response.IsSuccessStatusCode
            ? await response.Content.ReadAsAsync<PhotoList>()
            : null;
        }

        public async Task<String> GetPhoto(String url)
        {

            string responseBody = await  _httpClient.GetStringAsync(url);
            Console.WriteLine(responseBody);
            return responseBody;
        }


        // public async Task<FileStream> GetPhoto(String url)
        // {
        //     HttpResponseMessage response =  await _httpClient.GetAsync(url);
        //     byte[] content = await response.Content.ReadAsByteArrayAsync();

        //     return File(content, "image/png");
           
        // }

        //  public async Task<FileStream> GetPhoto2(String url)
        // {
             
        // }


        // public HttpResponseMessage GetPhoto(String url)
        // {
        //     HttpResponseMessage response = new HttpResponseMessage();
        //     response.Content = new StreamContent(new FileStream(url)); // this file stream will be closed by lower layers of web api for you once the response is completed.
        //     response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png");

        //     return response;
        // }



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


