using Newtonsoft.Json;
using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Sends protocol message over session with given id.
	/// Consider using flat mode instead; see commands attachToTarget, setAutoAttach,
	/// and crbug.com/991325.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Target.SendMessageToTarget)]
	[SupportedBy("Chrome")]
	public class SendMessageToTargetCommand: ICommand<SendMessageToTargetCommandResponse>
	{
		/// <summary>
		/// Gets or sets Message
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the session.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SessionId { get; set; }
		/// <summary>
		/// Gets or sets Deprecated.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
