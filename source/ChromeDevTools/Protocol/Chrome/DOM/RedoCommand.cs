namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Re-does the last undone action.
	/// </summary>
	[Command(ProtocolName.DOM.Redo)]
	[SupportedBy("Chrome")]
	public class RedoCommand: ICommand<RedoCommandResponse>
	{
	}
}
