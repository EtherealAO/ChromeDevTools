using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing{
	/// <summary>
	/// Details exposed when memory request explicitly declared.
	/// Keep consistent with memory_dump_request_args.h and
	/// memory_instrumentation.mojom
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MemoryDumpLevelOfDetail
	{
			Background,
			Light,
			Detailed,
	}
}
