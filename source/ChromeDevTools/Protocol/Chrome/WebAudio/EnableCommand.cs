namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Enables the WebAudio domain and starts sending context lifetime events.
	/// </summary>
	[Command(ProtocolName.WebAudio.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
