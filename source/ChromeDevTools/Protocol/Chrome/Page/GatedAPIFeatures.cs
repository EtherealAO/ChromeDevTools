using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GatedAPIFeatures
	{
			SharedArrayBuffers,
			SharedArrayBuffersTransferAllowed,
			PerformanceMeasureMemory,
			PerformanceProfile,
	}
}
