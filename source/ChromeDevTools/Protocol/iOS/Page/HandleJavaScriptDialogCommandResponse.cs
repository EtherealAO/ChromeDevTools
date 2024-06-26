namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
	/// </summary>
	[CommandResponse(ProtocolName.Page.HandleJavaScriptDialog)]
	[SupportedBy("iOS")]
	public class HandleJavaScriptDialogCommandResponse
	{
	}
}
