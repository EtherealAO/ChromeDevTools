namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Runs the contrast check for the target page. Found issues are reported
	/// using Audits.issueAdded event.
	/// </summary>
	[CommandResponse(ProtocolName.Audits.CheckContrast)]
	[SupportedBy("Chrome")]
	public class CheckContrastCommandResponse
	{
	}
}
