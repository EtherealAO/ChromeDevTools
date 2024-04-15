namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Get a Chrome histogram by name.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.GetHistogram)]
	[SupportedBy("Chrome")]
	public class GetHistogramCommandResponse
	{
		/// <summary>
		/// Gets or sets Histogram.
		/// </summary>
		public Histogram Histogram { get; set; }
	}
}
