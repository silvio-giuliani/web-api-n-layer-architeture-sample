using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System.Net;

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

                throw new System.Exception("It was not possible to complete this operation.");

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

                throw new System.Exception("It was not possible to complete this operation.");

            }
        }

        public async Task<T> Add<T>(Models.MoviesModel movie)
        {
            using (var client = new HttpClient())
            {

                var json = JsonConvert.SerializeObject(movie);

                var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");

                var request = await client.PostAsync("http://localhost:11997/api/v1/movies/add", content);

                string result = await request.Content.ReadAsStringAsync();

                if (request.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(result);
                }

                throw new System.Exception("It was not possible to complete this operation.");

            }
        }

        public async Task<T> Update<T>(int id, Models.MoviesModel movie)
        {
            using (var client = new HttpClient())
            {

                var json = JsonConvert.SerializeObject(movie);

                var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");

                var request = await client.PutAsync(string.Format("http://localhost:11997/api/v1/movies/update/{0}", id), content);

                string result = await request.Content.ReadAsStringAsync();

                if (request.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(result);
                }

                throw new System.Exception("It was not possible to complete this operation.");

            }
        }

        public async Task<T> Delete<T>(int id)
        {
            using (var client = new HttpClient())
            {

                var request = await client.DeleteAsync(string.Format("http://localhost:11997/api/v1/movies/remove/{0}", id));

                string result = await request.Content.ReadAsStringAsync();

                if (request.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<T>(result);
                }

                throw new System.Exception("It was not possible to complete this operation.");

            }
        }

    }
}