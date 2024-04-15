using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Enables headless events for the target.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.HeadlessExperimental.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
