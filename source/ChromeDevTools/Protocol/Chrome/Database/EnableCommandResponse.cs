namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Database
{
	/// <summary>
	/// Enables database tracking, database events will now be delivered to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Database.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
