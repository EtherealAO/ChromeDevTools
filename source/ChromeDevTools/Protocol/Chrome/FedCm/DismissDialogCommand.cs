using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	[Command(ProtocolName.FedCm.DismissDialog)]
	[SupportedBy("Chrome")]
	public class DismissDialogCommand: ICommand<DismissDialogCommandResponse>
	{
		/// <summary>
		/// Gets or sets DialogId
		/// </summary>
		public string DialogId { get; set; }
		/// <summary>
		/// Gets or sets TriggerCooldown
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? TriggerCooldown { get; set; }
	}
}
