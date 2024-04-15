namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Polls the next batch of computed style updates.
	/// </summary>
	[Command(ProtocolName.CSS.TakeComputedStyleUpdates)]
	[SupportedBy("Chrome")]
	public class TakeComputedStyleUpdatesCommand: ICommand<TakeComputedStyleUpdatesCommandResponse>
	{
	}
}
