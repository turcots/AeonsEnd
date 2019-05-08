using AeonsEnd.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace winAeonsEnd.Affaires
{
    public class Nemesis
    {
        public async System.Threading.Tasks.Task<List<NemesisModel>> ObtenirNemesisAsync()
        {
            var query = "Nemesis/ObtenirNemesisTous";
            var aeonsEnd = await GetAeonsEndNemesisAsync(query);
            return aeonsEnd.listeNemesis;
        }

        static async Task<winAeonsEnd.Affaires.AeonsEnd> GetAeonsEndNemesisAsync(string path)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://aeonsend.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var result = new winAeonsEnd.Affaires.AeonsEnd();

            List<NemesisModel> listeNemesis = null;

            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                listeNemesis = await response.Content.ReadAsAsync<List<NemesisModel>>();
            }

            result.listeNemesis = listeNemesis;

            return result;
        }
    }
}
