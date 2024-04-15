namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Resets the budget for `ownerOrigin` by clearing all budget withdrawals.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.ResetSharedStorageBudget)]
	[SupportedBy("Chrome")]
	public class ResetSharedStorageBudgetCommandResponse
	{
	}
}
