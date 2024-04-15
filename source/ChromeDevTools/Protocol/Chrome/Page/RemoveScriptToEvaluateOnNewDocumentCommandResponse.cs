namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Removes given script from the list.
	/// </summary>
	[CommandResponse(ProtocolName.Page.RemoveScriptToEvaluateOnNewDocument)]
	[SupportedBy("Chrome")]
	public class RemoveScriptToEvaluateOnNewDocumentCommandResponse
	{
	}
}
