namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Returns the computed style for a DOM node identified by `nodeId`.
	/// </summary>
	[Command(ProtocolName.CSS.GetComputedStyleForNode)]
	[SupportedBy("Chrome")]
	public class GetComputedStyleForNodeCommand: ICommand<GetComputedStyleForNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public long NodeId { get; set; }
	}
}
