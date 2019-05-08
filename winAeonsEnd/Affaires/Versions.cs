
using AeonsEnd.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace winAeonsEnd.Affaires
{
    public class Versions
    {
        public async System.Threading.Tasks.Task<List<VersionModel>> ObtenirVersionsAsync()
        {
            var queryVersions = "ObtenirVersionTous";
            var aeonsEnd = await GetAeonsEndVersionAsync(queryVersions);
            return aeonsEnd.versionModel;
        }

        static async Task<winAeonsEnd.Affaires.AeonsEnd> GetAeonsEndVersionAsync(string path)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://aeonsend.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var result = new winAeonsEnd.Affaires.AeonsEnd();

            List<VersionModel> listeVersions = null;

            HttpResponseMessage response = await client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                listeVersions = await response.Content.ReadAsAsync<List<VersionModel>>();
            }

            result.versionModel = listeVersions;

            return result;
        }
    }
}
