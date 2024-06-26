namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Bundles a candidate URL with its reporting metadata.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedStorageUrlWithMetadata
	{
		/// <summary>
		/// Gets or sets Spec of candidate URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Any associated reporting metadata.
		/// </summary>
		public SharedStorageReportingMetadata[] ReportingMetadata { get; set; }
	}
}
