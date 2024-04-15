namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	/// Enables the Media domain
	/// </summary>
	[Command(ProtocolName.Media.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
