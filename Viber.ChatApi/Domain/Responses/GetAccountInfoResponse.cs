using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Get Account Info response.
    /// </summary>
    internal class GetAccountInfoResponse : ApiResponseBase, IAccountInfo
    {
        /// <inheritdoc />
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <inheritdoc />
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <inheritdoc />
        [JsonPropertyName("uri")]
        public string Uri { get; set; } = default!;

        /// <inheritdoc />
        [JsonPropertyName("icon")]
        public string Icon { get; set; } = default!;

        /// <inheritdoc />
        [JsonPropertyName("background")]
        public string Background { get; set; } = default!;

        /// <inheritdoc />
        [JsonPropertyName("category")]
        public string Category { get; set; } = default!;

        /// <inheritdoc />
        [JsonPropertyName("subcategory")]
        public string Subcategory { get; set; } = default!;

        /// <inheritdoc />
        [JsonPropertyName("event_types")]
        public ICollection<EventType> EventTypes { get; set; } = default!;

        /// <inheritdoc />
        [JsonPropertyName("location")]
        public Location Location { get; set; } = default!;

        /// <inheritdoc />
        [JsonPropertyName("country")]
        public string Country { get; set; } = default!;

        /// <inheritdoc />
        [JsonPropertyName("webhook")]
        public string Webhook { get; set; } = default!;

        /// <inheritdoc />
        [JsonPropertyName("subscribers_count")]
        public long SubscribersCount { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("members")]
        public ICollection<ChatMember> Members { get; set; } = default!;
    }
}