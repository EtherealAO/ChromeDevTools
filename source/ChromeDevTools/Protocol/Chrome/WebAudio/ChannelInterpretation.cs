using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio{
	/// <summary>
	/// Enum of AudioNode::ChannelInterpretation from the spec
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChannelInterpretation
	{
			Discrete,
			Speakers,
	}
}
