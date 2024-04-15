namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Disables tracking security state changes.
	/// </summary>
	[CommandResponse(ProtocolName.Security.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
