namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[Command(ProtocolName.Page.GetInstallabilityErrors)]
	[SupportedBy("Chrome")]
	public class GetInstallabilityErrorsCommand: ICommand<GetInstallabilityErrorsCommandResponse>
	{
	}
}
