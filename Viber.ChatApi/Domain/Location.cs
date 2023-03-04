using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Location (coordinates).
	/// </summary>
	public class Location
	{
		/// <summary>
		/// Longitude of the <see cref="Location"/>.
		/// </summary>
		[JsonPropertyName("lon")]
		public double Lon { get; set; }

		/// <summary>
		/// Latitude of the <see cref="Location"/>.
		/// </summary>
		[JsonPropertyName("lat")]
		public double Lat { get; set; }
	}
}