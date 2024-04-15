namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS position-fallback rule representation.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSPositionFallbackRule
	{
		/// <summary>
		/// Gets or sets Name
		/// </summary>
		public Value Name { get; set; }
		/// <summary>
		/// Gets or sets List of keyframes.
		/// </summary>
		public CSSTryRule[] TryRules { get; set; }
	}
}
