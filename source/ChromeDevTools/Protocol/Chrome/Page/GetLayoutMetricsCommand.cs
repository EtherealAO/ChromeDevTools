namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
	/// </summary>
	[Command(ProtocolName.Page.GetLayoutMetrics)]
	[SupportedBy("Chrome")]
	public class GetLayoutMetricsCommand: ICommand<GetLayoutMetricsCommandResponse>
	{
	}
}
