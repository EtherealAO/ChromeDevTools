namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceAccess
{
	/// <summary>
	/// Select a device in response to a DeviceAccess.deviceRequestPrompted event.
	/// </summary>
	[CommandResponse(ProtocolName.DeviceAccess.SelectPrompt)]
	[SupportedBy("Chrome")]
	public class SelectPromptCommandResponse
	{
	}
}
