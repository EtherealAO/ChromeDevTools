namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[Command(ProtocolName.Page.GetAppManifest)]
	[SupportedBy("Chrome")]
	public class GetAppManifestCommand: ICommand<GetAppManifestCommandResponse>
	{
	}
}
