using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// The reason why Chrome uses a specific transport protocol for HTTP semantics.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AlternateProtocolUsage
	{
			AlternativeJobWonWithoutRace,
			AlternativeJobWonRace,
			MainJobWonRace,
			MappingMissing,
			Broken,
			DnsAlpnH3JobWonWithoutRace,
			DnsAlpnH3JobWonRace,
			UnspecifiedReason,
	}
}
