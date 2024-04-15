namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Returns the snapshot identifier.
	/// </summary>
	[Command(ProtocolName.LayerTree.LoadSnapshot)]
	[SupportedBy("Chrome")]
	public class LoadSnapshotCommand: ICommand<LoadSnapshotCommandResponse>
	{
		/// <summary>
		/// Gets or sets An array of tiles composing the snapshot.
		/// </summary>
		public PictureTile[] Tiles { get; set; }
	}
}
