using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Contact message.
	/// </summary>
	public class ContactMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactMessage"/> class.
		/// </summary>
		public ContactMessage()
			: base(MessageType.Contact)
		{
		}

        /// <summary>
        /// The text of the message.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Contact object.
        /// </summary>
        [JsonPropertyName("contact")]
		public Contact Contact { get; set; } = default!;
    }
}