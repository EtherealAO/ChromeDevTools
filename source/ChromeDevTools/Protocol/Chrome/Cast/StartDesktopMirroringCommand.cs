namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Starts mirroring the desktop to the sink.
	/// </summary>
	[Command(ProtocolName.Cast.StartDesktopMirroring)]
	[SupportedBy("Chrome")]
	public class StartDesktopMirroringCommand: ICommand<StartDesktopMirroringCommandResponse>
	{
		/// <summary>
		/// Gets or sets SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
