namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Tells whether emulation is supported.
	/// </summary>
	[Command(ProtocolName.Emulation.CanEmulate)]
	[SupportedBy("Chrome")]
	public class CanEmulateCommand: ICommand<CanEmulateCommandResponse>
	{
	}
}
