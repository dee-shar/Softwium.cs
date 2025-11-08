using System.Net.Http;

namespace SoftwiumApi
{
    public class Softwium
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://softwium.com/api";
        public Softwium()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetBooks()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/books");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCurrencies()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/currencies");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetPeoples()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/peoples");
            return await response.Content.ReadAsStringAsync();
        }
      
        public async Task<string> GetPokemons()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/pokemons");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
