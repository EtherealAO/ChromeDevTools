using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	[SupportedBy("Chrome")]
	public class RequestPattern
	{
		/// <summary>
		/// Gets or sets Wildcards (`'*'` -> zero or more, `'?'` -> exactly one) are allowed. Escape character is
		/// backslash. Omitting is equivalent to `"*"`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UrlPattern { get; set; }
		/// <summary>
		/// Gets or sets If set, only requests for matching resource types will be intercepted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Network.ResourceType ResourceType { get; set; }
		/// <summary>
		/// Gets or sets Stage at which to begin intercepting requests. Default is Request.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RequestStage RequestStage { get; set; }
	}
}
