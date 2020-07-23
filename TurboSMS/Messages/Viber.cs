using Newtonsoft.Json;

namespace TurboSMS.Messages
{
	/// <summary>
	/// Сообщение для Viber.
	/// </summary>
	public class Viber : GlobalMessageParameters
	{
		/// <summary>
		/// Срок жизни сообщения, в течение которого оно будет доставляться. Если сообщение не было доставлено по прошествии этого времени, оно будет считать не доставленным. Указывается в секундах, возможны значения от 60 до 86400, по умолчанию 3600.
		/// </summary>
		[JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
		public int LifeTime { get; set; }

		/// <summary>
		/// URL адрес изображения, которое будет отображено в сообщении.
		/// </summary>
		[JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
		public string ImageUrl { get; set; }

		/// <summary>
		/// Текст на кнопке в сообщении.
		/// </summary>
		[JsonProperty("caption", NullValueHandling = NullValueHandling.Ignore)]
		public string ButtonCaption { get; set; }

		/// <summary>
		/// URL адрес, куда перейдёт получатель сообщения при нажатии на кнопку.
		/// </summary>
		[JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
		public string ButtonAction { get; set; }

		/// <summary>
		/// Флаг статистики переходов (1 - будет вестись статистика, любые другие значения или отсутствие данного параметра - нет).
		/// </summary>
		[JsonProperty("count_clicks", NullValueHandling = NullValueHandling.Ignore)]
		public bool CountClicks { get; set; }

		/// <summary>
		/// Флаг транзакционного сообщения (1 - да, любые другие значения или отсутствие данного параметра - нет). Отправка транзакционных сообщений от общего отправителя запрещена.
		/// </summary>
		[JsonProperty("is_transactional", NullValueHandling = NullValueHandling.Ignore)]
		public bool Transactional { get; set; }
	}
}
