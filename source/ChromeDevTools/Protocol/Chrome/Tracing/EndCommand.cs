namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Stop trace events collection.
	/// </summary>
	[Command(ProtocolName.Tracing.End)]
	[SupportedBy("Chrome")]
	public class EndCommand: ICommand<EndCommandResponse>
	{
	}
}
