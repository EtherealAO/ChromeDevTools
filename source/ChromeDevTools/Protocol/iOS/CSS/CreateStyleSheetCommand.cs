namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Creates a new special "inspector" stylesheet in the frame with given <code>frameId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.CreateStyleSheet)]
	[SupportedBy("iOS")]
	public class CreateStyleSheetCommand: ICommand<CreateStyleSheetCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the frame where the new "inspector" stylesheet should be created.
		/// </summary>
		public string FrameId { get; set; }
	}
}
