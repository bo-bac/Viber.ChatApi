using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Text message.
	/// </summary>
	public class TextMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TextMessage"/> class.
		/// </summary>
		public TextMessage()
			: base(MessageType.Text)
		{
		}

		/// <summary>
		/// The text of the message.
		/// </summary>
		[JsonPropertyName("text")]
		public string Text { get; set; } = default!;
    }
}