namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Override quota for the specified origin
	/// </summary>
	[CommandResponse(ProtocolName.Storage.OverrideQuotaForOrigin)]
	[SupportedBy("Chrome")]
	public class OverrideQuotaForOriginCommandResponse
	{
	}
}
