using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	[Event(ProtocolName.FedCm.DialogShown)]
	[SupportedBy("Chrome")]
	public class DialogShownEvent
	{
		/// <summary>
		/// Gets or sets DialogId
		/// </summary>
		public string DialogId { get; set; }
		/// <summary>
		/// Gets or sets Accounts
		/// </summary>
		public Account[] Accounts { get; set; }
		/// <summary>
		/// Gets or sets These exist primarily so that the caller can verify the
		/// RP context was used appropriately.
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Gets or sets Subtitle
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Subtitle { get; set; }
	}
}
