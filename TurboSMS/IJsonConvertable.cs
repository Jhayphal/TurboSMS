namespace TurboSMS
{
	/// <summary>
	/// Конвертируемый в json.
	/// </summary>
	public interface IJsonConvertable
	{
		/// <summary>
		/// Сериализовать объект в json.
		/// </summary>
		/// <returns></returns>
		string ToJson();
	}
}
