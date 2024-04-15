using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Tells whether emulation of network conditions is supported.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Network.CanEmulateNetworkConditions)]
	[SupportedBy("Chrome")]
	public class CanEmulateNetworkConditionsCommand: ICommand<CanEmulateNetworkConditionsCommandResponse>
	{
	}
}
