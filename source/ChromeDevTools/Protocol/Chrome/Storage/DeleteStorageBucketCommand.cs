using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Deletes the Storage Bucket with the given storage key and bucket name.
	/// </summary>
	[Command(ProtocolName.Storage.DeleteStorageBucket)]
	[SupportedBy("Chrome")]
	public class DeleteStorageBucketCommand: ICommand<DeleteStorageBucketCommandResponse>
	{
		/// <summary>
		/// Gets or sets StorageKey
		/// </summary>
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or sets BucketName
		/// </summary>
		public string BucketName { get; set; }
	}
}
