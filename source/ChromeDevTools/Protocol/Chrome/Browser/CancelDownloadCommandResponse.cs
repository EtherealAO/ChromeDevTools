namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Cancel a download if in progress
	/// </summary>
	[CommandResponse(ProtocolName.Browser.CancelDownload)]
	[SupportedBy("Chrome")]
	public class CancelDownloadCommandResponse
	{
	}
}
