namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Get Origin Trials on given frame.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetOriginTrials)]
	[SupportedBy("Chrome")]
	public class GetOriginTrialsCommandResponse
	{
		/// <summary>
		/// Gets or sets OriginTrials
		/// </summary>
		public OriginTrial[] OriginTrials { get; set; }
	}
}
