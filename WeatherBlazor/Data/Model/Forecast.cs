using System.Text.Json.Serialization;

namespace WeatherBlazor.Data.Model
{
#pragma warning disable
	public record ForecastElevation(
			[property: JsonPropertyName("unitCode")] string unitCode,
			[property: JsonPropertyName("value")] double value
		);

	public record ForecastGeometry(
		[property: JsonPropertyName("type")] string type,
		[property: JsonPropertyName("coordinates")] IReadOnlyList<List<List<double>>> coordinates
	);

	public record ForecastPeriod(
		[property: JsonPropertyName("number")] int number,
		[property: JsonPropertyName("name")] string name,
		[property: JsonPropertyName("startTime")] DateTime startTime,
		[property: JsonPropertyName("endTime")] DateTime endTime,
		[property: JsonPropertyName("isDaytime")] bool isDaytime,
		[property: JsonPropertyName("temperature")] int temperature,
		[property: JsonPropertyName("temperatureUnit")] string temperatureUnit,
		[property: JsonPropertyName("temperatureTrend")] string temperatureTrend,
		[property: JsonPropertyName("probabilityOfPrecipitation")] ForecastProbabilityOfPrecipitation probabilityOfPrecipitation,
		[property: JsonPropertyName("windSpeed")] string windSpeed,
		[property: JsonPropertyName("windDirection")] string windDirection,
		[property: JsonPropertyName("icon")] string icon,
		[property: JsonPropertyName("shortForecast")] string shortForecast,
		[property: JsonPropertyName("detailedForecast")] string detailedForecast
	);

	public record ForecastProbabilityOfPrecipitation(
		[property: JsonPropertyName("unitCode")] string unitCode,
		[property: JsonPropertyName("value")] int? value
	);

	public record ForecastProperties(
		[property: JsonPropertyName("units")] string units,
		[property: JsonPropertyName("forecastGenerator")] string forecastGenerator,
		[property: JsonPropertyName("generatedAt")] DateTime generatedAt,
		[property: JsonPropertyName("updateTime")] DateTime updateTime,
		[property: JsonPropertyName("validTimes")] string validTimes,
		[property: JsonPropertyName("elevation")] ForecastElevation elevation,
		[property: JsonPropertyName("periods")] IReadOnlyList<ForecastPeriod> periods
	);

	public record ForecastRoot(
		[property: JsonPropertyName("@context")] object context,
		[property: JsonPropertyName("type")] string type,
		[property: JsonPropertyName("geometry")] ForecastGeometry geometry,
		[property: JsonPropertyName("properties")] ForecastProperties properties
	);
#pragma warning disable
}
