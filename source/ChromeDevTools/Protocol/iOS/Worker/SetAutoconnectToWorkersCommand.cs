namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Command(ProtocolName.Worker.SetAutoconnectToWorkers)]
	[SupportedBy("iOS")]
	public class SetAutoconnectToWorkersCommand: ICommand<SetAutoconnectToWorkersCommandResponse>
	{
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public bool Value { get; set; }
	}
}
