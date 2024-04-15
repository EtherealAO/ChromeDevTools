namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	/// Send a list of sources for all preloading attempts in a document.
	/// </summary>
	[Event(ProtocolName.Preload.PreloadingAttemptSourcesUpdated)]
	[SupportedBy("Chrome")]
	public class PreloadingAttemptSourcesUpdatedEvent
	{
		/// <summary>
		/// Gets or sets LoaderId
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets PreloadingAttemptSources
		/// </summary>
		public PreloadingAttemptSource[] PreloadingAttemptSources { get; set; }
	}
}
