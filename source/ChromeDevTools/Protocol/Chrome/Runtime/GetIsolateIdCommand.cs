namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Returns the isolate id.
	/// </summary>
	[Command(ProtocolName.Runtime.GetIsolateId)]
	[SupportedBy("Chrome")]
	public class GetIsolateIdCommand: ICommand<GetIsolateIdCommandResponse>
	{
	}
}
