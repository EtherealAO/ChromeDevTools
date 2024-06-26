namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	[Command(ProtocolName.Emulation.SetDisabledImageTypes)]
	[SupportedBy("Chrome")]
	public class SetDisabledImageTypesCommand: ICommand<SetDisabledImageTypesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Image types to disable.
		/// </summary>
		public string[] ImageTypes { get; set; }
	}
}
