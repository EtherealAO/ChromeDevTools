namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Returns the layer snapshot identifier.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.MakeSnapshot)]
	[SupportedBy("Chrome")]
	public class MakeSnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
