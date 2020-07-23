using System;

using Newtonsoft.Json;

namespace TurboSMS.Messages
{
	/// <summary>
	/// Информация о статусе доставки сообщения.
	/// </summary>
	public class StatusMessageResponse
	{
		/// <summary>
		/// Идентификатор сообщения.
		/// </summary>
		[JsonProperty("message_id", Required = Required.Always)]
		public Guid MessageId { get; set; }

		/// <summary>
		/// Цифровой код результата обработки запроса, имеет значения от 0 до 999.
		/// </summary>
		[JsonProperty("response_code")]
		public long ResponseCode { get; set; }

		/// <summary>
		/// Статус результата обработки запроса, представляет собой сокращённое описание результата.
		/// </summary>
		[JsonProperty("response_status")]
		public ResponseStatus ResponseStatus { get; set; }

		/// <summary>
		/// Получатели сообщения, указываются в международном формате (380ХХХХХХХХХ). Параметр всегда должен быть передан в виде массива, даже если получатель только один. Допускается не более 5000 получателей в одном запросе.
		/// </summary>
		[JsonProperty("recipient", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
		public string Recipient { get; set; }

		/// <summary>
		/// Время фактической отправки сообщения.
		/// </summary>
		[JsonProperty("sent")]
		public DateTimeOffset? Sent { get; set; }

		/// <summary>
		/// Время обновления статуса доставки.
		/// </summary>
		[JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
		public DateTimeOffset? Updated { get; set; }

		/// <summary>
		/// Статус доставки сообщения.
		/// </summary>
		[JsonProperty("status", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
		public StatusType Status { get; set; }

		/// <summary>
		/// Какой канал был использован для отправки сообщения.
		/// </summary>
		[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
		public string Type { get; set; }

		/// <summary>
		/// Если Viber сообщение невозможно отправить, в этом поле будет содержаться причина. При успешной отправке в значении будет пустая строка.
		/// </summary>
		[JsonProperty("rejected_status", NullValueHandling = NullValueHandling.Ignore)]
		public RejectedStatus? RejectedStatus { get; set; }
	}
}
