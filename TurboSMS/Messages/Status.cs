using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace TurboSMS.Messages
{
	/// <summary>
	/// Список сообщений, статус для которых требуется получить.
	/// </summary>
	public class Status : IJsonConvertable
	{
		/// <summary>
		/// Список сообщений.
		/// </summary>
		[JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
		public List<Guid> Messages { get; set; }

		public string ToJson() => JsonConvert.SerializeObject(this, Converter.Settings);
	}
}
