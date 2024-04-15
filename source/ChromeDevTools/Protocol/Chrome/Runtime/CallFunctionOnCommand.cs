using Newtonsoft.Json;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Calls function with given declaration on the given object. Object group of the result is
	/// inherited from the target object.
	/// </summary>
	[Command(ProtocolName.Runtime.CallFunctionOn)]
	[SupportedBy("Chrome")]
	public class CallFunctionOnCommand: ICommand<CallFunctionOnCommandResponse>
	{
		/// <summary>
		/// Gets or sets Declaration of the function to call.
		/// </summary>
		public string FunctionDeclaration { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the object to call function on. Either objectId or executionContextId should
		/// be specified.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Call arguments. All call arguments must belong to the same JavaScript world as the target
		/// object.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CallArgument[] Arguments { get; set; }
		/// <summary>
		/// Gets or sets In silent mode exceptions thrown during evaluation are not reported and do not pause
		/// execution. Overrides `setPauseOnException` state.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Silent { get; set; }
		/// <summary>
		/// Gets or sets Whether the result is expected to be a JSON object which should be sent by value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReturnByValue { get; set; }
		/// <summary>
		/// Gets or sets Whether preview should be generated for the result.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
		/// <summary>
		/// Gets or sets Whether execution should be treated as initiated by user in the UI.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? UserGesture { get; set; }
		/// <summary>
		/// Gets or sets Whether execution should `await` for resulting value and return once awaited promise is
		/// resolved.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AwaitPromise { get; set; }
		/// <summary>
		/// Gets or sets Specifies execution context which global object will be used to call function on. Either
		/// executionContextId or objectId should be specified.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ExecutionContextId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects. If objectGroup is not
		/// specified and objectId is, objectGroup will be inherited from object.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
		/// <summary>
		/// Gets or sets Whether to throw an exception if side effect cannot be ruled out during evaluation.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ThrowOnSideEffect { get; set; }
		/// <summary>
		/// Gets or sets An alternative way to specify the execution context to call function on.
		/// Compared to contextId that may be reused across processes, this is guaranteed to be
		/// system-unique, so it can be used to prevent accidental function call
		/// in context different than intended (e.g. as a result of navigation across process
		/// boundaries).
		/// This is mutually exclusive with `executionContextId`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UniqueContextId { get; set; }
		/// <summary>
		/// Gets or sets Whether the result should contain `webDriverValue`, serialized according to
		/// https://w3c.github.io/webdriver-bidi. This is mutually exclusive with `returnByValue`, but
		/// resulting `objectId` is still provided.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GenerateWebDriverValue { get; set; }
	}
}
