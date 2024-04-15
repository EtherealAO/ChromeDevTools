namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	[Command(ProtocolName.FedCm.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
