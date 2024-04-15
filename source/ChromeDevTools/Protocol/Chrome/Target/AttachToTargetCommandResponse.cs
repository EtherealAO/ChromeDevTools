namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Attaches to the target with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Target.AttachToTarget)]
	[SupportedBy("Chrome")]
	public class AttachToTargetCommandResponse
	{
		/// <summary>
		/// Gets or sets Id assigned to the session.
		/// </summary>
		public string SessionId { get; set; }
	}
}
