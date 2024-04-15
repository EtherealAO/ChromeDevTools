namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Returns the current textual content for a stylesheet.
	/// </summary>
	[Command(ProtocolName.CSS.GetStyleSheetText)]
	[SupportedBy("Chrome")]
	public class GetStyleSheetTextCommand: ICommand<GetStyleSheetTextCommandResponse>
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
