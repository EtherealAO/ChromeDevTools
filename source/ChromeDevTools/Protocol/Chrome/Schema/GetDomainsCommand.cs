namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Schema
{
	/// <summary>
	/// Returns supported domains.
	/// </summary>
	[Command(ProtocolName.Schema.GetDomains)]
	[SupportedBy("Chrome")]
	public class GetDomainsCommand: ICommand<GetDomainsCommandResponse>
	{
	}
}
