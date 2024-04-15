namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// Returns detailed information on given function.
	/// </summary>
	[Command(ProtocolName.Debugger.GetFunctionDetails)]
	[SupportedBy("iOS")]
	public class GetFunctionDetailsCommand: ICommand<GetFunctionDetailsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the function to get location for.
		/// </summary>
		public string FunctionId { get; set; }
	}
}
