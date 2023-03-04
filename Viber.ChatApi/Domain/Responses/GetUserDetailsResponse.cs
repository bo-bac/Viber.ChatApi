using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Get User Details response.
	/// </summary>
	internal class GetUserDetailsResponse : ApiResponseBase
	{
		/// <summary>
		/// Unique id of the message.
		/// </summary>
		/// <remarks>API nothing returns.</remarks>
		[JsonPropertyName("message_token")]
		public long MessageToken { get; set; }

		/// <summary>
		/// User details.
		/// </summary>
		[JsonPropertyName("user")]
		public UserDetails User { get; set; } = default!;
    }
}