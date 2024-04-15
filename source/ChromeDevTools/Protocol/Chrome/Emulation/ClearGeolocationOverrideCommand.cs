namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Clears the overridden Geolocation Position and Error.
	/// </summary>
	[Command(ProtocolName.Emulation.ClearGeolocationOverride)]
	[SupportedBy("Chrome")]
	public class ClearGeolocationOverrideCommand: ICommand<ClearGeolocationOverrideCommandResponse>
	{
	}
}
