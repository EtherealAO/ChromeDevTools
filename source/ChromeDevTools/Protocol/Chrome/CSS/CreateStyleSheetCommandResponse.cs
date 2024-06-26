namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Creates a new special "via-inspector" stylesheet in the frame with given `frameId`.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.CreateStyleSheet)]
	[SupportedBy("Chrome")]
	public class CreateStyleSheetCommandResponse
	{
		/// <summary>
		/// Gets or sets Identifier of the created "via-inspector" stylesheet.
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
