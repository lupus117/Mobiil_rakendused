using Newtonsoft.Json;
using StarWarsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsApp.Core
{
    
        public class DataService
        {
            public static async Task<People> GetDataFromService(string QueryString)
            {
                HttpClient client = new HttpClient();
                var response = await client.GetStringAsync(QueryString);

                People data = null;
                if (response != null)
                {
                    data = JsonConvert.DeserializeObject<People>(response);
                }
                return data;
            }
        }
    
}
