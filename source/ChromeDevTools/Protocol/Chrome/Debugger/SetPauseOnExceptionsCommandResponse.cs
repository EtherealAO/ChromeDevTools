namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions,
	/// or caught exceptions, no exceptions. Initial pause on exceptions state is `none`.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetPauseOnExceptions)]
	[SupportedBy("Chrome")]
	public class SetPauseOnExceptionsCommandResponse
	{
	}
}
