using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Horizontal align of the text.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum TextHorizontalAlign
	{
		/// <summary>
		/// Align 'left'.
		/// </summary>
		[EnumMember(Value = "left")]
		Left = 1,

		/// <summary>
		/// Align 'center'.
		/// </summary>
		[EnumMember(Value = "center")]
		Center = 2,

		/// <summary>
		/// Align 'right'.
		/// </summary>
		[EnumMember(Value = "right")]
		Right = 3
	}
}