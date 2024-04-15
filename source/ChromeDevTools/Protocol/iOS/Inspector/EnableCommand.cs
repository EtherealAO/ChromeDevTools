namespace MasterDevs.ChromeDevTools.Protocol.iOS.Inspector
{
	/// <summary>
	/// Enables inspector domain notifications.
	/// </summary>
	[Command(ProtocolName.Inspector.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
