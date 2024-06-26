namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Enables page domain notifications.
	/// </summary>
	[Command(ProtocolName.Page.Enable)]
	[SupportedBy("iOS")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
