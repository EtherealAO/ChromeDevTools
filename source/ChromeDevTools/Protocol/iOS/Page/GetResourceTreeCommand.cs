namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Returns present frame / resource tree structure.
	/// </summary>
	[Command(ProtocolName.Page.GetResourceTree)]
	[SupportedBy("iOS")]
	public class GetResourceTreeCommand: ICommand<GetResourceTreeCommandResponse>
	{
	}
}
