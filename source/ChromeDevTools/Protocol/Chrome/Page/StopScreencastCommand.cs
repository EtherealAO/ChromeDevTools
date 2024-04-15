namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Stops sending each frame in the `screencastFrame`.
	/// </summary>
	[Command(ProtocolName.Page.StopScreencast)]
	[SupportedBy("Chrome")]
	public class StopScreencastCommand: ICommand<StopScreencastCommandResponse>
	{
	}
}
