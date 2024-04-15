namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Removes node with given id.
	/// </summary>
	[Command(ProtocolName.DOM.RemoveNode)]
	[SupportedBy("iOS")]
	public class RemoveNodeCommand: ICommand<RemoveNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to remove.
		/// </summary>
		public long NodeId { get; set; }
	}
}
