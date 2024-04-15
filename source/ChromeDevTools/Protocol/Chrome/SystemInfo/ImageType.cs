using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo{
	/// <summary>
	/// Image format of a given image.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ImageType
	{
			Jpeg,
			Webp,
			Unknown,
	}
}
