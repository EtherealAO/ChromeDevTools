namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Returns stack trace with given `stackTraceId`.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetStackTrace)]
	[SupportedBy("Chrome")]
	public class GetStackTraceCommandResponse
	{
		/// <summary>
		/// Gets or sets StackTrace
		/// </summary>
		public Runtime.StackTrace StackTrace { get; set; }
	}
}
