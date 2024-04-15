namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Creates a new empty rule with the given <code>selector</code> in a stylesheet with given <code>styleSheetId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.AddRule)]
	[SupportedBy("iOS")]
	public class AddRuleCommand: ICommand<AddRuleCommandResponse>
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Selector
		/// </summary>
		public string Selector { get; set; }
	}
}
