using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	/// Fired when a prerender attempt is completed.
	/// </summary>
	[Event(ProtocolName.Preload.PrerenderAttemptCompleted)]
	[SupportedBy("Chrome")]
	public class PrerenderAttemptCompletedEvent
	{
		/// <summary>
		/// Gets or sets Key
		/// </summary>
		public PreloadingAttemptKey Key { get; set; }
		/// <summary>
		/// Gets or sets The frame id of the frame initiating prerendering.
		/// </summary>
		public string InitiatingFrameId { get; set; }
		/// <summary>
		/// Gets or sets PrerenderingUrl
		/// </summary>
		public string PrerenderingUrl { get; set; }
		/// <summary>
		/// Gets or sets FinalStatus
		/// </summary>
		public PrerenderFinalStatus FinalStatus { get; set; }
		/// <summary>
		/// Gets or sets This is used to give users more information about the name of the API call
		/// that is incompatible with prerender and has caused the cancellation of the attempt
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DisallowedApiMethod { get; set; }
	}
}
