using System;

namespace TurboSMS
{
	/// <summary>
	/// Базовый класс для модулей. Содержит необходимый функционал для общения с сервером.
	/// </summary>
	public abstract class Engine
	{
		public readonly string Token;

		private readonly QueriesProvider provider;

		/// <summary>
		/// Базовый конструтор.
		/// </summary>
		/// <param name="token">Ключ аутентификации.</param>
		/// <param name="module">Имя модуля.</param>
		protected Engine(string token, string module)
		{
			Token = token ?? throw new ArgumentNullException("Не указан токен авторизации.");

			provider = new QueriesProvider(module);
		}

		/// <summary>
		/// Проверяет работу API.
		/// </summary>
		/// <returns>Истина, если получен корректны ответ.</returns>
		public bool Ping()
		{
			string result = SendPOSTRequest("ping", null);

			if (string.IsNullOrWhiteSpace(result))
				return false;

			var obj = Response<object>.FromJson(result);

			if (obj == null)
				return false;

			return obj.ResponseStatus == "PONG";
		}

		/// <summary>
		/// Выполняет POST-запрос к API.
		/// </summary>
		/// <param name="method">Имя метода текущего модуля.</param>
		/// <param name="json">Данные запроса.</param>
		/// <remarks>Т.к. API одинаково поддерживает все типы запросов используется самый универсальный метод.</remarks>
		/// <returns>Строка в формате json.</returns>
		protected string SendPOSTRequest(string method, string json)
		{
			if (string.IsNullOrWhiteSpace(method))
				throw new ArgumentException("Не указан метод модуля.");

			var request = provider.CreateRequest(Token, QueriesProvider.RequestMethod.POST, method);

			provider.SetData(request, json);

			var response = provider.ReadResponse(request);

			return provider.ReadResponseAsString(response);
		}
	}
}
