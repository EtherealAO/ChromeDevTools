namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position
	/// unavailable.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetGeolocationOverride)]
	[SupportedBy("Chrome")]
	public class SetGeolocationOverrideCommandResponse
	{
	}
}
