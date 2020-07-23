using System;

using TurboSMS.Properties;

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
			Token = token ?? throw new ArgumentNullException(Resources.REQUIRED_TOKEN);

			provider = new QueriesProvider(module);
		}

		/// <summary>
		/// Проверяет работу API.
		/// </summary>
		/// <returns>Истина, если получен корректны ответ.</returns>
		public bool Ping()
		{
			string result = SendRequest(Resources.DefaultModuleMethod_Ping, null);

			if (string.IsNullOrWhiteSpace(result))
				return false;

			var obj = Response<object>.FromJson(result);

			if (obj == null)
				return false;

			if (obj.ResponseStatus == ResponseStatus.PONG)
				return true;

			CheckQueryResult(obj);

			return false;
		}

		/// <summary>
		/// Выполняет POST-запрос к API.
		/// </summary>
		/// <param name="method">Имя метода текущего модуля.</param>
		/// <param name="obj">Данные запроса.</param>
		/// <remarks>Т.к. API одинаково поддерживает все типы запросов используется самый универсальный метод.</remarks>
		/// <returns>Строка в формате json.</returns>
		protected string SendRequest(string method, IJsonConvertable obj)
		{
			if (string.IsNullOrWhiteSpace(method))
				throw new ArgumentException(Resources.EmptyModuleName);

			var request = provider.CreateRequest(Token, QueriesProvider.RequestMethod.POST, method);

			provider.SetData(request, obj?.ToJson());

			var response = provider.ReadResponse(request);

			return provider.ReadResponseAsString(response);
		}

		/// <summary>
		/// Проверяет ответ сервера. В случае ошибки выбрасывает исключение с детальным описанием.
		/// </summary>
		/// <typeparam name="TResponse">Тип ответа сервера. Зависит от метода модуля.</typeparam>
		/// <param name="response">Ответ сервера.</param>
		/// <exception cref="AggregateException">Детальное описание ошибки.</exception>
		internal static void CheckQueryResult<TResponse>(Response<TResponse> response)
		{
			if (response == null)
				throw new ArgumentNullException(Resources.CantReadServerResponse);

			switch (response.ResponseStatus)
			{
				case ResponseStatus.OK:
				case ResponseStatus.PONG:
						return;
				case ResponseStatus.REQUIRED_TOKEN:
					throw new AggregateException(Resources.REQUIRED_TOKEN);

				case ResponseStatus.REQUIRED_CONTENT:
					throw new AggregateException(Resources.REQUIRED_CONTENT);

				case ResponseStatus.REQUIRED_AUTH:
					throw new AggregateException(Resources.REQUIRED_AUTH);

				case ResponseStatus.REQUIRED_ACTIVE_USER:
					throw new AggregateException(Resources.REQUIRED_ACTIVE_USER);

				case ResponseStatus.REQUIRED_MESSAGE_SENDER:
					throw new AggregateException(Resources.REQUIRED_MESSAGE_SENDER);

				case ResponseStatus.REQUIRED_MESSAGE_TEXT:
					throw new AggregateException(Resources.REQUIRED_MESSAGE_TEXT);

				case ResponseStatus.REQUIRED_MESSAGE_RECIPIENT:
					throw new AggregateException(Resources.REQUIRED_MESSAGE_RECIPIENT);

				case ResponseStatus.REQUIRED_BALANCE:
					throw new AggregateException(Resources.REQUIRED_BALANCE);

				case ResponseStatus.REQUIRED_MESSAGE_BUTTON:
					throw new AggregateException(Resources.REQUIRED_MESSAGE_BUTTON);

				case ResponseStatus.REQUIRED_MESSAGE_BUTTON_CAPTION:
					throw new AggregateException(Resources.REQUIRED_MESSAGE_BUTTON_CAPTION);

				case ResponseStatus.REQUIRED_MESSAGE_BUTTON_ACTION:
					throw new AggregateException(Resources.REQUIRED_MESSAGE_BUTTON_ACTION);

				case ResponseStatus.INVALID_REQUEST:
					throw new AggregateException(Resources.INVALID_REQUEST);

				case ResponseStatus.INVALID_TOKEN:
					throw new AggregateException(Resources.INVALID_TOKEN);

				case ResponseStatus.INVALID_MESSAGE_SENDER:
					throw new AggregateException(Resources.INVALID_MESSAGE_SENDER);

				case ResponseStatus.INVALID_START_TIME:
					throw new AggregateException(Resources.INVALID_START_TIME);

				case ResponseStatus.INVALID_MESSAGE_TEXT:
					throw new AggregateException(Resources.INVALID_MESSAGE_TEXT);

				case ResponseStatus.INVALID_PHONE:
					throw new AggregateException(Resources.INVALID_PHONE);

				case ResponseStatus.INVALID_TTL:
					throw new AggregateException(Resources.INVALID_TTL);

				case ResponseStatus.INVALID_MESSAGE_ID:
					throw new AggregateException(Resources.INVALID_MESSAGE_ID);

				case ResponseStatus.NOT_ALLOWED_MESSAGE_SENDER:
					throw new AggregateException(Resources.NOT_ALLOWED_MESSAGE_SENDER);

				case ResponseStatus.NOT_ALLOWED_MESSAGE_SENDER_NOT_ACTIVE:
					throw new AggregateException(Resources.NOT_ALLOWED_MESSAGE_SENDER_NOT_ACTIVE);

				case ResponseStatus.NOT_ALLOWED_MESSAGE_IMAGE:
					throw new AggregateException(Resources.NOT_ALLOWED_MESSAGE_IMAGE);

				case ResponseStatus.NOT_ALLOWED_START_TIME:
					throw new AggregateException(Resources.NOT_ALLOWED_START_TIME);

				case ResponseStatus.NOT_ALLOWED_NUMBER_STOPLIST:
					throw new AggregateException(Resources.NOT_ALLOWED_NUMBER_STOPLIST);

				case ResponseStatus.NOT_ALLOWED_RECIPIENTS_LIMIT:
					throw new AggregateException(Resources.NOT_ALLOWED_RECIPIENTS_LIMIT);

				case ResponseStatus.NOT_ALLOWED_RECIPIENT_COUNTRY:
					throw new AggregateException(Resources.NOT_ALLOWED_RECIPIENT_COUNTRY);

				case ResponseStatus.NOT_ALLOWED_RECIPIENT_DUPLICATE:
					throw new AggregateException(Resources.NOT_ALLOWED_RECIPIENT_DUPLICATE);

				case ResponseStatus.NOT_ALLOWED_MESSAGE_BUTTON_TEXT_LENGTH:
					throw new AggregateException(Resources.NOT_ALLOWED_MESSAGE_BUTTON_TEXT_LENGTH);

				case ResponseStatus.NOT_ALLOWED_MESSAGE_TTL:
					throw new AggregateException(Resources.NOT_ALLOWED_MESSAGE_TTL);

				case ResponseStatus.NOT_ALLOWED_MESSAGE_TRANSACTION_CONTENT:
					throw new AggregateException(Resources.NOT_ALLOWED_MESSAGE_TRANSACTION_CONTENT);

				case ResponseStatus.NOT_ALLOWED_MESSAGE_DATA:
					throw new AggregateException(Resources.NOT_ALLOWED_MESSAGE_DATA);

				case ResponseStatus.NOT_ALLOWED_MESSAGE_TEXT:
					throw new AggregateException(Resources.NOT_ALLOWED_MESSAGE_TEXT);

				case ResponseStatus.NOT_ALLOWED_MESSAGE_TEXT_LENGTH:
					throw new AggregateException(Resources.NOT_ALLOWED_MESSAGE_TEXT_LENGTH);

				case ResponseStatus.NOT_ALLOWED_MESSAGE_ID:
					throw new AggregateException(Resources.NOT_ALLOWED_MESSAGE_ID);

				case ResponseStatus.NOT_ALLOWED_MESSAGE_TRANSACTION_SENDER:
					throw new AggregateException(Resources.NOT_ALLOWED_MESSAGE_TRANSACTION_SENDER);

				case ResponseStatus.FAILED_CONVERT_RESULT2JSON:
					throw new AggregateException(Resources.FAILED_CONVERT_RESULT2JSON);

				case ResponseStatus.FAILED_CONVERT_RESULT2XML:
					throw new AggregateException(Resources.FAILED_CONVERT_RESULT2XML);

				case ResponseStatus.FAILED_PARSE_BODY:
					throw new AggregateException(Resources.FAILED_PARSE_BODY);

				case ResponseStatus.FAILED_SMS_SEND:
					throw new AggregateException(Resources.FAILED_SMS_SEND);

				case ResponseStatus.FAILED_VIBER_SEND:
					throw new AggregateException(Resources.FAILED_VIBER_SEND);

				case ResponseStatus.FAILED_SAVE_IMAGE:
					throw new AggregateException(Resources.FAILED_SAVE_IMAGE);

				case ResponseStatus.SUCCESS_MESSAGE_ACCEPTED:
					throw new AggregateException(Resources.SUCCESS_MESSAGE_ACCEPTED);

				case ResponseStatus.SUCCESS_MESSAGE_SENT:
					throw new AggregateException(Resources.SUCCESS_MESSAGE_SENT);

				case ResponseStatus.SUCCESS_MESSAGE_PARTIAL_ACCEPTED:
					throw new AggregateException(Resources.SUCCESS_MESSAGE_PARTIAL_ACCEPTED);

				case ResponseStatus.SUCCESS_MESSAGE_PARTIAL_SENT:
					throw new AggregateException(Resources.SUCCESS_MESSAGE_PARTIAL_SENT);

				case ResponseStatus.FATAL_ERROR:
					throw new AggregateException(Resources.FATAL_ERROR);

				default:
					throw new ArgumentOutOfRangeException("Значение поля ResponseStatus непредусмотренно.");
			}
		}
	}
}
