namespace Viber.ChatApi;

/// <summary>
/// Ok API response.
/// </summary>
public class OkResponse : ApiResponseBase
{
	public OkResponse()
	{
		Status = ErrorCode.Ok;
		StatusMessage = "ok";
	}
}