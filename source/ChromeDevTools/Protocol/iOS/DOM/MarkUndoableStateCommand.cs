namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Marks last undoable state.
	/// </summary>
	[Command(ProtocolName.DOM.MarkUndoableState)]
	[SupportedBy("iOS")]
	public class MarkUndoableStateCommand: ICommand<MarkUndoableStateCommandResponse>
	{
	}
}
