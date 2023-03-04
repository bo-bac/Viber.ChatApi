using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Vertical alignment of the text.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum TextVerticalAlign
	{
		/// <summary>
		/// Align 'top'.
		/// </summary>
		[EnumMember(Value = "top")]
		Top = 1,

		/// <summary>
		/// Align 'middle'.
		/// </summary>
		[EnumMember(Value = "middle")]
		Middle = 2,

		/// <summary>
		/// Align 'bottom'.
		/// </summary>
		[EnumMember(Value = "bottom")]
		Bottom = 3
	}
}