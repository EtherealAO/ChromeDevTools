namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Capture a snapshot of the specified node that does not include unrelated layers.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SnapshotNode)]
	[SupportedBy("iOS")]
	public class SnapshotNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Base64-encoded image data (PNG).
		/// </summary>
		public string DataURL { get; set; }
	}
}
