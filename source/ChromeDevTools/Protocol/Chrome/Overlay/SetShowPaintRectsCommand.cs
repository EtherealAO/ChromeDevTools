namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>
	[Command(ProtocolName.Overlay.SetShowPaintRects)]
	[SupportedBy("Chrome")]
	public class SetShowPaintRectsCommand: ICommand<SetShowPaintRectsCommandResponse>
	{
		/// <summary>
		/// Gets or sets True for showing paint rectangles
		/// </summary>
		public bool Result { get; set; }
	}
}
