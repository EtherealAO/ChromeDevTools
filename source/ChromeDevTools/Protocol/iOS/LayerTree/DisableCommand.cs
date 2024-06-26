namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	/// <summary>
	/// Disables compositing tree inspection.
	/// </summary>
	[Command(ProtocolName.LayerTree.Disable)]
	[SupportedBy("iOS")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}
