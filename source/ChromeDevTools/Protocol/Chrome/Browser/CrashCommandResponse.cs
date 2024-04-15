namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Crashes browser on the main thread.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.Crash)]
	[SupportedBy("Chrome")]
	public class CrashCommandResponse
	{
	}
}
