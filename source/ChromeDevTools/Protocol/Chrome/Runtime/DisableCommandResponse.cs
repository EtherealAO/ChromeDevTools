namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Disables reporting of execution contexts creation.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
