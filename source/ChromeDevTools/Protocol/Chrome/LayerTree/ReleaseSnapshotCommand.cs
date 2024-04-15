namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Releases layer snapshot captured by the back-end.
	/// </summary>
	[Command(ProtocolName.LayerTree.ReleaseSnapshot)]
	[SupportedBy("Chrome")]
	public class ReleaseSnapshotCommand: ICommand<ReleaseSnapshotCommandResponse>
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
