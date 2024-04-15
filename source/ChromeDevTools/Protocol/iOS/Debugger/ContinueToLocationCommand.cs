namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Continues execution until specific location is reached.
	/// </summary>
	[Command(ProtocolName.Debugger.ContinueToLocation)]
	[SupportedBy("iOS")]
	public class ContinueToLocationCommand: ICommand<ContinueToLocationCommandResponse>
	{
		/// <summary>
		/// Gets or sets Location to continue to.
		/// </summary>
		public Location Location { get; set; }
	}
}
