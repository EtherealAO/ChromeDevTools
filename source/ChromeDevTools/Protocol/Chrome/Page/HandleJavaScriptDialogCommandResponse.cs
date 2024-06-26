namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
	/// </summary>
	[CommandResponse(ProtocolName.Page.HandleJavaScriptDialog)]
	[SupportedBy("Chrome")]
	public class HandleJavaScriptDialogCommandResponse
	{
	}
}
