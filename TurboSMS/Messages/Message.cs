using Newtonsoft.Json;

namespace TurboSMS.Messages
{
	/// <summary>
	/// Данные сообщения.
	/// </summary>
	/// <remarks>В зависимости от того, какой тип сообщения нужно отправлять, должны присутствовать параметры viber или sms, или оба, для гибридной отправки. При создании сообщения, в первую очередь, используются значения глобальных параметров, но при необходимости их значения можно переопределить локальными параметрами. Например, можно указать глобальный параметр text и при наличии параметров viber и sms его значение будет использовано и для Viber, и для sms сообщения. Если в параметре sms указать другое значение параметра text, то для sms будет использовано оно. Таким образом, если значение параметра совпадает для обоих типов сообщения, его можно указать только в глобальных параметрах и не дублировать в локальных.</remarks>
	public class Message : GlobalMessageParameters
	{
		/// <summary>
		/// Сообщение для Viber.
		/// </summary>
		[JsonProperty("viber", NullValueHandling = NullValueHandling.Ignore)]
		public Viber Viber { get; set; }

		/// <summary>
		/// Sms сообщение.
		/// </summary>
		[JsonProperty("sms", NullValueHandling = NullValueHandling.Ignore)]
		public Sms Sms { get; set; }
	}
}
