using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Set the behavior when downloading a file.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Page.SetDownloadBehavior)]
	[SupportedBy("Chrome")]
	public class SetDownloadBehaviorCommandResponse
	{
	}
}
