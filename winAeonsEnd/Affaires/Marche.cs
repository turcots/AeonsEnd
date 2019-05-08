using AeonsEnd.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace winAeonsEnd.Affaires
{
    public class Marche
    {
        public async Task<MarcheModel> ObtenirMarcheAsync()
        {
            var query = "Marche/ObtenirMarcheTous";
            var aeonsEnd = await GetAeonsEndMarcheAsync(query);
            return aeonsEnd.marcheModel;
        }

        static async Task<AeonsEnd> GetAeonsEndMarcheAsync(string path)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://aeonsend2.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var result = new AeonsEnd();

            MarcheModel marche = null;

            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                marche = await response.Content.ReadAsAsync<MarcheModel>();
            }

            result.marcheModel = marche;

            return result;
        }
    }
}
