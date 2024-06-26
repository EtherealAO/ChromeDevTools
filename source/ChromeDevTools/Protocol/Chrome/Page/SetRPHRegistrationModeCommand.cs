namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Extensions for Custom Handlers API:
	/// https://html.spec.whatwg.org/multipage/system-state.html#rph-automation
	/// </summary>
	[Command(ProtocolName.Page.SetRPHRegistrationMode)]
	[SupportedBy("Chrome")]
	public class SetRPHRegistrationModeCommand: ICommand<SetRPHRegistrationModeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Mode
		/// </summary>
		public string Mode { get; set; }
	}
}
