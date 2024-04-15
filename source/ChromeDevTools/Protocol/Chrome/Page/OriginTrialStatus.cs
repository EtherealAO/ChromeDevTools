using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Status for an Origin Trial.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OriginTrialStatus
	{
			Enabled,
			ValidTokenNotProvided,
			OSNotSupported,
			TrialNotAllowed,
	}
}
