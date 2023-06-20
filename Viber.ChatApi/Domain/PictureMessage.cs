using System;

using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Picture message.
    /// </summary>
    public class PictureMessage : MessageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PictureMessage"/> class.
        /// </summary>
        public PictureMessage()
            : base(MessageType.Picture)
        {
            Text = String.Empty;
        }

        /// <summary>
        /// The text of the message.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// URL of the image (JPEG).
        /// </summary>
        [JsonPropertyName("media")]
        public string Media { get; set; } = default!;

        /// <summary>
        /// URL of a reduced size image (JPEG).
        /// </summary>
        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; } = default!;
    }
}