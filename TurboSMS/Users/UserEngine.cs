namespace TurboSMS.Users
{
	/// <summary>
	/// Модуль предусматривает работу с аккаунтом пользователя.
	/// </summary>
	public class UserEngine : Engine
	{
		public UserEngine(string token) : base(token, "user") { }

		/// <summary>
		/// Возвращает остаток кредитов на балансе пользователя.
		/// </summary>
		/// <returns>Остаток кредитов.</returns>
		public BalanceUserResponse ReadBalance()
		{
			string result = SendPOSTRequest("balance", null);

			if (string.IsNullOrWhiteSpace(result))
				return null;

			var obj = Response<BalanceUserResponse>.FromJson(result);

			return obj?.ResponseResult;
		}
	}
}
