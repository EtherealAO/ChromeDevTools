namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Returns information about the feature state.
	/// </summary>
	[Command(ProtocolName.SystemInfo.GetFeatureState)]
	[SupportedBy("Chrome")]
	public class GetFeatureStateCommand: ICommand<GetFeatureStateCommandResponse>
	{
		/// <summary>
		/// Gets or sets FeatureState
		/// </summary>
		public string FeatureState { get; set; }
	}
}
