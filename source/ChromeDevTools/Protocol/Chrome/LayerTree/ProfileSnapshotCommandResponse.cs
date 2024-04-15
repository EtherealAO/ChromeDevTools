namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	[CommandResponse(ProtocolName.LayerTree.ProfileSnapshot)]
	[SupportedBy("Chrome")]
	public class ProfileSnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets The array of paint profiles, one per run.
		/// </summary>
		public double[][] Timings { get; set; }
	}
}
