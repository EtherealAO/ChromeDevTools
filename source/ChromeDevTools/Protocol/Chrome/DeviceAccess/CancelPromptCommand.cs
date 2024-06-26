namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceAccess
{
	/// <summary>
	/// Cancel a prompt in response to a DeviceAccess.deviceRequestPrompted event.
	/// </summary>
	[Command(ProtocolName.DeviceAccess.CancelPrompt)]
	[SupportedBy("Chrome")]
	public class CancelPromptCommand: ICommand<CancelPromptCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
	}
}
