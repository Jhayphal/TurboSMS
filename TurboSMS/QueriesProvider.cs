using System;
using System.IO;
using System.Net;
using System.Text;
using TurboSMS.Properties;

namespace TurboSMS
{
	/// <summary>
	/// Провайдер запросов к API.
	/// </summary>
	internal class QueriesProvider
	{
		/// <summary>
		/// Список методов протокола HTTP.
		/// </summary>
		public enum RequestMethod
		{
			GET,
			POST,
			PUT,
			DELETE
		}

		/// <summary>
		/// Адрес API.
		/// </summary>
		private const string Api = "https://api.turbosms.ua";

		/// <summary>
		/// Заголовок ContentType для текущего формата работы с API.
		/// </summary>
		private const string DefaultContentType = "application/json";

		/// <summary>
		/// Имя заголовка, в котором хранится ключ авторизации.
		/// </summary>
		private const string AuthorizationHeaderName = "Authorization";

		/// <summary>
		/// Имя текущего модуля.
		/// </summary>
		public readonly string Module;

		/// <summary>
		/// Базовый конструктор.
		/// </summary>
		/// <param name="module">Имя текущего модуля.</param>
		public QueriesProvider(string module)
		{
			if (string.IsNullOrWhiteSpace(module))
				throw new ArgumentException(Resources.EmptyModuleName);

			Module = module;
		}

		/// <summary>
		/// Создает запрос HttpWebRequest.
		/// </summary>
		/// <param name="token">Ключ авторизации.</param>
		/// <param name="methodType">Метод протокола HTTP.</param>
		/// <param name="method">Метод текущего модуля.</param>
		/// <param name="format">Формат возвращаемых данных.</param>
		/// <returns>Объект HttpWebRequest.</returns>
		public HttpWebRequest CreateRequest(string token, RequestMethod methodType, string method, string format = "json")
		{
			string url = getMethodUrl(method, format);

			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

			request.Timeout = 60 * 1000;
			request.Method = methodType.ToString();
			request.ContentType = DefaultContentType;

			request.Headers.Add(AuthorizationHeaderName, $"Basic { token }");

			return request;
		}

		/// <summary>
		/// Записывает данные в HttpWebRequest.
		/// </summary>
		/// <param name="request">Запрос.</param>
		/// <param name="data">Данные.</param>
		/// <remarks>Используется для POST и PUT запросов.</remarks>
		public void SetData(HttpWebRequest request, string data)
		{
			if (data == null)
			{
				request.ContentLength = 0;

				return;
			}

			byte[] byteArray = Encoding.UTF8.GetBytes(data);

			request.ContentLength = byteArray.Length;

			using (Stream dataStream = request.GetRequestStream())
			{
				dataStream.Write(byteArray, 0, byteArray.Length);
				dataStream.Close();
			}
		}

		/// <summary>
		/// Получает результат выполнения запроса.
		/// </summary>
		/// <param name="request">Запрос.</param>
		/// <returns>Результат выполнения запроса.</returns>
		/// <remarks>Содержит внутренюю логику обработки ошибок.</remarks>
		public HttpWebResponse ReadResponse(WebRequest request)
		{
			try
			{
				var response = (HttpWebResponse) request.GetResponse();

				return response;
			}
			catch (WebException e)
			{
				if (e.Response is HttpWebResponse resp)
				{
					using (Stream responseStream = resp.GetResponseStream())
					{
						if (responseStream == null)
							throw;

						using (StreamReader responseReader = new StreamReader(responseStream))
						{
							string response = responseReader.ReadToEnd();

							throw new WebException(response);
						}
					}
				}

				throw;
			}
		}

		/// <summary>
		/// Возвращает данные ответа в виде строки.
		/// </summary>
		/// <param name="response">Запрос.</param>
		/// <returns>Данные ответа.</returns>
		public string ReadResponseAsString(WebResponse response)
		{
			string result;

			using (Stream responseStream = response.GetResponseStream())
			{
				if (responseStream == null)
					throw new InvalidOperationException(Resources.CantReadServerResponse);

				using (StreamReader streamReader = new StreamReader(responseStream))
					result = streamReader.ReadToEnd();
			}

			return result;
		}

		/// <summary>
		/// Генерирует полный URL для запроса методу к API.
		/// </summary>
		/// <param name="method">Метод текущего модуля.</param>
		/// <param name="format">Формат возвращаемых данных.</param>
		/// <returns>URL метода API.</returns>
		string getMethodUrl(string method, string format = "json")
		{
			if (string.IsNullOrEmpty(method))
				throw new ArgumentException(Resources.EmptyModuleName);

			if (string.IsNullOrEmpty(format))
				throw new ArgumentException(Resources.EmptyQueryFormat);

			return $"{Api}/{Module}/{method}.{format}";
		}
	}
}
