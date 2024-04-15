namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceAccess
{
	/// <summary>
	/// Cancel a prompt in response to a DeviceAccess.deviceRequestPrompted event.
	/// </summary>
	[CommandResponse(ProtocolName.DeviceAccess.CancelPrompt)]
	[SupportedBy("Chrome")]
	public class CancelPromptCommandResponse
	{
	}
}
