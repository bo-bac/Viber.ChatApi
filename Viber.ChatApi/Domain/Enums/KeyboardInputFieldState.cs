using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Keyboard input field state.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum KeyboardInputFieldState
    {
        /// <summary>
        /// Display regular size input field.
        /// </summary>
        [EnumMember(Value = "regular")]
        Regular = 1,

        /// <summary>
        /// Display input field minimized by default.
        /// </summary>
        [EnumMember(Value = "minimized")]
        Minimized = 2,

        /// <summary>
        /// Hide the input field.
        /// </summary>
        [EnumMember(Value = "hidden")]
        Hidden = 3
    }
}