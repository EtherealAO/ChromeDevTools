namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Grant specific permissions to the given origin and reject all others.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.GrantPermissions)]
	[SupportedBy("Chrome")]
	public class GrantPermissionsCommandResponse
	{
	}
}
