using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StorageBucketsDurability
	{
			Relaxed,
			Strict,
	}
}
