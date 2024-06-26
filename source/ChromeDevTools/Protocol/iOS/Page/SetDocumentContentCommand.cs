namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Sets given markup as the document's HTML.
	/// </summary>
	[Command(ProtocolName.Page.SetDocumentContent)]
	[SupportedBy("iOS")]
	public class SetDocumentContentCommand: ICommand<SetDocumentContentCommandResponse>
	{
		/// <summary>
		/// Gets or sets Frame id to set HTML for.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets HTML content to set.
		/// </summary>
		public string Html { get; set; }
	}
}
