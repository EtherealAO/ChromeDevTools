using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Details for an origin's shared storage.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedStorageMetadata
	{
		/// <summary>
		/// Gets or sets CreationTime
		/// </summary>
		public double CreationTime { get; set; }
		/// <summary>
		/// Gets or sets Length
		/// </summary>
		public long Length { get; set; }
		/// <summary>
		/// Gets or sets RemainingBudget
		/// </summary>
		public double RemainingBudget { get; set; }
	}
}
