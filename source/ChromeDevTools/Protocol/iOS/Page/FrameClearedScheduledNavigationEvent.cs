namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Fired when frame no longer has a scheduled navigation.
	/// </summary>
	[Event(ProtocolName.Page.FrameClearedScheduledNavigation)]
	[SupportedBy("iOS")]
	public class FrameClearedScheduledNavigationEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has cleared its scheduled navigation.
		/// </summary>
		public string FrameId { get; set; }
	}
}
