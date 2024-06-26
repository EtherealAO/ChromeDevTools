namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	[Event(ProtocolName.Page.LoadEventFired)]
	[SupportedBy("iOS")]
	public class LoadEventFiredEvent
	{
		/// <summary>
		/// Gets or sets Timestamp
		/// </summary>
		public double Timestamp { get; set; }
	}
}
