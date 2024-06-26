namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns attributes for the specified node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetAttributes)]
	[SupportedBy("Chrome")]
	public class GetAttributesCommandResponse
	{
		/// <summary>
		/// Gets or sets An interleaved array of node attribute names and values.
		/// </summary>
		public string[] Attributes { get; set; }
	}
}
