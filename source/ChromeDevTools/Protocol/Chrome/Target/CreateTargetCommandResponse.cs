namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Creates a new page.
	/// </summary>
	[CommandResponse(ProtocolName.Target.CreateTarget)]
	[SupportedBy("Chrome")]
	public class CreateTargetCommandResponse
	{
		/// <summary>
		/// Gets or sets The id of the page opened.
		/// </summary>
		public string TargetId { get; set; }
	}
}
