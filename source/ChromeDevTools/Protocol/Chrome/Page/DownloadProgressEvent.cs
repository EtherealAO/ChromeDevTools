namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when download makes progress. Last call has |done| == true.
	/// Deprecated. Use Browser.downloadProgress instead.
	/// </summary>
	[Event(ProtocolName.Page.DownloadProgress)]
	[SupportedBy("Chrome")]
	public class DownloadProgressEvent
	{
		/// <summary>
		/// Gets or sets Global unique identifier of the download.
		/// </summary>
		public string Guid { get; set; }
		/// <summary>
		/// Gets or sets Total expected bytes to download.
		/// </summary>
		public double TotalBytes { get; set; }
		/// <summary>
		/// Gets or sets Total bytes received.
		/// </summary>
		public double ReceivedBytes { get; set; }
		/// <summary>
		/// Gets or sets Download status.
		/// </summary>
		public string State { get; set; }
	}
}
