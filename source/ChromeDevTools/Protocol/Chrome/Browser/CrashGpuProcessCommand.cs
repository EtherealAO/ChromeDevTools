namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Crashes GPU process.
	/// </summary>
	[Command(ProtocolName.Browser.CrashGpuProcess)]
	[SupportedBy("Chrome")]
	public class CrashGpuProcessCommand: ICommand<CrashGpuProcessCommandResponse>
	{
	}
}
