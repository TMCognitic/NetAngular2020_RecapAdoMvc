using Models.Entities;
using Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Models.Api.Repositories
{
    public class ApiContactRepository : IContactRepository
    {
        public ApiContactRepository()
        {
        }

        public IEnumerable<Contact> Get()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:7001/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponseMessage = httpClient.GetAsync("contact").Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<Contact[]>(json);
            }
        }

        public Contact Get(int id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://localhost:7001/");

                HttpResponseMessage httpResponseMessage = httpClient.GetAsync("contact/"+id).Result;
                httpResponseMessage.EnsureSuccessStatusCode();

                string json = httpResponseMessage.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<Contact>(json);
            }
        }
    }
}
