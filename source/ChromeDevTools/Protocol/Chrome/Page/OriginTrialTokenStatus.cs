using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Origin Trial(https://www.chromium.org/blink/origin-trials) support.
	/// Status for an Origin Trial token.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OriginTrialTokenStatus
	{
			Success,
			NotSupported,
			Insecure,
			Expired,
			WrongOrigin,
			InvalidSignature,
			Malformed,
			WrongVersion,
			FeatureDisabled,
			TokenDisabled,
			FeatureDisabledForUser,
			UnknownTrial,
	}
}
