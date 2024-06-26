using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Returns information about a target.
	/// </summary>
	[Command(ProtocolName.Target.GetTargetInfo)]
	[SupportedBy("Chrome")]
	public class GetTargetInfoCommand: ICommand<GetTargetInfoCommandResponse>
	{
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
