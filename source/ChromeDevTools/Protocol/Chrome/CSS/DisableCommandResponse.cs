namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Disables the CSS agent for the given page.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
