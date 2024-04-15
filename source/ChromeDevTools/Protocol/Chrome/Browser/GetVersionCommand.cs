namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Returns version information.
	/// </summary>
	[Command(ProtocolName.Browser.GetVersion)]
	[SupportedBy("Chrome")]
	public class GetVersionCommand: ICommand<GetVersionCommandResponse>
	{
	}
}
