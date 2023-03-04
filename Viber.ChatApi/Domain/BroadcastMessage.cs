using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Broadcast message.
	/// </summary>
	public class BroadcastMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BroadcastMessage"/> class.
		/// </summary>
		public BroadcastMessage()
			: base(MessageType.Text)
		{
		}

		/// <summary>
		/// The text of the message.
		/// </summary>
		[JsonPropertyName("text")]
		public string? Text { get; set; }

		/// <summary>
		/// The list of accounts identifiers to send messages to multiple Viber users (who subscribed to the account).
		/// </summary>
		[JsonPropertyName("broadcast_list")]
		public IList<string>? BroadcastList { get; set; }
	}
}