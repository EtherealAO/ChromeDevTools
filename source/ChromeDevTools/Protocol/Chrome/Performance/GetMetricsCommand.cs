namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Performance
{
	/// <summary>
	/// Retrieve current values of run-time metrics.
	/// </summary>
	[Command(ProtocolName.Performance.GetMetrics)]
	[SupportedBy("Chrome")]
	public class GetMetricsCommand: ICommand<GetMetricsCommandResponse>
	{
	}
}
