using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Viber user details.
	/// </summary>
	public class UserDetails : User
	{
		/// <summary>
		/// The operating system type and version of the user’s primary device.
		/// </summary>
		[JsonPropertyName("primary_device_os")]
		public string PrimaryDeviceOS { get; set; } = default!;

        /// <summary>
        /// The Viber version installed on the user’s primary device.
        /// </summary>
        [JsonPropertyName("viber_version")]
		public string ViberVersion { get; set; } = default!;

        /// <summary>
        /// Mobile country code.
        /// </summary>
        [JsonPropertyName("mcc")]
		public int Mcc { get; set; }

		/// <summary>
		/// Mobile network code.
		/// </summary>
		[JsonPropertyName("mnc")]
		public int Mnc { get; set; }

		/// <summary>
		/// The user’s device type.
		/// </summary>
		[JsonPropertyName("device_type")]
		public string DeviceType { get; set; } = default!;
    }
}