using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Type of the background media.
	/// </summary>
	[JsonConverter(typeof(JsonStringEnumMemberConverter))]
	public enum BackgroundMediaType
	{
		/// <summary>
		/// JPEG and PNG files.
		/// </summary>
		[EnumMember(Value = "picture")]
		Picture = 1,

		/// <summary>
		/// GIF files.
		/// </summary>
		[EnumMember(Value = "gif")]
		Gif = 2
	}
}