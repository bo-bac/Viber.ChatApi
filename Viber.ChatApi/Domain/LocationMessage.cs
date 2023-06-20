using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Location message.
    /// </summary>
    public class LocationMessage : MessageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationMessage"/> class.
        /// </summary>
        public LocationMessage()
            : base(MessageType.Location)
        {
        }

        /// <summary>
        /// Location data.
        /// </summary>
        [JsonPropertyName("location")]
        public Location Location { get; set; } = default!;
    }
}