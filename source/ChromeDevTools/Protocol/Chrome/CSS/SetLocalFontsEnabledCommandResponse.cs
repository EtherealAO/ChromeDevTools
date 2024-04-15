namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Enables/disables rendering of local CSS fonts (enabled by default).
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetLocalFontsEnabled)]
	[SupportedBy("Chrome")]
	public class SetLocalFontsEnabledCommandResponse
	{
	}
}
