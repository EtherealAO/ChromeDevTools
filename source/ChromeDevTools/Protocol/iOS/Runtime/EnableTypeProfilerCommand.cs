namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Enables type profiling on the VM.
	/// </summary>
	[Command(ProtocolName.Runtime.EnableTypeProfiler)]
	[SupportedBy("iOS")]
	public class EnableTypeProfilerCommand: ICommand<EnableTypeProfilerCommandResponse>
	{
	}
}
