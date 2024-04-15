namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	/// <summary>
	/// Database error.
	/// </summary>
	[SupportedBy("iOS")]
	public class Error
	{
		/// <summary>
		/// Gets or sets Error message.
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Gets or sets Error code.
		/// </summary>
		public long Code { get; set; }
	}
}
