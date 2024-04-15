namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Disables type profiling on the VM.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.DisableTypeProfiler)]
	[SupportedBy("iOS")]
	public class DisableTypeProfilerCommandResponse
	{
	}
}
