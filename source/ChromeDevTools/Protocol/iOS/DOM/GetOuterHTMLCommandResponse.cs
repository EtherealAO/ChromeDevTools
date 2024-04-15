namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Returns node's HTML markup.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetOuterHTML)]
	[SupportedBy("iOS")]
	public class GetOuterHTMLCommandResponse
	{
		/// <summary>
		/// Gets or sets Outer HTML markup.
		/// </summary>
		public string OuterHTML { get; set; }
	}
}
