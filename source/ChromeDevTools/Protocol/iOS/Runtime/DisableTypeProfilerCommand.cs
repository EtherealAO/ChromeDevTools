namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Disables type profiling on the VM.
	/// </summary>
	[Command(ProtocolName.Runtime.DisableTypeProfiler)]
	[SupportedBy("iOS")]
	public class DisableTypeProfilerCommand: ICommand<DisableTypeProfilerCommandResponse>
	{
	}
}
