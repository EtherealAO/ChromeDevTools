using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Start trace events collection.
	/// </summary>
	[Command(ProtocolName.Tracing.Start)]
	[SupportedBy("Chrome")]
	public class StartCommand: ICommand<StartCommandResponse>
	{
		/// <summary>
		/// Gets or sets Category/tag filter
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Categories { get; set; }
		/// <summary>
		/// Gets or sets Tracing options
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Options { get; set; }
		/// <summary>
		/// Gets or sets If set, the agent will issue bufferUsage events at this interval, specified in milliseconds
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double BufferUsageReportingInterval { get; set; }
		/// <summary>
		/// Gets or sets Whether to report trace events as series of dataCollected events or to save trace to a
		/// stream (defaults to `ReportEvents`).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TransferMode { get; set; }
		/// <summary>
		/// Gets or sets Trace data format to use. This only applies when using `ReturnAsStream`
		/// transfer mode (defaults to `json`).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StreamFormat { get; set; }
		/// <summary>
		/// Gets or sets Compression format to use. This only applies when using `ReturnAsStream`
		/// transfer mode (defaults to `none`)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StreamCompression { get; set; }
		/// <summary>
		/// Gets or sets TraceConfig
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public TraceConfig TraceConfig { get; set; }
		/// <summary>
		/// Gets or sets Base64-encoded serialized perfetto.protos.TraceConfig protobuf message
		/// When specified, the parameters `categories`, `options`, `traceConfig`
		/// are ignored. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PerfettoConfig { get; set; }
		/// <summary>
		/// Gets or sets Backend type (defaults to `auto`)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TracingBackend { get; set; }
	}
}
