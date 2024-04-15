using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Deprecated, please use removeScriptToEvaluateOnNewDocument instead.
	/// </summary>
	[Obsolete("Deprecated, please use removeScriptToEvaluateOnNewDocument instead.")]
	[CommandResponse(ProtocolName.Page.RemoveScriptToEvaluateOnLoad)]
	[SupportedBy("Chrome")]
	public class RemoveScriptToEvaluateOnLoadCommandResponse
	{
	}
}
