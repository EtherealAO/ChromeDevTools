using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload{
	/// <summary>
	/// Preloading status values, see also PreloadingTriggeringOutcome. This
	/// status is shared by prefetchStatusUpdated and prerenderStatusUpdated.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PreloadingStatus
	{
			Pending,
			Running,
			Ready,
			Success,
			Failure,
			NotSupported,
	}
}
