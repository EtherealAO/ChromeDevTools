using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Retrieves a list of available targets.
	/// </summary>
	[Command(ProtocolName.Target.GetTargets)]
	[SupportedBy("Chrome")]
	public class GetTargetsCommand: ICommand<GetTargetsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Only targets matching filter will be reported. If filter is not specified
		/// and target discovery is currently enabled, a filter used for target discovery
		/// is used for consistency.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FilterEntry[] Filter { get; set; }
	}
}
