using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Viber user online status.
    /// </summary>
    public class UserOnlineStatus
    {
        /// <summary>
        /// Unique Viber user id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Online status code.
        /// </summary>
        [JsonPropertyName("online_status")]
        public UserOnlineStatusCode Status { get; set; }

        /// <summary>
        /// Online status message.
        /// </summary>
        [JsonPropertyName("online_status_message")]
        public string StatusMessage { get; set; } = default!;

        /// <summary>
        /// Last online.
        /// </summary>
        [JsonPropertyName("last_online")]
        public long LastOnline { get; set; }
    }
}