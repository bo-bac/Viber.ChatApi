using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Video message.
	/// </summary>
	public class VideoMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="VideoMessage"/> class.
		/// </summary>
		public VideoMessage()
			: base(MessageType.Video)
		{
		}

		/// <summary>
		/// URL of the video (MP4, H264). Max size 50 MB. Only MP4 and H264 are supported.
		/// </summary>
		[JsonPropertyName("media")]
		public string Media { get; set; } = default!;

		/// <summary>
		/// URL of a reduced size image (JPEG). Max size 100 kb. Recommended: 400x400. Only JPEG format is supported.
		/// </summary>
		[JsonPropertyName("thumbnail")]
		public string Thumbnail { get; set; } = default!;

        /// <summary>
        /// Size of the video in bytes.
        /// </summary>
        [JsonPropertyName("size")]
		public int Size { get; set; }

		/// <summary>
		/// Video duration in seconds; will be displayed to the receiver. Max 180 seconds.
		/// </summary>
		[JsonPropertyName("duration")]
		public int? Duration { get; set; }
	}
}