using System.Text.Json.Serialization;

namespace WeatherBlazor.Data.Model
{
	public record ApparentTemperature(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record AtmosphericDispersionIndex(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record CeilingHeight(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record DavisStabilityIndex(
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record Dewpoint(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record DispersionIndex(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record Elevation(
		[property: JsonPropertyName("unitCode")] string UnitCode,
		[property: JsonPropertyName("value")] double Value
	);

	public record Geometry(
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("coordinates")] IReadOnlyList<List<List<double>>> Coordinates
	);

	public record GrasslandFireDangerIndex(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record HainesIndex(
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record Hazards(
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record HeatIndex(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record IceAccumulation(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record LightningActivityLevel(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record LowVisibilityOccurrenceRiskIndex(
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record MaxTemperature(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record MinTemperature(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record MixingHeight(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record PotentialOf15mphWinds(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record PotentialOf20mphWindGusts(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record PotentialOf25mphWinds(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record PotentialOf30mphWindGusts(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record PotentialOf35mphWinds(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record PotentialOf40mphWindGusts(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record PotentialOf45mphWinds(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record PotentialOf50mphWindGusts(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record PotentialOf60mphWindGusts(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record Pressure(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record PrimarySwellDirection(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record PrimarySwellHeight(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record ProbabilityOfHurricaneWinds(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record ProbabilityOfPrecipitation(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record ProbabilityOfThunder(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record ProbabilityOfTropicalStormWinds(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record Properties(
		[property: JsonPropertyName("@id")] string Id,
		[property: JsonPropertyName("@type")] string Type,
		[property: JsonPropertyName("updateTime")] DateTime UpdateTime,
		[property: JsonPropertyName("validTimes")] string ValidTimes,
		[property: JsonPropertyName("elevation")] Elevation Elevation,
		[property: JsonPropertyName("forecastOffice")] string ForecastOffice,
		[property: JsonPropertyName("gridId")] string GridId,
		[property: JsonPropertyName("gridX")] string GridX,
		[property: JsonPropertyName("gridY")] string GridY,
		[property: JsonPropertyName("temperature")] Temperature Temperature,
		[property: JsonPropertyName("dewpoint")] Dewpoint Dewpoint,
		[property: JsonPropertyName("maxTemperature")] MaxTemperature MaxTemperature,
		[property: JsonPropertyName("minTemperature")] MinTemperature MinTemperature,
		[property: JsonPropertyName("relativeHumidity")] RelativeHumidity RelativeHumidity,
		[property: JsonPropertyName("apparentTemperature")] ApparentTemperature ApparentTemperature,
		[property: JsonPropertyName("wetBulbGlobeTemperature")] WetBulbGlobeTemperature WetBulbGlobeTemperature,
		[property: JsonPropertyName("heatIndex")] HeatIndex HeatIndex,
		[property: JsonPropertyName("windChill")] WindChill WindChill,
		[property: JsonPropertyName("skyCover")] SkyCover SkyCover,
		[property: JsonPropertyName("windDirection")] WindDirection WindDirection,
		[property: JsonPropertyName("windSpeed")] WindSpeed WindSpeed,
		[property: JsonPropertyName("windGust")] WindGust WindGust,
		[property: JsonPropertyName("weather")] Weather Weather,
		[property: JsonPropertyName("hazards")] Hazards Hazards,
		[property: JsonPropertyName("probabilityOfPrecipitation")] ProbabilityOfPrecipitation ProbabilityOfPrecipitation,
		[property: JsonPropertyName("quantitativePrecipitation")] QuantitativePrecipitation QuantitativePrecipitation,
		[property: JsonPropertyName("iceAccumulation")] IceAccumulation IceAccumulation,
		[property: JsonPropertyName("snowfallAmount")] SnowfallAmount SnowfallAmount,
		[property: JsonPropertyName("snowLevel")] SnowLevel SnowLevel,
		[property: JsonPropertyName("ceilingHeight")] CeilingHeight CeilingHeight,
		[property: JsonPropertyName("visibility")] Visibility Visibility,
		[property: JsonPropertyName("transportWindSpeed")] TransportWindSpeed TransportWindSpeed,
		[property: JsonPropertyName("transportWindDirection")] TransportWindDirection TransportWindDirection,
		[property: JsonPropertyName("mixingHeight")] MixingHeight MixingHeight,
		[property: JsonPropertyName("hainesIndex")] HainesIndex HainesIndex,
		[property: JsonPropertyName("lightningActivityLevel")] LightningActivityLevel LightningActivityLevel,
		[property: JsonPropertyName("twentyFootWindSpeed")] TwentyFootWindSpeed TwentyFootWindSpeed,
		[property: JsonPropertyName("twentyFootWindDirection")] TwentyFootWindDirection TwentyFootWindDirection,
		[property: JsonPropertyName("waveHeight")] WaveHeight WaveHeight,
		[property: JsonPropertyName("wavePeriod")] WavePeriod WavePeriod,
		[property: JsonPropertyName("waveDirection")] WaveDirection WaveDirection,
		[property: JsonPropertyName("primarySwellHeight")] PrimarySwellHeight PrimarySwellHeight,
		[property: JsonPropertyName("primarySwellDirection")] PrimarySwellDirection PrimarySwellDirection,
		[property: JsonPropertyName("secondarySwellHeight")] SecondarySwellHeight SecondarySwellHeight,
		[property: JsonPropertyName("secondarySwellDirection")] SecondarySwellDirection SecondarySwellDirection,
		[property: JsonPropertyName("wavePeriod2")] WavePeriod2 WavePeriod2,
		[property: JsonPropertyName("windWaveHeight")] WindWaveHeight WindWaveHeight,
		[property: JsonPropertyName("dispersionIndex")] DispersionIndex DispersionIndex,
		[property: JsonPropertyName("pressure")] Pressure Pressure,
		[property: JsonPropertyName("probabilityOfTropicalStormWinds")] ProbabilityOfTropicalStormWinds ProbabilityOfTropicalStormWinds,
		[property: JsonPropertyName("probabilityOfHurricaneWinds")] ProbabilityOfHurricaneWinds ProbabilityOfHurricaneWinds,
		[property: JsonPropertyName("potentialOf15mphWinds")] PotentialOf15mphWinds PotentialOf15mphWinds,
		[property: JsonPropertyName("potentialOf25mphWinds")] PotentialOf25mphWinds PotentialOf25mphWinds,
		[property: JsonPropertyName("potentialOf35mphWinds")] PotentialOf35mphWinds PotentialOf35mphWinds,
		[property: JsonPropertyName("potentialOf45mphWinds")] PotentialOf45mphWinds PotentialOf45mphWinds,
		[property: JsonPropertyName("potentialOf20mphWindGusts")] PotentialOf20mphWindGusts PotentialOf20mphWindGusts,
		[property: JsonPropertyName("potentialOf30mphWindGusts")] PotentialOf30mphWindGusts PotentialOf30mphWindGusts,
		[property: JsonPropertyName("potentialOf40mphWindGusts")] PotentialOf40mphWindGusts PotentialOf40mphWindGusts,
		[property: JsonPropertyName("potentialOf50mphWindGusts")] PotentialOf50mphWindGusts PotentialOf50mphWindGusts,
		[property: JsonPropertyName("potentialOf60mphWindGusts")] PotentialOf60mphWindGusts PotentialOf60mphWindGusts,
		[property: JsonPropertyName("grasslandFireDangerIndex")] GrasslandFireDangerIndex GrasslandFireDangerIndex,
		[property: JsonPropertyName("probabilityOfThunder")] ProbabilityOfThunder ProbabilityOfThunder,
		[property: JsonPropertyName("davisStabilityIndex")] DavisStabilityIndex DavisStabilityIndex,
		[property: JsonPropertyName("atmosphericDispersionIndex")] AtmosphericDispersionIndex AtmosphericDispersionIndex,
		[property: JsonPropertyName("lowVisibilityOccurrenceRiskIndex")] LowVisibilityOccurrenceRiskIndex LowVisibilityOccurrenceRiskIndex,
		[property: JsonPropertyName("stability")] Stability Stability,
		[property: JsonPropertyName("redFlagThreatIndex")] RedFlagThreatIndex RedFlagThreatIndex
	);

	public record QuantitativePrecipitation(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record RedFlagThreatIndex(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record RelativeHumidity(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record GridDataRoot(
		[property: JsonPropertyName("@context")] IReadOnlyList<object> Context,
		[property: JsonPropertyName("id")] string Id,
		[property: JsonPropertyName("type")] string Type,
		[property: JsonPropertyName("geometry")] Geometry Geometry,
		[property: JsonPropertyName("properties")] Properties Properties
	);

	public record SecondarySwellDirection(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record SecondarySwellHeight(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record SkyCover(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record SnowfallAmount(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record SnowLevel(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record Stability(
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record Temperature(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record TransportWindDirection(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record TransportWindSpeed(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record TwentyFootWindDirection(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record TwentyFootWindSpeed(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record Value(
		[property: JsonPropertyName("validTime")] string ValidTime,
		[property: JsonPropertyName("value")] double NwsValue
	);

	public record Value15(
		[property: JsonPropertyName("coverage")] string Coverage,
		[property: JsonPropertyName("weather")] string Weather,
		[property: JsonPropertyName("intensity")] string Intensity,
		[property: JsonPropertyName("visibility")] Visibility Visibility,
		[property: JsonPropertyName("attributes")] IReadOnlyList<object> Attributes,
		[property: JsonPropertyName("phenomenon")] string Phenomenon,
		[property: JsonPropertyName("significance")] string Significance,
		[property: JsonPropertyName("event_number")] object EventNumber
	);

	public record Visibility(
		[property: JsonPropertyName("unitCode")] string UnitCode,
		[property: JsonPropertyName("value")] object Value,
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record WaveDirection(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record WaveHeight(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record WavePeriod(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record WavePeriod2(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);

	public record Weather(
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record WetBulbGlobeTemperature(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record WindChill(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record WindDirection(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record WindGust(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record WindSpeed(
		[property: JsonPropertyName("uom")] string Uom,
		[property: JsonPropertyName("values")] IReadOnlyList<Value> Values
	);

	public record WindWaveHeight(
		[property: JsonPropertyName("values")] IReadOnlyList<object> Values
	);


}
