using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	/// Disables headless events for the target.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.HeadlessExperimental.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
