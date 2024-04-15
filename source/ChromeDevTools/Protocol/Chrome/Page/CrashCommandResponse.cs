namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Crashes renderer on the IO thread, generates minidumps.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Crash)]
	[SupportedBy("Chrome")]
	public class CrashCommandResponse
	{
	}
}
