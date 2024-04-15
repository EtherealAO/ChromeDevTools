namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Modifies the expression of a container query.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetContainerQueryText)]
	[SupportedBy("Chrome")]
	public class SetContainerQueryTextCommandResponse
	{
		/// <summary>
		/// Gets or sets The resulting CSS container query rule after modification.
		/// </summary>
		public CSSContainerQuery ContainerQuery { get; set; }
	}
}
