using System.Text.Json.Serialization;

namespace WeatherBlazor.Data.Model
{
#pragma warning disable
	public record AlertFeature(
		[property: JsonPropertyName("id")] string id,
		[property: JsonPropertyName("type")] string type,
		[property: JsonPropertyName("geometry")] object geometry,
		[property: JsonPropertyName("properties")] AlertProperties properties
	);

	public record AlertGeocode(
		[property: JsonPropertyName("SAME")] IReadOnlyList<string> SAME,
		[property: JsonPropertyName("UGC")] IReadOnlyList<string> UGC
	);

	public record AlertPagination(
		[property: JsonPropertyName("next")] string next
	);

	public record AlertParameters(
		[property: JsonPropertyName("AWIPSidentifier")] IReadOnlyList<string> AWIPSidentifier,
		[property: JsonPropertyName("WMOidentifier")] IReadOnlyList<string> WMOidentifier,
		[property: JsonPropertyName("NWSheadline")] IReadOnlyList<string> NWSheadline,
		[property: JsonPropertyName("BLOCKCHANNEL")] IReadOnlyList<string> BLOCKCHANNEL,
		[property: JsonPropertyName("VTEC")] IReadOnlyList<string> VTEC,
		[property: JsonPropertyName("eventEndingTime")] IReadOnlyList<DateTime> eventEndingTime,
		[property: JsonPropertyName("expiredReferences")] IReadOnlyList<string> expiredReferences
	);

	public record AlertProperties(
		[property: JsonPropertyName("@id")] string urlId,
		[property: JsonPropertyName("@type")] string type,
		[property: JsonPropertyName("id")] string id,
		[property: JsonPropertyName("areaDesc")] string areaDesc,
		[property: JsonPropertyName("geocode")] AlertGeocode geocode,
		[property: JsonPropertyName("affectedZones")] IReadOnlyList<string> affectedZones,
		[property: JsonPropertyName("references")] IReadOnlyList<AlertReference> references,
		[property: JsonPropertyName("sent")] DateTime sent,
		[property: JsonPropertyName("effective")] DateTime effective,
		[property: JsonPropertyName("onset")] DateTime onset,
		[property: JsonPropertyName("expires")] DateTime expires,
		[property: JsonPropertyName("ends")] DateTime ends,
		[property: JsonPropertyName("status")] string status,
		[property: JsonPropertyName("messageType")] string messageType,
		[property: JsonPropertyName("category")] string category,
		[property: JsonPropertyName("severity")] string severity,
		[property: JsonPropertyName("certainty")] string certainty,
		[property: JsonPropertyName("urgency")] string urgency,
		[property: JsonPropertyName("event")] string @event,
		[property: JsonPropertyName("sender")] string sender,
		[property: JsonPropertyName("senderName")] string senderName,
		[property: JsonPropertyName("headline")] string headline,
		[property: JsonPropertyName("description")] string description,
		[property: JsonPropertyName("instruction")] string instruction,
		[property: JsonPropertyName("response")] string response,
		[property: JsonPropertyName("parameters")] AlertParameters parameters,
		[property: JsonPropertyName("replacedBy")] string replacedBy,
		[property: JsonPropertyName("replacedAt")] DateTime? replacedAt
	);

	public record AlertReference(
		[property: JsonPropertyName("@id")] string id,
		[property: JsonPropertyName("identifier")] string identifier,
		[property: JsonPropertyName("sender")] string sender,
		[property: JsonPropertyName("sent")] DateTime sent
	);

	public record AlertRoot(
		[property: JsonPropertyName("@context")] IReadOnlyList<object> context,
		[property: JsonPropertyName("type")] string type,
		[property: JsonPropertyName("features")] IReadOnlyList<AlertFeature> features,
		[property: JsonPropertyName("title")] string title,
		[property: JsonPropertyName("updated")] DateTime updated,
		[property: JsonPropertyName("pagination")] AlertPagination pagination
	);
#pragma warning enable
}
