namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Log
{
	/// <summary>
	/// Stop violation reporting.
	/// </summary>
	[Command(ProtocolName.Log.StopViolationsReport)]
	[SupportedBy("Chrome")]
	public class StopViolationsReportCommand: ICommand<StopViolationsReportCommandResponse>
	{
	}
}
