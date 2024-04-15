namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Issued when execution context is destroyed.
	/// </summary>
	[Event(ProtocolName.Runtime.ExecutionContextDestroyed)]
	[SupportedBy("Chrome")]
	public class ExecutionContextDestroyedEvent
	{
		/// <summary>
		/// Gets or sets Id of the destroyed context
		/// </summary>
		public long ExecutionContextId { get; set; }
		/// <summary>
		/// Gets or sets Unique Id of the destroyed context
		/// </summary>
		public string ExecutionContextUniqueId { get; set; }
	}
}
