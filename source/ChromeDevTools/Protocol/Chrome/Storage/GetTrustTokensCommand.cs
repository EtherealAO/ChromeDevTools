namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Returns the number of stored Trust Tokens per issuer for the
	/// current browsing context.
	/// </summary>
	[Command(ProtocolName.Storage.GetTrustTokens)]
	[SupportedBy("Chrome")]
	public class GetTrustTokensCommand: ICommand<GetTrustTokensCommandResponse>
	{
	}
}
