namespace MasterDevs.ChromeDevTools.Protocol.iOS.Inspector
{
	/// <summary>
	/// Sent by the frontend after all initialization messages have been sent.
	/// </summary>
	[Command(ProtocolName.Inspector.Initialized)]
	[SupportedBy("iOS")]
	public class InitializedCommand: ICommand<InitializedCommandResponse>
	{
	}
}
