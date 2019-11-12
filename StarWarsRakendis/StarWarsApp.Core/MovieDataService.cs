using Newtonsoft.Json;
using StarWarsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsApp.Core
{
    
        public class MovieDataService
        {
            public static async Task<Movies> GetDataFromService(string QueryString)
            {
                HttpClient client = new HttpClient();
                var response = await client.GetStringAsync(QueryString);

                Movies data = null;
                if (response != null)
                {
                    data = JsonConvert.DeserializeObject<Movies>(response);
                }
                return data;
            }
        }
    
}
