namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Ensures that the given node will have specified pseudo-classes whenever its style is computed by the browser.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.ForcePseudoState)]
	[SupportedBy("iOS")]
	public class ForcePseudoStateCommandResponse
	{
	}
}
