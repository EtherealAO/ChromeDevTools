namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Enables the WebAudio domain and starts sending context lifetime events.
	/// </summary>
	[CommandResponse(ProtocolName.WebAudio.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
