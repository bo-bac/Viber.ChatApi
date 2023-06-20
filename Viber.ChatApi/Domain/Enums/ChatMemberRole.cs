using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
    /// <summary>
    /// Chat member role.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ChatMemberRole
    {
        /// <summary>
        /// Role "admin".
        /// </summary>
        Admin = 1,

        /// <summary>
        /// Role "participant".
        /// </summary>
        Participant = 2
    }
}