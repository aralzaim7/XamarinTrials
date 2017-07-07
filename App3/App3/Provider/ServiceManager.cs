using App3.Model;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace App3.Provider
{
    class ServiceManager
    {

        private string Url = "http://144.122.156.67:1072/phonebook/";


        private async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<TheJson> GetAll()
        {

            //bcl yuklenmesi gerek daha sonra da httpclient yuklenmesi gerek nuget'ten
            HttpClient client = await GetClient();
            var result = await client.GetStringAsync(Url);

            //json calıstırmak için newtonsoft yuklenmesi gerek







            return JsonConvert.DeserializeObject<TheJson>(result);
        }
    }
}
