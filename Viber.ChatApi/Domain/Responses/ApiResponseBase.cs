using System.Text.Json.Serialization;

namespace Viber.ChatApi;

/// <summary>
/// Base API response.
/// </summary>
public abstract class ApiResponseBase
{
	/// <summary>
	/// Action result.
	/// </summary>
	[JsonPropertyName("status")]
	public ErrorCode Status { get; set; }

	/// <summary>
	/// Ok or failure reason.
	/// </summary>
	[JsonPropertyName("status_message")]
	public string StatusMessage { get; set; } = default!;
    }