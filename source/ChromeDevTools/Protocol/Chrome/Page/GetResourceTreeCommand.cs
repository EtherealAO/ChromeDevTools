namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns present frame / resource tree structure.
	/// </summary>
	[Command(ProtocolName.Page.GetResourceTree)]
	[SupportedBy("Chrome")]
	public class GetResourceTreeCommand: ICommand<GetResourceTreeCommandResponse>
	{
	}
}
