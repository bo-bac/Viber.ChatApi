using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Contact object.
	/// </summary>
	public class Contact
	{
		/// <summary>
		/// Name of the contact. Max 28 characters.
		/// </summary>
		[JsonPropertyName("name")]
		public string Name { get; set; } = default!;

        /// <summary>
        /// Phone number of the contact. Max 18 characters.
        /// </summary>
        [JsonPropertyName("phone_number")]
		public string TN { get; set; } = default!;
    }
}