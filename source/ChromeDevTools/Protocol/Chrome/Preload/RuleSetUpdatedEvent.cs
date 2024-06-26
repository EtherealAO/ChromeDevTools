namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	/// Upsert. Currently, it is only emitted when a rule set added.
	/// </summary>
	[Event(ProtocolName.Preload.RuleSetUpdated)]
	[SupportedBy("Chrome")]
	public class RuleSetUpdatedEvent
	{
		/// <summary>
		/// Gets or sets RuleSet
		/// </summary>
		public RuleSet RuleSet { get; set; }
	}
}
