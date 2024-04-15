namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Emulates the given vision deficiency.
	/// </summary>
	[Command(ProtocolName.Emulation.SetEmulatedVisionDeficiency)]
	[SupportedBy("Chrome")]
	public class SetEmulatedVisionDeficiencyCommand: ICommand<SetEmulatedVisionDeficiencyCommandResponse>
	{
		/// <summary>
		/// Gets or sets Vision deficiency to emulate. Order: best-effort emulations come first, followed by any
		/// physiologically accurate emulations for medically recognized color vision deficiencies.
		/// </summary>
		public string Type { get; set; }
	}
}
