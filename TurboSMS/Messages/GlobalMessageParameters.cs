using System.Collections.Generic;

using Newtonsoft.Json;

namespace TurboSMS.Messages
{
	/// <summary>
	/// Содержит общие параметры сообщения.
	/// </summary>
	public abstract class GlobalMessageParameters
	{
		/// <summary>
		/// Имя отправителя, от которого будет отправлено сообщение (альфаимя для SMS или отправитель для Viber). Отправитель должен быть активирован в Вашем аккаунте.
		/// </summary>
		/// <remarks>Обязательное поле.</remarks>
		[JsonProperty("sender", NullValueHandling = NullValueHandling.Ignore)]
		public string Sender { get; set; }

		/// <summary>
		/// Дата и время отложенной отправки, поддерживает множество ISO форматов, рекомендуется использовать формат ГГГГ-ММ-ДД ЧЧ:ММ. Допустимо указывать дату, не превышающую 14 дней от текущего момента. Не передавайте этот параметр, если сообщение нужно отправить мгновенно.
		/// </summary>
		[JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
		public string StartTime { get; set; }

		/// <summary>
		/// Текст сообщения. Для Viber может быть до 1000 символов, для SMS — 1521 символ латиницей или 661 символ кириллического текста (10 сегментов). Поддерживаются символы кодировки UTF-8.
		/// </summary>
		/// <remarks>Обязательное поле.</remarks>
		[JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
		public string Text { get; set; }

		/// <summary>
		/// Получатели сообщения, указываются в международном формате (380ХХХХХХХХХ). Параметр всегда должен быть передан в виде массива, даже если получатель только один. Допускается не более 5000 получателей в одном запросе.
		/// </summary>
		/// <remarks>Обязательное поле.</remarks>
		[JsonProperty("recipients", NullValueHandling = NullValueHandling.Ignore)]
		public List<string> Recipients { get; set; }
	}
}
