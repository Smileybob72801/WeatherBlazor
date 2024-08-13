using System.Text.Json.Serialization;

namespace WeatherBlazor.Data.Model
{
#pragma warning disable
	public record Current(
		[property: JsonPropertyName("time")] string time,
		[property: JsonPropertyName("interval")] int interval,
		[property: JsonPropertyName("temperature_2m")] double temperature_2m,
		[property: JsonPropertyName("relative_humidity_2m")] int relative_humidity_2m,
		[property: JsonPropertyName("apparent_temperature")] double apparent_temperature,
		[property: JsonPropertyName("is_day")] int is_day,
		[property: JsonPropertyName("precipitation")] double precipitation,
		[property: JsonPropertyName("wind_speed_10m")] double wind_speed_10m,
		[property: JsonPropertyName("wind_direction_10m")] int wind_direction_10m
	);

	public record CurrentUnits(
		[property: JsonPropertyName("time")] string time,
		[property: JsonPropertyName("interval")] string interval,
		[property: JsonPropertyName("temperature_2m")] string temperature_2m,
		[property: JsonPropertyName("relative_humidity_2m")] string relative_humidity_2m,
		[property: JsonPropertyName("apparent_temperature")] string apparent_temperature,
		[property: JsonPropertyName("is_day")] string is_day,
		[property: JsonPropertyName("precipitation")] string precipitation,
		[property: JsonPropertyName("wind_speed_10m")] string wind_speed_10m,
		[property: JsonPropertyName("wind_direction_10m")] string wind_direction_10m
	);

	public record Daily(
		[property: JsonPropertyName("time")] IReadOnlyList<string> time,
		[property: JsonPropertyName("temperature_2m_max")] IReadOnlyList<double> temperature_2m_max,
		[property: JsonPropertyName("temperature_2m_min")] IReadOnlyList<double> temperature_2m_min,
		[property: JsonPropertyName("apparent_temperature_max")] IReadOnlyList<double> apparent_temperature_max,
		[property: JsonPropertyName("apparent_temperature_min")] IReadOnlyList<double> apparent_temperature_min,
		[property: JsonPropertyName("sunrise")] IReadOnlyList<string> sunrise,
		[property: JsonPropertyName("sunset")] IReadOnlyList<string> sunset,
		[property: JsonPropertyName("daylight_duration")] IReadOnlyList<double> daylight_duration,
		[property: JsonPropertyName("uv_index_clear_sky_max")] IReadOnlyList<double> uv_index_clear_sky_max,
		[property: JsonPropertyName("precipitation_sum")] IReadOnlyList<double> precipitation_sum,
		[property: JsonPropertyName("precipitation_probability_max")] IReadOnlyList<int> precipitation_probability_max,
		[property: JsonPropertyName("wind_speed_10m_max")] IReadOnlyList<double> wind_speed_10m_max,
		[property: JsonPropertyName("wind_direction_10m_dominant")] IReadOnlyList<int> wind_direction_10m_dominant
	);

	public record DailyUnits(
		[property: JsonPropertyName("time")] string time,
		[property: JsonPropertyName("temperature_2m_max")] string temperature_2m_max,
		[property: JsonPropertyName("temperature_2m_min")] string temperature_2m_min,
		[property: JsonPropertyName("apparent_temperature_max")] string apparent_temperature_max,
		[property: JsonPropertyName("apparent_temperature_min")] string apparent_temperature_min,
		[property: JsonPropertyName("sunrise")] string sunrise,
		[property: JsonPropertyName("sunset")] string sunset,
		[property: JsonPropertyName("daylight_duration")] string daylight_duration,
		[property: JsonPropertyName("uv_index_clear_sky_max")] string uv_index_clear_sky_max,
		[property: JsonPropertyName("precipitation_sum")] string precipitation_sum,
		[property: JsonPropertyName("precipitation_probability_max")] string precipitation_probability_max,
		[property: JsonPropertyName("wind_speed_10m_max")] string wind_speed_10m_max,
		[property: JsonPropertyName("wind_direction_10m_dominant")] string wind_direction_10m_dominant
	);

