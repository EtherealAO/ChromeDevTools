namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Returns information about the system.
	/// </summary>
	[Command(ProtocolName.SystemInfo.GetInfo)]
	[SupportedBy("Chrome")]
	public class GetInfoCommand: ICommand<GetInfoCommandResponse>
	{
	}
}
