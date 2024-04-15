namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	[CommandResponse(ProtocolName.Profiler.Stop)]
	[SupportedBy("Chrome")]
	public class StopCommandResponse
	{
		/// <summary>
		/// Gets or sets Recorded profile.
		/// </summary>
		public Profile Profile { get; set; }
	}
}
