namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Enable Chrome's experimental ad filter on all sites.
	/// </summary>
	[Command(ProtocolName.Page.SetAdBlockingEnabled)]
	[SupportedBy("Chrome")]
	public class SetAdBlockingEnabledCommand: ICommand<SetAdBlockingEnabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether to block ads.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
