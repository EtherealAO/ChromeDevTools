namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Discards collected exceptions and console API calls.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.DiscardConsoleEntries)]
	[SupportedBy("Chrome")]
	public class DiscardConsoleEntriesCommandResponse
	{
	}
}
