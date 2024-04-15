namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	[Event(ProtocolName.Preload.RuleSetRemoved)]
	[SupportedBy("Chrome")]
	public class RuleSetRemovedEvent
	{
		/// <summary>
		/// Gets or sets Id
		/// </summary>
		public string Id { get; set; }
	}
}
