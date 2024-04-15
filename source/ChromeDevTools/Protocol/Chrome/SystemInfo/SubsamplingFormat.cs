using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo{
	/// <summary>
	/// YUV subsampling type of the pixels of a given image.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SubsamplingFormat
	{
			Yuv420,
			Yuv422,
			Yuv444,
	}
}
