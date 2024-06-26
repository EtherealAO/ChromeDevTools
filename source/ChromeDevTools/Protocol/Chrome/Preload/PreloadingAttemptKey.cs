using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	/// A key that identifies a preloading attempt.
	/// 
	/// The url used is the url specified by the trigger (i.e. the initial URL), and
	/// not the final url that is navigated to. For example, prerendering allows
	/// same-origin main frame navigations during the attempt, but the attempt is
	/// still keyed with the initial URL.
	/// </summary>
	[SupportedBy("Chrome")]
	public class PreloadingAttemptKey
	{
		/// <summary>
		/// Gets or sets LoaderId
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets Action
		/// </summary>
		public SpeculationAction Action { get; set; }
		/// <summary>
		/// Gets or sets Url
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets TargetHint
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SpeculationTargetHint TargetHint { get; set; }
	}
}
