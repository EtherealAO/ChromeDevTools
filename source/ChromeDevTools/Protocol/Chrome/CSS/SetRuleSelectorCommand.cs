namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>
	[Command(ProtocolName.CSS.SetRuleSelector)]
	[SupportedBy("Chrome")]
	public class SetRuleSelectorCommand: ICommand<SetRuleSelectorCommandResponse>
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Range
		/// </summary>
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or sets Selector
		/// </summary>
		public string Selector { get; set; }
	}
}
