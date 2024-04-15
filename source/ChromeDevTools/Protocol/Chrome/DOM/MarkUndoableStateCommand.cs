namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Marks last undoable state.
	/// </summary>
	[Command(ProtocolName.DOM.MarkUndoableState)]
	[SupportedBy("Chrome")]
	public class MarkUndoableStateCommand: ICommand<MarkUndoableStateCommandResponse>
	{
	}
}
