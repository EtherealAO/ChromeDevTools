namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Performance
{
	/// <summary>
	/// Disable collecting and reporting metrics.
	/// </summary>
	[Command(ProtocolName.Performance.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
