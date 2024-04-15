namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Undoes the last performed action.
	/// </summary>
	[Command(ProtocolName.DOM.Undo)]
	[SupportedBy("Chrome")]
	public class UndoCommand: ICommand<UndoCommandResponse>
	{
	}
}
