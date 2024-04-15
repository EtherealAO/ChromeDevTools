namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	/// <summary>
	/// Enables storage tracking, storage events will now be delivered to the client.
	/// </summary>
	[CommandResponse(ProtocolName.DOMStorage.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommandResponse
	{
	}
}
