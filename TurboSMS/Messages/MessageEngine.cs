using System;
using System.Collections.Generic;

using TurboSMS.Properties;

namespace TurboSMS.Messages
{
	/// <summary>
	/// Модуль предусматривает работу с сообщениями, такую как создание рассылок, их отправка и проверка статусов доставки.
	/// </summary>
	public sealed class MessageEngine : Engine
	{
		public MessageEngine(string token) : base(token, Resources.Module_Message) { }

		/// <summary>
		/// Метод позволяет отправлять SMS и Viber сообщения, а также поддерживает гибридную Viber отправку (если сообщение не было доставлено в Viber, оно автоматически будет отправлено по SMS).
		/// </summary>
		/// <param name="message">Данные сообщения.</param>
		/// <returns>Результат операции.</returns>
		public List<SendMessageResponse> SendMessage(Message message)
		{
			string result = SendRequest(Resources.MessageEngineMethod_Send, message);

			if (string.IsNullOrWhiteSpace(result))
				throw new InvalidOperationException(Resources.EmptyServerResponse);

			var obj = Response<List<SendMessageResponse>>.FromJson(result);

			CheckQueryResult(obj);

			return obj?.ResponseResult;
		}

		/// <summary>
		/// Метод позволяет получить информацию о статусе доставки сообщения, достаточно лишь передать список message_id.
		/// </summary>
		/// <param name="status">Список сообщений, статус для которых требуется получить.</param>
		/// <returns>Статус доставки.</returns>
		public List<StatusMessageResponse> ReadStatus(Status status)
		{
			string result = SendRequest(Resources.MessageEngineMethod_Status, status);

			if (string.IsNullOrWhiteSpace(result))
				throw new InvalidOperationException(Resources.EmptyServerResponse);

			var obj = Response<List<StatusMessageResponse>>.FromJson(result);

			CheckQueryResult(obj);

			return obj?.ResponseResult;
		}
	}
}
