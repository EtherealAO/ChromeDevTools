using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Emulates touch event from the mouse event parameters.
	/// </summary>
	[Command(ProtocolName.Input.EmulateTouchFromMouseEvent)]
	[SupportedBy("Chrome")]
	public class EmulateTouchFromMouseEventCommand: ICommand<EmulateTouchFromMouseEventCommandResponse>
	{
		/// <summary>
		/// Gets or sets Type of the mouse event.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets X coordinate of the mouse pointer in DIP.
		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate of the mouse pointer in DIP.
		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Gets or sets Mouse button. Only "none", "left", "right" are supported.
		/// </summary>
		public string Button { get; set; }
		/// <summary>
		/// Gets or sets Time at which the event occurred (default: current time).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets X delta in DIP for mouse wheel event (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double DeltaX { get; set; }
		/// <summary>
		/// Gets or sets Y delta in DIP for mouse wheel event (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double DeltaY { get; set; }
		/// <summary>
		/// Gets or sets Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
		/// (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Modifiers { get; set; }
		/// <summary>
		/// Gets or sets Number of times the mouse button was clicked (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ClickCount { get; set; }
	}
}
