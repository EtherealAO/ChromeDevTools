namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Grab an archive of the page.
	/// </summary>
	[Command(ProtocolName.Page.Archive)]
	[SupportedBy("iOS")]
	public class ArchiveCommand: ICommand<ArchiveCommandResponse>
	{
	}
}
