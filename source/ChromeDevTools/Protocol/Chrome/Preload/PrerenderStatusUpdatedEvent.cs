using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	/// Fired when a prerender attempt is updated.
	/// </summary>
	[Event(ProtocolName.Preload.PrerenderStatusUpdated)]
	[SupportedBy("Chrome")]
	public class PrerenderStatusUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Key
		/// </summary>
		public PreloadingAttemptKey Key { get; set; }
		/// <summary>
		/// Gets or sets The frame id of the frame initiating prerender.
		/// </summary>
		public string InitiatingFrameId { get; set; }
		/// <summary>
		/// Gets or sets PrerenderingUrl
		/// </summary>
		public string PrerenderingUrl { get; set; }
		/// <summary>
		/// Gets or sets Status
		/// </summary>
		public PreloadingStatus Status { get; set; }
	}
}
