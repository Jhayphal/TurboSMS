using Newtonsoft.Json;

using TurboSMS.Messages;

namespace TurboSMS
{
	/// <summary>
	/// Предназначен для сериализации объектов в json.
	/// </summary>
	internal static class Serialize
	{
		public static string ToJson(this Message self) => JsonConvert.SerializeObject(self, Converter.Settings);

		public static string ToJson(this Status self) => JsonConvert.SerializeObject(self, Converter.Settings);
	}
}
