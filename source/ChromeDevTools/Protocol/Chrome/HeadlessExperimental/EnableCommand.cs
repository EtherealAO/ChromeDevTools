using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Enables headless events for the target.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.HeadlessExperimental.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
