namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Returns information about the feature state.
	/// </summary>
	[CommandResponse(ProtocolName.SystemInfo.GetFeatureState)]
	[SupportedBy("Chrome")]
	public class GetFeatureStateCommandResponse
	{
		/// <summary>
		/// Gets or sets FeatureEnabled
		/// </summary>
		public bool FeatureEnabled { get; set; }
	}
}
