using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Disables headless events for the target.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.HeadlessExperimental.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
