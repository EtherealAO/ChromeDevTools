using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Page.SetDeviceOrientationOverride)]
	[SupportedBy("Chrome")]
	public class SetDeviceOrientationOverrideCommand: ICommand<SetDeviceOrientationOverrideCommandResponse>
	{
		/// <summary>
		/// Gets or sets Mock alpha
		/// </summary>
		public double Alpha { get; set; }
		/// <summary>
		/// Gets or sets Mock beta
		/// </summary>
		public double Beta { get; set; }
		/// <summary>
		/// Gets or sets Mock gamma
		/// </summary>
		public double Gamma { get; set; }
	}
}
