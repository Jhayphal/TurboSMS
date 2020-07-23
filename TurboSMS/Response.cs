using Newtonsoft.Json;

namespace TurboSMS
{
	/// <summary>
	/// Общая обертка для ответов сервера.
	/// </summary>
	/// <typeparam name="TMethodResponse"></typeparam>
	internal class Response<TMethodResponse>
	{
		/// <summary>
		/// Цифровой код результата обработки запроса, имеет значения от 0 до 999.
		/// </summary>
		[JsonProperty("response_code", Required = Required.Always)]
		public long ResponseCode { get; set; }

		/// <summary>
		/// Статус результата обработки запроса, представляет собой сокращённое описание результата.
		/// </summary>
		[JsonProperty("response_status", Required = Required.Always)]
		public ResponseStatus ResponseStatus { get; set; }

		/// <summary>
		/// Данные ответа, если предусмотрены методом. Может быть null, объектом или массивом объектов.
		/// </summary>
		[JsonProperty("response_result", NullValueHandling = NullValueHandling.Ignore)]
		public TMethodResponse ResponseResult { get; set; }

		public static Response<TMethodResponse> FromJson(string json) => JsonConvert.DeserializeObject<Response<TMethodResponse>>(json, Converter.Settings);
	}
}
