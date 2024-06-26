using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Handles a certificate error that fired a certificateError event.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Security.HandleCertificateError)]
	[SupportedBy("Chrome")]
	public class HandleCertificateErrorCommand: ICommand<HandleCertificateErrorCommandResponse>
	{
		/// <summary>
		/// Gets or sets The ID of the event.
		/// </summary>
		public long EventId { get; set; }
		/// <summary>
		/// Gets or sets The action to take on the certificate error.
		/// </summary>
		public string Action { get; set; }
	}
}
