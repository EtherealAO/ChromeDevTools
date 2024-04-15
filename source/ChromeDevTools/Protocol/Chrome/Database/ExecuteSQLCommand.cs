namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Database
{
	[Command(ProtocolName.Database.ExecuteSQL)]
	[SupportedBy("Chrome")]
	public class ExecuteSQLCommand: ICommand<ExecuteSQLCommandResponse>
	{
		/// <summary>
		/// Gets or sets DatabaseId
		/// </summary>
		public string DatabaseId { get; set; }
		/// <summary>
		/// Gets or sets Query
		/// </summary>
		public string Query { get; set; }
	}
}
