using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Chat member.
	/// </summary>
	public class ChatMember : UserBase
	{
		/// <summary>
		/// Unique Viber user id.
		/// </summary>
		[JsonPropertyName("id")]
		public string Id { get; set; } = default!;

        /// <summary>
        /// Chat member role.
        /// </summary>
        [JsonPropertyName("role")]
		public ChatMemberRole Role { get; set; }
	}
}