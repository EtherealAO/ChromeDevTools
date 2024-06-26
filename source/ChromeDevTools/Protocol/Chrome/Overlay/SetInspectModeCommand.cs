using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted.
	/// Backend then generates 'inspectNodeRequested' event upon element selection.
	/// </summary>
	[Command(ProtocolName.Overlay.SetInspectMode)]
	[SupportedBy("Chrome")]
	public class SetInspectModeCommand: ICommand<SetInspectModeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Set an inspection mode.
		/// </summary>
		public string Mode { get; set; }
		/// <summary>
		/// Gets or sets A descriptor for the highlight appearance of hovered-over nodes. May be omitted if `enabled
		/// == false`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HighlightConfig HighlightConfig { get; set; }
	}
}
