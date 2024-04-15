using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PrivateNetworkRequestPolicy
	{
			Allow,
			BlockFromInsecureToMorePrivate,
			WarnFromInsecureToMorePrivate,
			PreflightBlock,
			PreflightWarn,
	}
}
