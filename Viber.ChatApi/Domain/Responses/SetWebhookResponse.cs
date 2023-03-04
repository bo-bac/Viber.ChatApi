using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace Viber.ChatApi
{
	/// <summary>
	/// Set webhook Response.
	/// </summary>
	internal class SetWebhookResponse : ApiResponseBase
	{
		/// <summary>
		/// List of event types you will receive a callback for. Should return the same values sent in the request.
		/// </summary>
		[JsonPropertyName("event_types")]
		public ICollection<EventType> EventTypes { get; set; } = default!;
    }
}