namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Pair of reporting metadata details for a candidate URL for `selectURL()`.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedStorageReportingMetadata
	{
		/// <summary>
		/// Gets or sets EventType
		/// </summary>
		public string EventType { get; set; }
		/// <summary>
		/// Gets or sets ReportingUrl
		/// </summary>
		public string ReportingUrl { get; set; }
	}
}
