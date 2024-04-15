namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Releases a set of animations to no longer be manipulated.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.ReleaseAnimations)]
	[SupportedBy("Chrome")]
	public class ReleaseAnimationsCommandResponse
	{
	}
}
