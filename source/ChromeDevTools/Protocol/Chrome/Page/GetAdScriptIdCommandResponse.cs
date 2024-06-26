using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[CommandResponse(ProtocolName.Page.GetAdScriptId)]
	[SupportedBy("Chrome")]
	public class GetAdScriptIdCommandResponse
	{
		/// <summary>
		/// Gets or sets Identifies the bottom-most script which caused the frame to be labelled
		/// as an ad. Only sent if frame is labelled as an ad and id is available.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AdScriptId AdScriptId { get; set; }
	}
}