	public record Hourly(
		[property: JsonPropertyName("time")] IReadOnlyList<string> time,
		[property: JsonPropertyName("temperature_2m")] IReadOnlyList<double> temperature_2m,
		[property: JsonPropertyName("relative_humidity_2m")] IReadOnlyList<int> relative_humidity_2m,
		[property: JsonPropertyName("dew_point_2m")] IReadOnlyList<double> dew_point_2m,
		[property: JsonPropertyName("apparent_temperature")] IReadOnlyList<double> apparent_temperature,
		[property: JsonPropertyName("precipitation_probability")] IReadOnlyList<int> precipitation_probability,
		[property: JsonPropertyName("precipitation")] IReadOnlyList<double> precipitation,
		[property: JsonPropertyName("rain")] IReadOnlyList<double> rain,
		[property: JsonPropertyName("showers")] IReadOnlyList<double> showers,
		[property: JsonPropertyName("snowfall")] IReadOnlyList<double> snowfall,
		[property: JsonPropertyName("snow_depth")] IReadOnlyList<double> snow_depth,
		[property: JsonPropertyName("pressure_msl")] IReadOnlyList<double> pressure_msl,
		[property: JsonPropertyName("surface_pressure")] IReadOnlyList<double> surface_pressure,
		[property: JsonPropertyName("cloud_cover")] IReadOnlyList<int> cloud_cover,
		[property: JsonPropertyName("cloud_cover_low")] IReadOnlyList<int> cloud_cover_low,
		[property: JsonPropertyName("cloud_cover_mid")] IReadOnlyList<int> cloud_cover_mid,
		[property: JsonPropertyName("cloud_cover_high")] IReadOnlyList<int> cloud_cover_high,
		[property: JsonPropertyName("visibility")] IReadOnlyList<double> visibility,
		[property: JsonPropertyName("wind_speed_10m")] IReadOnlyList<double> wind_speed_10m,
		[property: JsonPropertyName("wind_direction_10m")] IReadOnlyList<int> wind_direction_10m,
		[property: JsonPropertyName("wind_gusts_10m")] IReadOnlyList<double> wind_gusts_10m,
		[property: JsonPropertyName("uv_index_clear_sky")] IReadOnlyList<double> uv_index_clear_sky,
		[property: JsonPropertyName("is_day")] IReadOnlyList<int> is_day,
		[property: JsonPropertyName("cape")] IReadOnlyList<double> cape
	);

	public record HourlyUnits(
		[property: JsonPropertyName("time")] string time,
		[property: JsonPropertyName("temperature_2m")] string temperature_2m,
		[property: JsonPropertyName("relative_humidity_2m")] string relative_humidity_2m,
		[property: JsonPropertyName("dew_point_2m")] string dew_point_2m,
		[property: JsonPropertyName("apparent_temperature")] string apparent_temperature,
		[property: JsonPropertyName("precipitation_probability")] string precipitation_probability,
		[property: JsonPropertyName("precipitation")] string precipitation,
		[property: JsonPropertyName("rain")] string rain,
		[property: JsonPropertyName("showers")] string showers,
		[property: JsonPropertyName("snowfall")] string snowfall,
		[property: JsonPropertyName("snow_depth")] string snow_depth,
		[property: JsonPropertyName("pressure_msl")] string pressure_msl,
		[property: JsonPropertyName("surface_pressure")] string surface_pressure,
		[property: JsonPropertyName("cloud_cover")] string cloud_cover,
		[property: JsonPropertyName("cloud_cover_low")] string cloud_cover_low,
		[property: JsonPropertyName("cloud_cover_mid")] string cloud_cover_mid,
		[property: JsonPropertyName("cloud_cover_high")] string cloud_cover_high,
		[property: JsonPropertyName("visibility")] string visibility,
		[property: JsonPropertyName("wind_speed_10m")] string wind_speed_10m,
		[property: JsonPropertyName("wind_direction_10m")] string wind_direction_10m,
		[property: JsonPropertyName("wind_gusts_10m")] string wind_gusts_10m,
		[property: JsonPropertyName("uv_index_clear_sky")] string uv_index_clear_sky,
		[property: JsonPropertyName("is_day")] string is_day,
		[property: JsonPropertyName("cape")] string cape
	);

	public record Root(
		[property: JsonPropertyName("latitude")] double latitude,
		[property: JsonPropertyName("longitude")] double longitude,
		[property: JsonPropertyName("generationtime_ms")] double generationtime_ms,
		[property: JsonPropertyName("utc_offset_seconds")] int utc_offset_seconds,
		[property: JsonPropertyName("timezone")] string timezone,
		[property: JsonPropertyName("timezone_abbreviation")] string timezone_abbreviation,
		[property: JsonPropertyName("elevation")] double elevation,
		[property: JsonPropertyName("current_units")] CurrentUnits current_units,
		[property: JsonPropertyName("current")] Current current,
		[property: JsonPropertyName("hourly_units")] HourlyUnits hourly_units,
		[property: JsonPropertyName("hourly")] Hourly hourly,
		[property: JsonPropertyName("daily_units")] DailyUnits daily_units,
		[property: JsonPropertyName("daily")] Daily daily
	);
#pragma warning enable
}
