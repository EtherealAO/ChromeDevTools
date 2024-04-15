namespace MasterDevs.ChromeDevTools.Protocol.iOS.Console
{
	/// <summary>
	/// Toggles monitoring of XMLHttpRequest. If <code>true</code>, console will receive messages upon each XHR issued.
	/// </summary>
	[CommandResponse(ProtocolName.Console.SetMonitoringXHREnabled)]
	[SupportedBy("iOS")]
	public class SetMonitoringXHREnabledCommandResponse
	{
	}
}
