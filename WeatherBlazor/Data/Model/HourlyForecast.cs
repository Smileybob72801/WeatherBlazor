using System.Text.Json.Serialization;

namespace WeatherBlazor.Data.Model
{
#pragma warning disable
	public record HourlyForecastDewpoint(
		[property: JsonPropertyName("unitCode")] string unitCode,
		[property: JsonPropertyName("value")] double value
	);

	public record HourlyForecastElevation(
		[property: JsonPropertyName("unitCode")] string unitCode,
		[property: JsonPropertyName("value")] double value
	);

	public record HourlyForecastGeometry(
		[property: JsonPropertyName("type")] string type,
		[property: JsonPropertyName("coordinates")] IReadOnlyList<List<List<double>>> coordinates
	);

	public record HourlyForecastPeriod(
		[property: JsonPropertyName("number")] int number,
		[property: JsonPropertyName("name")] string name,
		[property: JsonPropertyName("startTime")] DateTime startTime,
		[property: JsonPropertyName("endTime")] DateTime endTime,
		[property: JsonPropertyName("isDaytime")] bool isDaytime,
		[property: JsonPropertyName("temperature")] int temperature,
		[property: JsonPropertyName("temperatureUnit")] string temperatureUnit,
		[property: JsonPropertyName("temperatureTrend")] string temperatureTrend,
		[property: JsonPropertyName("probabilityOfPrecipitation")] HourlyForecastProbabilityOfPrecipitation probabilityOfPrecipitation,
		[property: JsonPropertyName("dewpoint")] HourlyForecastDewpoint dewpoint,
		[property: JsonPropertyName("relativeHumidity")] HourlyForecastRelativeHumidity relativeHumidity,
		[property: JsonPropertyName("windSpeed")] string windSpeed,
		[property: JsonPropertyName("windDirection")] string windDirection,
		[property: JsonPropertyName("icon")] string icon,
		[property: JsonPropertyName("shortForecast")] string shortForecast,
		[property: JsonPropertyName("detailedForecast")] string detailedForecast
	);

	public record HourlyForecastProbabilityOfPrecipitation(
		[property: JsonPropertyName("unitCode")] string unitCode,
		[property: JsonPropertyName("value")] int value
	);

	public record HourlyForecastProperties(
		[property: JsonPropertyName("units")] string units,
		[property: JsonPropertyName("forecastGenerator")] string forecastGenerator,
		[property: JsonPropertyName("generatedAt")] DateTime generatedAt,
		[property: JsonPropertyName("updateTime")] DateTime updateTime,
		[property: JsonPropertyName("validTimes")] string validTimes,
		[property: JsonPropertyName("elevation")] HourlyForecastElevation elevation,
		[property: JsonPropertyName("periods")] IReadOnlyList<HourlyForecastPeriod> periods
	);

	public record HourlyForecastRelativeHumidity(
		[property: JsonPropertyName("unitCode")] string unitCode,
		[property: JsonPropertyName("value")] int value
	);

	public record HourlyForecastRoot(
		[property: JsonPropertyName("@context")] IReadOnlyList<object> context,
		[property: JsonPropertyName("type")] string type,
		[property: JsonPropertyName("geometry")] HourlyForecastGeometry geometry,
		[property: JsonPropertyName("properties")] HourlyForecastProperties properties
	);
#pragma warning enable
}
