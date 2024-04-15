namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Performance
{
	/// <summary>
	/// Retrieve current values of run-time metrics.
	/// </summary>
	[CommandResponse(ProtocolName.Performance.GetMetrics)]
	[SupportedBy("Chrome")]
	public class GetMetricsCommandResponse
	{
		/// <summary>
		/// Gets or sets Current values for run-time metrics.
		/// </summary>
		public Metric[] Metrics { get; set; }
	}
}
