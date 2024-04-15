namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Enables/disables issuing of sharedStorageAccessed events.
	/// </summary>
	[Command(ProtocolName.Storage.SetSharedStorageTracking)]
	[SupportedBy("Chrome")]
	public class SetSharedStorageTrackingCommand: ICommand<SetSharedStorageTrackingCommandResponse>
	{
		/// <summary>
		/// Gets or sets Enable
		/// </summary>
		public bool Enable { get; set; }
	}
}
