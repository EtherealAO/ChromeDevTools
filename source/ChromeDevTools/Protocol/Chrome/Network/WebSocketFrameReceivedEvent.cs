namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when WebSocket message is received.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketFrameReceived)]
	[SupportedBy("Chrome")]
	public class WebSocketFrameReceivedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets WebSocket response data.
		/// </summary>
		public WebSocketFrame Response { get; set; }
	}
}
