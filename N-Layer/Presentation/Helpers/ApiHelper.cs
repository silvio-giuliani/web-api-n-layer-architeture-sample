using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Presentation.Helpers
{
    public class ApiHelper
    {
        public async Task<T> GetAll<T>()
        {
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

        public async Task<T> Get<T>(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(string.Format("http://localhost:11997/api/v1/movies/get/{0}", id));

                string content = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<T>(content);

                    return result;
                }

                throw new System.Exception("Não foi possível completar a operação.");

            }
        }

        public async Task<T> Add<T>(Models.MoviesModel movie)
        {
            using (var client = new HttpClient())
            {

                //var response = await client.PostAsync("http://localhost:11997/api/v1/movies/add", movie);
                var response = await client.GetAsync("http://localhost:11997/api/v1/movies/add");

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