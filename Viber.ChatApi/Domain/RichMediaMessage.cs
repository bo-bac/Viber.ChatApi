using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Rich Media message.
    /// </summary>
    public class RichMediaMessage : MessageBase
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="RichMediaMessage"/> class.
        /// </summary>
        public RichMediaMessage()
			: base(MessageType.CarouselContent)
		{
		}

        /// <summary>
		/// Backward compatibility text, limited to 7,000 characters
		/// </summary>
		[JsonPropertyName("alt_text")]
        public string Text { get; set; } = default!;

        /// <summary>
        /// RichMedia object.
        /// </summary>
        [JsonPropertyName("rich_media")]
		public RichMedia RichMedia { get; set; } = default!;
    }
}