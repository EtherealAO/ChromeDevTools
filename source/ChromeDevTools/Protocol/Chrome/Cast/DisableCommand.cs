namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Stops observing for sinks and issues.
	/// </summary>
	[Command(ProtocolName.Cast.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
