using System.Globalization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TurboSMS
{
	/// <summary>
	/// Используется в качестве настройки для сериализации в json.
	/// </summary>
	internal static class Converter
	{
		/// <summary>
		/// Параметры сериализации.
		/// </summary>
		public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
		{
			MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
			DateParseHandling = DateParseHandling.None,
			Converters =
			{
				new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
			},
		};
	}
}
