using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position
	/// unavailable.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Page.SetGeolocationOverride)]
	[SupportedBy("Chrome")]
	public class SetGeolocationOverrideCommandResponse
	{
	}
}
