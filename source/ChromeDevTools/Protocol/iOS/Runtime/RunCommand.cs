namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Tells inspected instance(worker or page) that it can run in case it was started paused.
	/// </summary>
	[Command(ProtocolName.Runtime.Run)]
	[SupportedBy("iOS")]
	public class RunCommand: ICommand<RunCommandResponse>
	{
	}
}
