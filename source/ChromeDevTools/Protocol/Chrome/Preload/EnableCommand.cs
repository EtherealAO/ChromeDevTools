namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	[Command(ProtocolName.Preload.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResponse>
	{
	}
}
