namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	[CommandResponse(ProtocolName.Page.AddScriptToEvaluateOnLoad)]
	[SupportedBy("iOS")]
	public class AddScriptToEvaluateOnLoadCommandResponse
	{
		/// <summary>
		/// Gets or sets Identifier of the added script.
		/// </summary>
		public string Identifier { get; set; }
	}
}
