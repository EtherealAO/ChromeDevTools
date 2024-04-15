using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Keyframes Rule
	/// </summary>
	[SupportedBy("Chrome")]
	public class KeyframesRule
	{
		/// <summary>
		/// Gets or sets CSS keyframed animation's name.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets List of animation keyframes.
		/// </summary>
		public KeyframeStyle[] Keyframes { get; set; }
	}
}
