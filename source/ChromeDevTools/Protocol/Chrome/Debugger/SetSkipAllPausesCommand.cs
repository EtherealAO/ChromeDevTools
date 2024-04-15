namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
	/// </summary>
	[Command(ProtocolName.Debugger.SetSkipAllPauses)]
	[SupportedBy("Chrome")]
	public class SetSkipAllPausesCommand: ICommand<SetSkipAllPausesCommandResponse>
	{
		/// <summary>
		/// Gets or sets New value for skip pauses state.
		/// </summary>
		public bool Skip { get; set; }
	}
}
