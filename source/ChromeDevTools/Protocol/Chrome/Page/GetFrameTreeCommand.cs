namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns present frame tree structure.
	/// </summary>
	[Command(ProtocolName.Page.GetFrameTree)]
	[SupportedBy("Chrome")]
	public class GetFrameTreeCommand: ICommand<GetFrameTreeCommandResponse>
	{
	}
}
