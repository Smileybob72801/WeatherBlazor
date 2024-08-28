using System.Text.Json;
using System.Text;

namespace WeatherBlazor.Services
{
	public interface IRadarUrlService
	{
		string GenerateRadarUrl(double longitude, double latitude, int zoomLevel = 7);
	}

	public class RadarUrlService : IRadarUrlService
	{
		public string GenerateRadarUrl(double longitude, double latitude, int zoomLevel = 7)
		{
			// Create the JSON object
			var radarSettings = new
			{
				agenda = new
				{
					id = "weather",
					center = new[] { longitude, latitude },
					location = new[] { longitude, latitude },
					zoom = zoomLevel,
					layer = "bref_qcd"
				},
				animating = true,
				@base = "standard",
				artcc = false,
				county = false,
				cwa = false,
				rfc = false,
				state = false,
				menu = true,
				shortFusedOnly = true,
				opacity = new
				{
					alerts = 0.76,
					local = 0.6,
					localStations = 0.8,
					national = 0.6
				}
			};

			// Serialize to JSON
			string jsonString = JsonSerializer.Serialize(radarSettings);

			// Encode JSON to Base64
			string base64Encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(jsonString));

			// Construct the URL
			return $"https://radar.weather.gov/?settings=v1_{Uri.EscapeDataString(base64Encoded)}";
		}
	}
}
