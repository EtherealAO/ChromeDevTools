namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Returns all media queries parsed by the rendering engine.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetMediaQueries)]
	[SupportedBy("Chrome")]
	public class GetMediaQueriesCommandResponse
	{
		/// <summary>
		/// Gets or sets Medias
		/// </summary>
		public CSSMedia[] Medias { get; set; }
	}
}
