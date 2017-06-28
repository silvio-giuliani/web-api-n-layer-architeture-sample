using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Presentation.Helpers
{
    public class ApiHelper
    {
        public async Task<T> Get<T>() {

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:11997/api/v1/movies/getall");

                string content = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<T>(content);

                    return result;
                }

                throw new System.Exception("Não foi possível completar a operação.");

            }
        }
    }
}