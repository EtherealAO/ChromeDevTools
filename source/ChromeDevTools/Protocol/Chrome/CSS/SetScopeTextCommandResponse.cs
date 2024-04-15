namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Modifies the expression of a scope at-rule.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetScopeText)]
	[SupportedBy("Chrome")]
	public class SetScopeTextCommandResponse
	{
		/// <summary>
		/// Gets or sets The resulting CSS Scope rule after modification.
		/// </summary>
		public CSSScope Scope { get; set; }
	}
}
