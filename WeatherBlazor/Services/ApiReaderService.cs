using static WeatherBlazor.Components.Pages.Home;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace WeatherBlazor.Services
{
    public interface IApiReaderService
    {
        Task<T> ReadAsync<T>(string baseAddress, string requestUri);
    }

    public class ApiReaderService : IApiReaderService
    {
        public async Task<Root> ReadAsync<Root>(string baseAddress, string requestUri)
        {
            using HttpClient client = new();

            client.BaseAddress = new Uri(baseAddress);

            HttpResponseMessage responseMessage = await client.GetAsync(requestUri);

            responseMessage.EnsureSuccessStatusCode();

			string resultAsString = await responseMessage.Content.ReadAsStringAsync();

            await Console.Out.WriteLineAsync(resultAsString);

            Root? result = JsonSerializer.Deserialize<Root>(resultAsString);

            return result ?? throw new InvalidOperationException("Null result");
        }
    }
}
