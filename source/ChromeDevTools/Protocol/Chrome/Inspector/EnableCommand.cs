namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Inspector
{
	/// <summary>
	/// Enables inspector domain notifications.
	/// </summary>
	[Command(ProtocolName.Inspector.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
