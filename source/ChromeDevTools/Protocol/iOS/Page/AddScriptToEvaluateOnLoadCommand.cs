namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	[Command(ProtocolName.Page.AddScriptToEvaluateOnLoad)]
	[SupportedBy("iOS")]
	public class AddScriptToEvaluateOnLoadCommand: ICommand<AddScriptToEvaluateOnLoadCommandResponse>
	{
		/// <summary>
		/// Gets or sets ScriptSource
		/// </summary>
		public string ScriptSource { get; set; }
	}
}
