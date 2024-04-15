namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Clears Idle state overrides.
	/// </summary>
	[Command(ProtocolName.Emulation.ClearIdleOverride)]
	[SupportedBy("Chrome")]
	public class ClearIdleOverrideCommand: ICommand<ClearIdleOverrideCommandResponse>
	{
	}
}
