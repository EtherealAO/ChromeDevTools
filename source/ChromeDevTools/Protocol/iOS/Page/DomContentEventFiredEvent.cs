namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	[Event(ProtocolName.Page.DomContentEventFired)]
	[SupportedBy("iOS")]
	public class DomContentEventFiredEvent
	{
		/// <summary>
		/// Gets or sets Timestamp
		/// </summary>
		public double Timestamp { get; set; }
	}
}
