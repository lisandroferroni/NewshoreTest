using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;
using Services.Interfaces;

namespace Services
{
    public class VivaAirAPIService : IVivaAirAPIService
    {
        private readonly HttpClient httpClient;
        public VivaAirAPIService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        
        public async Task<List<ResponseVivaAirAPIFindFlights>> FindFligthsAsync(RequestVivaAirAPIFindFlights request)
        {
            try
            {
                string jsonObject = JsonConvert.SerializeObject(request);
                var requestContent = new StringContent(jsonObject, Encoding.UTF8, "application/json");

                var apiResponse = await httpClient.PostAsync("http://testapi.vivaair.com/otatest/api/values", requestContent);

                var content = await apiResponse.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<List<ResponseVivaAirAPIFindFlights>>(JsonConvert.DeserializeObject<string>(content));
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Error calling external API: " + e.Message);
            }
        }


    }
}
