namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// CSS style information for a DOM style attribute.
	/// </summary>
	[SupportedBy("iOS")]
	public class CSSStyleAttribute
	{
		/// <summary>
		/// Gets or sets DOM attribute name (e.g. "width").
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets CSS style generated by the respective DOM attribute.
		/// </summary>
		public CSSStyle Style { get; set; }
	}
}
