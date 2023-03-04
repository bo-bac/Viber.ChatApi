using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Sticker message.
	/// </summary>
	public class StickerMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="StickerMessage"/> class.
		/// </summary>
		public StickerMessage()
			: base(MessageType.Sticker)
		{
		}

		/// <summary>
		/// Unique Viber sticker ID.
		/// </summary>
		[JsonPropertyName("sticker_id")]
		public string StickerId { get; set; } = default!;
    }
}