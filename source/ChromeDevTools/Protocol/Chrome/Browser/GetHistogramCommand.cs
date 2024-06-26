using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Get a Chrome histogram by name.
	/// </summary>
	[Command(ProtocolName.Browser.GetHistogram)]
	[SupportedBy("Chrome")]
	public class GetHistogramCommand: ICommand<GetHistogramCommandResponse>
	{
		/// <summary>
		/// Gets or sets Requested histogram name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets If true, retrieve delta since last delta call.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Delta { get; set; }
	}
}
