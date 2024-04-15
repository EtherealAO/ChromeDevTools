namespace MasterDevs.ChromeDevTools.Protocol.iOS.ApplicationCache
{
	/// <summary>
	/// Returns relevant application cache data for the document in given frame.
	/// </summary>
	[CommandResponse(ProtocolName.ApplicationCache.GetApplicationCacheForFrame)]
	[SupportedBy("iOS")]
	public class GetApplicationCacheForFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets Relevant application cache data for the document in given frame.
		/// </summary>
		public ApplicationCache ApplicationCache { get; set; }
	}
}
