using System.Text.Json.Serialization;

namespace WeatherBlazor.Data.Model
{
#pragma warning disable
	public record PointBearing(
		[property: JsonPropertyName("unitCode")] string unitCode,
		[property: JsonPropertyName("value")] int value
	);

	public record PointDistance(
		[property: JsonPropertyName("unitCode")] string unitCode,
		[property: JsonPropertyName("value")] double value
	);

	public record PointGeometry(
		[property: JsonPropertyName("type")] string type,
		[property: JsonPropertyName("coordinates")] IReadOnlyList<double> coordinates
	);

	public record PointProperties(
		[property: JsonPropertyName("@id")] string id,
		[property: JsonPropertyName("@type")] string type,
		[property: JsonPropertyName("cwa")] string cwa,
		[property: JsonPropertyName("forecastOffice")] string forecastOffice,
		[property: JsonPropertyName("gridId")] string gridId,
		[property: JsonPropertyName("gridX")] int gridX,
		[property: JsonPropertyName("gridY")] int gridY,
		[property: JsonPropertyName("forecast")] string forecast,
		[property: JsonPropertyName("forecastHourly")] string forecastHourly,
		[property: JsonPropertyName("forecastGridData")] string forecastGridData,
		[property: JsonPropertyName("observationStations")] string observationStations,
		[property: JsonPropertyName("relativeLocation")] PointRelativeLocation relativeLocation,
		[property: JsonPropertyName("forecastZone")] string forecastZone,
		[property: JsonPropertyName("county")] string county,
		[property: JsonPropertyName("fireWeatherZone")] string fireWeatherZone,
		[property: JsonPropertyName("timeZone")] string timeZone,
		[property: JsonPropertyName("radarStation")] string radarStation,
		[property: JsonPropertyName("city")] string city,
		[property: JsonPropertyName("state")] string state,
		[property: JsonPropertyName("distance")] PointDistance distance,
		[property: JsonPropertyName("bearing")] PointBearing bearing
	);

	public record PointRelativeLocation(
		[property: JsonPropertyName("type")] string type,
		[property: JsonPropertyName("geometry")] PointGeometry geometry,
		[property: JsonPropertyName("properties")] PointProperties properties
	);

	public record PointRoot(
		[property: JsonPropertyName("@context")] IReadOnlyList<object> context,
		[property: JsonPropertyName("id")] string id,
		[property: JsonPropertyName("type")] string type,
		[property: JsonPropertyName("geometry")] PointGeometry geometry,
		[property: JsonPropertyName("properties")] PointProperties properties
	);
#pragma warning enable
}
