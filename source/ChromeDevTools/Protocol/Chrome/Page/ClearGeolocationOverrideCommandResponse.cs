using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears the overridden Geolocation Position and Error.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Page.ClearGeolocationOverride)]
	[SupportedBy("Chrome")]
	public class ClearGeolocationOverrideCommandResponse
	{
	}
}
