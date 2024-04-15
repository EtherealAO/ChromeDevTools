namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Clears the overridden Geolocation Position and Error.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.ClearGeolocationOverride)]
	[SupportedBy("Chrome")]
	public class ClearGeolocationOverrideCommandResponse
	{
	}
}
