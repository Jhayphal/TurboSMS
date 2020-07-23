using System;

using TurboSMS.Properties;

namespace TurboSMS.Users
{
	/// <summary>
	/// Модуль предусматривает работу с аккаунтом пользователя.
	/// </summary>
	public sealed class UserEngine : Engine
	{
		public UserEngine(string token) : base(token, Resources.Module_User) { }

		/// <summary>
		/// Возвращает остаток кредитов на балансе пользователя.
		/// </summary>
		/// <returns>Остаток кредитов.</returns>
		public BalanceUserResponse ReadBalance()
		{
			string result = SendRequest(Resources.UserEngineMethod_Balance, null);

			if (string.IsNullOrWhiteSpace(result))
				throw new InvalidOperationException(Resources.EmptyServerResponse);

			var obj = Response<BalanceUserResponse>.FromJson(result);

			CheckQueryResult(obj);

			return obj?.ResponseResult;
		}
	}
}
