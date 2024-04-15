namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Gets the playback rate of the document timeline.
	/// </summary>
	[Command(ProtocolName.Animation.GetPlaybackRate)]
	[SupportedBy("Chrome")]
	public class GetPlaybackRateCommand: ICommand<GetPlaybackRateCommandResponse>
	{
	}
}
