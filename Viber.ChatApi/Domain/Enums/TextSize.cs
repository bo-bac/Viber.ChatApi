using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Text size.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum TextSize
	{
		/// <summary>
		/// Size 'small'.
		/// </summary>
		[EnumMember(Value = "small")]
		Small = 1,

		/// <summary>
		/// Size 'regular'.
		/// </summary>
		[EnumMember(Value = "regular")]
		Regular = 2,

		/// <summary>
		/// Size 'large'.
		/// </summary>
		[EnumMember(Value = "large")]
		Large = 3
	}
}