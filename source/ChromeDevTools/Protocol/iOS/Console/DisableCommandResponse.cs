namespace MasterDevs.ChromeDevTools.Protocol.iOS.Console
{
	/// <summary>
	/// Disables console domain, prevents further console messages from being reported to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Console.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommandResponse
	{
	}
}
