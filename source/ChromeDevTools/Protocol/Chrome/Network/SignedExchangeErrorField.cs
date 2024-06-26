using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Field type for a signed exchange related error.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SignedExchangeErrorField
	{
			SignatureSig,
			SignatureIntegrity,
			SignatureCertUrl,
			SignatureCertSha256,
			SignatureValidityUrl,
			SignatureTimestamps,
	}
}
