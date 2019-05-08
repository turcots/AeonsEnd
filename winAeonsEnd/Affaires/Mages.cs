using AeonsEnd.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace winAeonsEnd.Affaires
{
    public class Mages
    {
        public async System.Threading.Tasks.Task<List<MageModel>> ObtenirMagesAsync()
        {
            var query = "Mages/ObtenirMagesTous";
            var aeonsEnd = await GetAeonsEndMagesAsync(query);
            return aeonsEnd.listeMages;
        }

        static async Task<winAeonsEnd.Affaires.AeonsEnd> GetAeonsEndMagesAsync(string path)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://aeonsend.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var result = new winAeonsEnd.Affaires.AeonsEnd();

            List<MageModel> listeMages = null;

            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                listeMages = await response.Content.ReadAsAsync<List<MageModel>>();
            }

            result.listeMages = listeMages;

            return result;
        }
    }
}
