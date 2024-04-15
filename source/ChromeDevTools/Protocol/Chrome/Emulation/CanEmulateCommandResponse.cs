namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Tells whether emulation is supported.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.CanEmulate)]
	[SupportedBy("Chrome")]
	public class CanEmulateCommandResponse
	{
		/// <summary>
		/// Gets or sets True if emulation is supported.
		/// </summary>
		public bool Result { get; set; }
	}
}
