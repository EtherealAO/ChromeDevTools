using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Fetches the entire accessibility tree for the root Document
	/// </summary>
	[Command(ProtocolName.Accessibility.GetFullAXTree)]
	[SupportedBy("Chrome")]
	public class GetFullAXTreeCommand: ICommand<GetFullAXTreeCommandResponse>
	{
		/// <summary>
		/// Gets or sets The maximum depth at which descendants of the root node should be retrieved.
		/// If omitted, the full tree is returned.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Depth { get; set; }
		/// <summary>
		/// Gets or sets The frame for whose document the AX tree should be retrieved.
		/// If omited, the root frame is used.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
