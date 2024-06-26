using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Emitted only when `page.interceptFileChooser` is enabled.
	/// </summary>
	[Event(ProtocolName.Page.FileChooserOpened)]
	[SupportedBy("Chrome")]
	public class FileChooserOpenedEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame containing input node.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Input mode.
		/// </summary>
		public string Mode { get; set; }
		/// <summary>
		/// Gets or sets Input node id. Only present for file choosers opened via an <input type="file"> element.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
	}
}
