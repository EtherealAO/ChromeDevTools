namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Re-does the last undone action.
	/// </summary>
	[Command(ProtocolName.DOM.Redo)]
	[SupportedBy("iOS")]
	public class RedoCommand: ICommand<RedoCommandResponse>
	{
	}
}
