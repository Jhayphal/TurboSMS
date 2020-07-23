using Newtonsoft.Json;

namespace TurboSMS.Messages
{
	/// <summary>
	/// Sms сообщение.
	/// </summary>
	public class Sms : GlobalMessageParameters
	{
		/// <summary>
		/// Флаг flash сообщения (1 - да, любые другие значения или отсутствие данного параметра - нет).
		/// </summary>
		[JsonProperty("is_flash", NullValueHandling = NullValueHandling.Ignore)]
		public bool IsFlash { get; set; }
	}
}
