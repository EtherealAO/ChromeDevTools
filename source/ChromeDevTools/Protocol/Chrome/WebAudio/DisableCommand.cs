namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Disables the WebAudio domain.
	/// </summary>
	[Command(ProtocolName.WebAudio.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
