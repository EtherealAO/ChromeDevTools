namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	/// <summary>
	/// Enables storage tracking, storage events will now be delivered to the client.
	/// </summary>
	[CommandResponse(ProtocolName.DOMStorage.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
