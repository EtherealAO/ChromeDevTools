namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Disables reporting of execution contexts creation.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommandResponse
	{
	}
}
