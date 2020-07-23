using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace TurboSMS.Messages
{
	/// <summary>
	/// Результат отправки сообщения.
	/// </summary>
	public class SendMessageResponse
	{
		/// <summary>
		/// Номер телефона адресата.
		/// </summary>
		[JsonProperty("phone", Required = Required.Always)]
		public string Phone { get; set; }

		/// <summary>
		/// Код ответа.
		/// </summary>
		[JsonProperty("response_code", Required = Required.Always)]
		public long ResponseCode { get; set; }

		/// <summary>
		/// Идентификатор сообщения.
		/// </summary>
		[JsonProperty("message_id", Required = Required.AllowNull)]
		public Guid? MessageId { get; set; }

		/// <summary>
		/// Текст ответа.
		/// </summary>
		[JsonProperty("response_status", Required = Required.Always)]
		public string ResponseStatus { get; set; }
	}
}
