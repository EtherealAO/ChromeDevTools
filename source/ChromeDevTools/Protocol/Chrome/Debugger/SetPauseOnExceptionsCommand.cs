namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions,
	/// or caught exceptions, no exceptions. Initial pause on exceptions state is `none`.
	/// </summary>
	[Command(ProtocolName.Debugger.SetPauseOnExceptions)]
	[SupportedBy("Chrome")]
	public class SetPauseOnExceptionsCommand: ICommand<SetPauseOnExceptionsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Pause on exceptions mode.
		/// </summary>
		public string State { get; set; }
	}
}
