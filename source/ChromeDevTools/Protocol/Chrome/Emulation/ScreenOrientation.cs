namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Screen orientation.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ScreenOrientation
	{
		/// <summary>
		/// Gets or sets Orientation type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Orientation angle.
		/// </summary>
		public long Angle { get; set; }
	}
}
