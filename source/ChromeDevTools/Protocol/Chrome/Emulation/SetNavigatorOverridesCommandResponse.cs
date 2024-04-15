using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides value returned by the javascript navigator object.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Emulation.SetNavigatorOverrides)]
	[SupportedBy("Chrome")]
	public class SetNavigatorOverridesCommandResponse
	{
	}
}
