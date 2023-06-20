using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Determine the open-url action result, in app or external browser.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum OpenUrlType
    {
        /// <summary>
        /// Type 'internal'.
        /// </summary>
        [EnumMember(Value = "internal")]
        Internal = 1,

        /// <summary>
        /// Type 'external'.
        /// </summary>
        [EnumMember(Value = "external")]
        External = 2
    }
}