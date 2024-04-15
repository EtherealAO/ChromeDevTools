namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Enables the accessibility domain which causes `AXNodeId`s to remain consistent between method calls.
	/// This turns on accessibility for the page, which can impact performance until accessibility is disabled.
	/// </summary>
	[CommandResponse(ProtocolName.Accessibility.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
