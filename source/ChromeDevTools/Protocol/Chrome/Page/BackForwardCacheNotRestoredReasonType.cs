using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Types of not restored reasons for back-forward cache.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BackForwardCacheNotRestoredReasonType
	{
			SupportPending,
			PageSupportNeeded,
			Circumstantial,
	}
}
