namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	/// <summary>
	/// Disables storage tracking, prevents storage events from being sent to the client.
	/// </summary>
	[CommandResponse(ProtocolName.DOMStorage.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
