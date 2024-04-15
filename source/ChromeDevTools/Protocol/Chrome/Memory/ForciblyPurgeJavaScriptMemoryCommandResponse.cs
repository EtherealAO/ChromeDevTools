namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Simulate OomIntervention by purging V8 memory.
	/// </summary>
	[CommandResponse(ProtocolName.Memory.ForciblyPurgeJavaScriptMemory)]
	[SupportedBy("Chrome")]
	public class ForciblyPurgeJavaScriptMemoryCommandResponse
	{
	}
}
