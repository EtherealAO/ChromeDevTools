namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Clears accepted encodings set by setAcceptedEncodings
	/// </summary>
	[CommandResponse(ProtocolName.Network.ClearAcceptedEncodingsOverride)]
	[SupportedBy("Chrome")]
	public class ClearAcceptedEncodingsOverrideCommandResponse
	{
	}
}
