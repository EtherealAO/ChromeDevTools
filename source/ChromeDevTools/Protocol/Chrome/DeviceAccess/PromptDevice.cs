namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceAccess
{
	/// <summary>
	/// Device information displayed in a user prompt to select a device.
	/// </summary>
	[SupportedBy("Chrome")]
	public class PromptDevice
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Display name as it appears in a device request user prompt.
		/// </summary>
		public string Name { get; set; }
	}
}
