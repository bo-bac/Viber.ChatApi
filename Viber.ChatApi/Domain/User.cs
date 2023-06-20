using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Viber user.
    /// </summary>
    public class User : UserBase
    {
        /// <summary>
        /// Unique Viber user id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// User’s 2 letter country code.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; } = default!;

        /// <summary>
        /// User’s phone language.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Max API version, matching the most updated user’s device.
        /// </summary>
        [JsonPropertyName("api_version")]
        public double ApiVersion { get; set; }
    }
}