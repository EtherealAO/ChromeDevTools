namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[Command(ProtocolName.Page.GetAdScriptId)]
	[SupportedBy("Chrome")]
	public class GetAdScriptIdCommand: ICommand<GetAdScriptIdCommandResponse>
	{
		/// <summary>
		/// Gets or sets FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
