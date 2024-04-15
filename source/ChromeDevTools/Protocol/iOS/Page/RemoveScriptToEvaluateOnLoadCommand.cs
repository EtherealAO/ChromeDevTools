namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	[Command(ProtocolName.Page.RemoveScriptToEvaluateOnLoad)]
	[SupportedBy("iOS")]
	public class RemoveScriptToEvaluateOnLoadCommand: ICommand<RemoveScriptToEvaluateOnLoadCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier
		/// </summary>
		public string Identifier { get; set; }
	}
}
