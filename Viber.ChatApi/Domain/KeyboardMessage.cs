using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Keyboard message.
	/// </summary>
	public class KeyboardMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="KeyboardMessage"/> class.
		/// </summary>
		public KeyboardMessage()
			: base(MessageType.Text)
		{
		}

		/// <summary>
		/// The text of the message.
		/// </summary>
		[JsonPropertyName("text")]
		public string Text { get; set; } = default!;

        /// <summary>
        /// Keyboard object.
        /// </summary>
        [JsonPropertyName("keyboard")]
		public Keyboard Keyboard { get; set; } = default!;
    }
}