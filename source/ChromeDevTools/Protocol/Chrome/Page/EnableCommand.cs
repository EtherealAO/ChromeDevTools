namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Enables page domain notifications.
	/// </summary>
	[Command(ProtocolName.Page.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
