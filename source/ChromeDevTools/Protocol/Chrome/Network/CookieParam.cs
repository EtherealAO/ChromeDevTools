using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Cookie parameter object
	/// </summary>
	[SupportedBy("Chrome")]
	public class CookieParam
	{
		/// <summary>
		/// Gets or sets Cookie name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Cookie value.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets The request-URI to associate with the setting of the cookie. This value can affect the
		/// default domain, path, source port, and source scheme values of the created cookie.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Cookie domain.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Domain { get; set; }
		/// <summary>
		/// Gets or sets Cookie path.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Path { get; set; }
		/// <summary>
		/// Gets or sets True if cookie is secure.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Secure { get; set; }
		/// <summary>
		/// Gets or sets True if cookie is http-only.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HttpOnly { get; set; }
		/// <summary>
		/// Gets or sets Cookie SameSite type.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CookieSameSite SameSite { get; set; }
		/// <summary>
		/// Gets or sets Cookie expiration date, session cookie if not set
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Expires { get; set; }
		/// <summary>
		/// Gets or sets Cookie Priority.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CookiePriority Priority { get; set; }
		/// <summary>
		/// Gets or sets True if cookie is SameParty.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? SameParty { get; set; }
		/// <summary>
		/// Gets or sets Cookie source scheme type.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CookieSourceScheme SourceScheme { get; set; }
		/// <summary>
		/// Gets or sets Cookie source port. Valid values are {-1, [1, 65535]}, -1 indicates an unspecified port.
		/// An unspecified port value allows protocol clients to emulate legacy cookie scope for the port.
		/// This is a temporary ability and it will be removed in the future.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? SourcePort { get; set; }
		/// <summary>
		/// Gets or sets Cookie partition key. The site of the top-level URL the browser was visiting at the start
		/// of the request to the endpoint that set the cookie.
		/// If not set, the cookie will be set as not partitioned.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PartitionKey { get; set; }
	}
}
