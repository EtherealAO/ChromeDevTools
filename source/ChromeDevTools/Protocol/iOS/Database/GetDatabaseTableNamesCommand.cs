namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	[Command(ProtocolName.Database.GetDatabaseTableNames)]
	[SupportedBy("iOS")]
	public class GetDatabaseTableNamesCommand: ICommand<GetDatabaseTableNamesCommandResponse>
	{
		/// <summary>
		/// Gets or sets DatabaseId
		/// </summary>
		public string DatabaseId { get; set; }
	}
}
