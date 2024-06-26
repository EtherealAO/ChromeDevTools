using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Moves node into the new container, places it before the given anchor.
	/// </summary>
	[Command(ProtocolName.DOM.MoveTo)]
	[SupportedBy("Chrome")]
	public class MoveToCommand: ICommand<MoveToCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to move.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Id of the element to drop the moved node into.
		/// </summary>
		public long TargetNodeId { get; set; }
		/// <summary>
		/// Gets or sets Drop node before this one (if absent, the moved node becomes the last child of
		/// `targetNodeId`).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? InsertBeforeNodeId { get; set; }
	}
}
