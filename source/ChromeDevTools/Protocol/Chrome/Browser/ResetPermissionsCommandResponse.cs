namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Reset all permission management for all origins.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.ResetPermissions)]
	[SupportedBy("Chrome")]
	public class ResetPermissionsCommandResponse
	{
	}
}
