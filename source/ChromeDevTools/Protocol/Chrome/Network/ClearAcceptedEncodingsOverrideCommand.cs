namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Clears accepted encodings set by setAcceptedEncodings
	/// </summary>
	[Command(ProtocolName.Network.ClearAcceptedEncodingsOverride)]
	[SupportedBy("Chrome")]
	public class ClearAcceptedEncodingsOverrideCommand: ICommand<ClearAcceptedEncodingsOverrideCommandResponse>
	{
	}
}
