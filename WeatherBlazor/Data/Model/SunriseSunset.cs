using System.Text.Json.Serialization;

namespace WeatherBlazor.Data.Model
{
#pragma warning disable
	public record SunriseSunsetResults(
			[property: JsonPropertyName("date")] string date,
			[property: JsonPropertyName("sunrise")] string sunrise,
			[property: JsonPropertyName("sunset")] string sunset,
			[property: JsonPropertyName("first_light")] string first_light,
			[property: JsonPropertyName("last_light")] string last_light,
			[property: JsonPropertyName("dawn")] string dawn,
			[property: JsonPropertyName("dusk")] string dusk,
			[property: JsonPropertyName("solar_noon")] string solar_noon,
			[property: JsonPropertyName("golden_hour")] string golden_hour,
			[property: JsonPropertyName("day_length")] string day_length,
			[property: JsonPropertyName("timezone")] string timezone,
			[property: JsonPropertyName("utc_offset")] int utc_offset
		);

	public record SunriseSunsetRoot(
		[property: JsonPropertyName("results")] SunriseSunsetResults results,
		[property: JsonPropertyName("status")] string status
	);
#pragma warning enable
}
