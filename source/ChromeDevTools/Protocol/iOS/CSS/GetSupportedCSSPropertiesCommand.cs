namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns all supported CSS property names.
	/// </summary>
	[Command(ProtocolName.CSS.GetSupportedCSSProperties)]
	[SupportedBy("iOS")]
	public class GetSupportedCSSPropertiesCommand: ICommand<GetSupportedCSSPropertiesCommandResponse>
	{
	}
}
