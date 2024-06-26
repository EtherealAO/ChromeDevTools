namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[Event(ProtocolName.Network.ReportingApiReportUpdated)]
	[SupportedBy("Chrome")]
	public class ReportingApiReportUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Report
		/// </summary>
		public ReportingApiReport Report { get; set; }
	}
}
