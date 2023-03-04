using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Viber.ChatApi;


/// <inheritdoc />
internal class GetOnlineResponse : ApiResponseBase
{
    /// <inheritdoc />
    [JsonPropertyName("users")]
    public ICollection<UserOnlineStatus> UsersOnlineStatus { get; set; } = default!;
}