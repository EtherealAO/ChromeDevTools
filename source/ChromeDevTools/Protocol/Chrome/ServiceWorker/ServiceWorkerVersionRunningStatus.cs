using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ServiceWorkerVersionRunningStatus
	{
			Stopped,
			Starting,
			Running,
			Stopping,
	}
}
