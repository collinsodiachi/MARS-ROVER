using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using MARS_ROVER.Model;


namespace MARS_ROVER.MarsRoverClients
{
   
    public class MarsRoverHttpClient: IMarsRoverHttpClient
    {

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

        
        public async Task<PhotoList> GetPhotoList(String date)
        {
            var queryString = $"rovers/curiosity/photos?{EARTH_DATE_PARAM_NAME}={date}&{API_KEY_PARAM_NAME}={API_KEY}";
            var request = new HttpRequestMessage(HttpMethod.Get, queryString);

            var response =  await _httpClient.SendAsync(request);

            return response.IsSuccessStatusCode
            ? await response.Content.ReadAsAsync<PhotoList>()
            : null;
        }

        public async void SavePhoto(String url)
        {
            Uri uri = new Uri(url);
            string filename = Path.GetFileName(uri.LocalPath);
            // Send asynchronous request
            await _httpClient.GetAsync(url).ContinueWith(
            (requestTask) =>
            {
                // Get HTTP response from completed task.
                HttpResponseMessage response = requestTask.Result;
                // Check that response was successful or throw exception
                response.EnsureSuccessStatusCode();

                // Read content into buffer
                // The content can now be read multiple times using any ReadAs* extension method
                response.Content.LoadIntoBufferAsync();

                // Read response asynchronously and save to file
                response.Content.ReadAsFileAsync(filename, true);
            
            });
           
        }
    }
}
