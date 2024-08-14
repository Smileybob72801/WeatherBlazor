using System.Text.Json;

namespace WeatherBlazor.Services
{
	public interface IJsonDeserializerService
	{
		T? Deserialize<T>(string json);
	}

	public class JsonDeserializerService : IJsonDeserializerService
	{
		public T? Deserialize<T>(string json)
		{
			ArgumentNullException.ThrowIfNull(json, nameof(json));
			return JsonSerializer.Deserialize<T>(json);
		}
	}
}
