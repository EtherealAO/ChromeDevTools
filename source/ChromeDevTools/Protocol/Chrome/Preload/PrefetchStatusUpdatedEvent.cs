using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	/// Fired when a prefetch attempt is updated.
	/// </summary>
	[Event(ProtocolName.Preload.PrefetchStatusUpdated)]
	[SupportedBy("Chrome")]
	public class PrefetchStatusUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Key
		/// </summary>
		public PreloadingAttemptKey Key { get; set; }
		/// <summary>
		/// Gets or sets The frame id of the frame initiating prefetch.
		/// </summary>
		public string InitiatingFrameId { get; set; }
		/// <summary>
		/// Gets or sets PrefetchUrl
		/// </summary>
		public string PrefetchUrl { get; set; }
		/// <summary>
		/// Gets or sets Status
		/// </summary>
		public PreloadingStatus Status { get; set; }
	}
}
