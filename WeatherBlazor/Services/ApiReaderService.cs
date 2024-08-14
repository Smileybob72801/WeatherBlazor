using static WeatherBlazor.Components.Pages.Home;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace WeatherBlazor.Services
{
    public interface IApiReaderService
    {
        Task<string> ReadAsync(string baseAddress, string requestUri);
    }

    public class ApiReaderService : IApiReaderService
    {
        public async Task<string> ReadAsync(string baseAddress, string requestUri)
        {
            using HttpClient client = new();

            client.BaseAddress = new Uri(baseAddress);

			client.DefaultRequestHeaders.Add(
				"User-Agent", "(weatherBlazor, Daniel Simmons, smileybob@72801@gmail.com)");

			HttpResponseMessage responseMessage = await client.GetAsync(requestUri);

            responseMessage.EnsureSuccessStatusCode();

			string resultAsString = await responseMessage.Content.ReadAsStringAsync();

            await Console.Out.WriteLineAsync(resultAsString);

            return resultAsString ?? throw new InvalidOperationException("Null result");
        }
    }
}
