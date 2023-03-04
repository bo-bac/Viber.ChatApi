using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Send message response.
	/// </summary>
	internal class SendMessageResponse : ApiResponseBase
	{
		/// <summary>
		/// Unique id of the message.
		/// </summary>
		[JsonPropertyName("message_token")]
		public long MessageToken { get; set; }
	}
}