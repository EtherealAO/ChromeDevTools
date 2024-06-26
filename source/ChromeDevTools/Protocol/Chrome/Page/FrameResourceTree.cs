using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Information about the Frame hierarchy along with their cached resources.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FrameResourceTree
	{
		/// <summary>
		/// Gets or sets Frame information for this tree item.
		/// </summary>
		public Frame Frame { get; set; }
		/// <summary>
		/// Gets or sets Child frames.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FrameResourceTree[] ChildFrames { get; set; }
		/// <summary>
		/// Gets or sets Information about frame resources.
		/// </summary>
		public FrameResource[] Resources { get; set; }
	}
}
