using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Base user info.
	/// </summary>
	public class UserBase : IUserBase
	{
		/// <inheritdoc />
		[JsonPropertyName("name")]
		public string Name { get; set; } = default!;

        /// <inheritdoc />
        [JsonPropertyName("avatar")]
		public string Avatar { get; set; } = default!;
    }
}