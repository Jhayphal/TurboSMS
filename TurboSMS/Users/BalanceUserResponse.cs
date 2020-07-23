using Newtonsoft.Json;

namespace TurboSMS.Users
{
	/// <summary>
	/// Остаток кредитов на балансе пользователя.
	/// </summary>
	public class BalanceUserResponse
	{
		/// <summary>
		/// Остаток кредитов.
		/// </summary>
		[JsonProperty("balance", Required = Required.Always)]
		public double Balance { get; set; }
	}
}
