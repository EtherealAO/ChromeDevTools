namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	[Command(ProtocolName.Emulation.SetHardwareConcurrencyOverride)]
	[SupportedBy("Chrome")]
	public class SetHardwareConcurrencyOverrideCommand: ICommand<SetHardwareConcurrencyOverrideCommandResponse>
	{
		/// <summary>
		/// Gets or sets Hardware concurrency to report
		/// </summary>
		public long HardwareConcurrency { get; set; }
	}
}
