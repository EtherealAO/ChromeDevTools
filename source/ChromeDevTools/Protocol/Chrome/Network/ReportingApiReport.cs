namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// An object representing a report generated by the Reporting API.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ReportingApiReport
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets The URL of the document that triggered the report.
		/// </summary>
		public string InitiatorUrl { get; set; }
		/// <summary>
		/// Gets or sets The name of the endpoint group that should be used to deliver the report.
		/// </summary>
		public string Destination { get; set; }
		/// <summary>
		/// Gets or sets The type of the report (specifies the set of data that is contained in the report body).
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets When the report was generated.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets How many uploads deep the related request was.
		/// </summary>
		public long Depth { get; set; }
		/// <summary>
		/// Gets or sets The number of delivery attempts made so far, not including an active attempt.
		/// </summary>
		public long CompletedAttempts { get; set; }
		/// <summary>
		/// Gets or sets Body
		/// </summary>
		public object Body { get; set; }
		/// <summary>
		/// Gets or sets Status
		/// </summary>
		public ReportStatus Status { get; set; }
	}
}
