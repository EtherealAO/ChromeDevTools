namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Enables log domain, sends the entries collected so far to the client by means of the
	/// `entryAdded` notification.
	/// </summary>
	[CommandResponse(ProtocolName.Log.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
