namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Ignores input events (useful while auditing page).
	/// </summary>
	[CommandResponse(ProtocolName.Input.SetIgnoreInputEvents)]
	[SupportedBy("Chrome")]
	public class SetIgnoreInputEventsCommandResponse
	{
	}
}
