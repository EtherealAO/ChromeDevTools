namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceAccess
{
	/// <summary>
	/// A device request opened a user prompt to select a device. Respond with the
	/// selectPrompt or cancelPrompt command.
	/// </summary>
	[Event(ProtocolName.DeviceAccess.DeviceRequestPrompted)]
	[SupportedBy("Chrome")]
	public class DeviceRequestPromptedEvent
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Devices
		/// </summary>
		public PromptDevice[] Devices { get; set; }
	}
}
