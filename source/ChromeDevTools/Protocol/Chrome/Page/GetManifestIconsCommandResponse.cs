using Newtonsoft.Json;
using System;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Deprecated because it's not guaranteed that the returned icon is in fact the one used for PWA installation.
	/// </summary>
	[Obsolete("Deprecated because it's not guaranteed that the returned icon is in fact the one used for PWA installation.")]
	[CommandResponse(ProtocolName.Page.GetManifestIcons)]
	[SupportedBy("Chrome")]
	public class GetManifestIconsCommandResponse
	{
		/// <summary>
		/// Gets or sets PrimaryIcon
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PrimaryIcon { get; set; }
	}
}
