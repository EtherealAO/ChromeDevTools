using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Enable/disable overriding certificate errors. If enabled, all certificate error events need to
	/// be handled by the DevTools client and should be answered with `handleCertificateError` commands.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Security.SetOverrideCertificateErrors)]
	[SupportedBy("Chrome")]
	public class SetOverrideCertificateErrorsCommandResponse
	{
	}
}
