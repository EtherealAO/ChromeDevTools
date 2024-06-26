using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Steps over the statement.
	/// </summary>
	[Command(ProtocolName.Debugger.StepOver)]
	[SupportedBy("Chrome")]
	public class StepOverCommand: ICommand<StepOverCommandResponse>
	{
		/// <summary>
		/// Gets or sets The skipList specifies location ranges that should be skipped on step over.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LocationRange[] SkipList { get; set; }
	}
}
