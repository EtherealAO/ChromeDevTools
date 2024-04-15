namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	/// <summary>
	/// Tells whether browser supports workers inspection.
	/// </summary>
	[Command(ProtocolName.Worker.CanInspectWorkers)]
	[SupportedBy("iOS")]
	public class CanInspectWorkersCommand: ICommand<CanInspectWorkersCommandResponse>
	{
	}
}
