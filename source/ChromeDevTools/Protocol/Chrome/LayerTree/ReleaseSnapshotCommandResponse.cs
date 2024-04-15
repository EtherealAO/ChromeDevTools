namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Releases layer snapshot captured by the back-end.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.ReleaseSnapshot)]
	[SupportedBy("Chrome")]
	public class ReleaseSnapshotCommandResponse
	{
	}
}
