using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Xamarin.Forms;

namespace CoffeShopMobile.RestClient
{
        public class RestClientService<T>
        {      
            public async Task<List<T>> GetAsync(string WebServiceUrl)
            {
                var httpClient = new HttpClient();

		    	var json = await httpClient.GetStringAsync(WebServiceURLS.WebServiceURL + WebServiceUrl);

                var taskModels = JsonConvert.DeserializeObject<List<T>>(json);

                return taskModels;
            }

		public async Task<bool> PostAsync(T t, string WebServiceUrl)
            {
                var httpClient = new HttpClient();

                var json = JsonConvert.SerializeObject(t);

                HttpContent httpContent = new StringContent(json);

                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

			var result = await httpClient.PostAsync(WebServiceURLS.WebServiceURL + WebServiceUrl, httpContent);

                return result.IsSuccessStatusCode;
            }

		public async Task<bool> PutAsync(int id, T t , string WebServiceUrl)
            {
                var httpClient = new HttpClient();

                var json = JsonConvert.SerializeObject(t);

                HttpContent httpContent = new StringContent(json);

                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

			var result = await httpClient.PutAsync(WebServiceURLS.WebServiceURL + WebServiceUrl + id, httpContent);

                return result.IsSuccessStatusCode;
            }

		public async Task<bool> DeleteAsync(int id, T t , string WebServiceUrl)
            {
                var httpClient = new HttpClient();

			var response = await httpClient.DeleteAsync(WebServiceURLS.WebServiceURL + WebServiceUrl + id);

                return response.IsSuccessStatusCode;
            }
        }
    }

