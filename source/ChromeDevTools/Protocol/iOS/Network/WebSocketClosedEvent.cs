namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Fired when WebSocket is closed.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketClosed)]
	[SupportedBy("iOS")]
	public class WebSocketClosedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
	}
}
