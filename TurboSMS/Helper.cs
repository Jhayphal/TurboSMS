using System;
using System.Text;
using System.Collections.Generic;

using TurboSMS.Properties;

namespace TurboSMS
{
	/// <summary>
	/// Содержит методы проверки и приведения телефонных номеров к формату 380ХХХХХХХХХ.
	/// </summary>
	public static class Helper
	{
		public const int PhoneNumberMinimumDigitsCount = 9; // (-38 -0) 50 123 45 67
		public const int PhoneNumberDigitsCount = 12; // 38 050 123 45 67
		public const string PhoneNumberStartsWith = "380";

		/// <summary>
		/// Оставляет в строке только цифры и приводит к формату 380ХХХХХХХХХ. В случае неудачи выбрасывает исключение InvalidOperationException с информацией об ошибке.
		/// </summary>
		/// <param name="phone">Номер телефона.</param>
		/// <exception cref="InvalidOperationException">Детальная информация об ошибке.</exception>
		/// <returns>Номер телефона в формате 380ХХХХХХХХХ.</returns>
		public static string PreparePhoneNumber(string phone)
		{
			if (string.IsNullOrWhiteSpace(phone))
				throw new InvalidOperationException(Resources.EmptyValue);

			phone = dropNotDecimalDigit(phone);

			if (string.IsNullOrWhiteSpace(phone))
				throw new InvalidOperationException(Resources.NumberHasntDigits);

			int length = phone.Length;

			if (length < PhoneNumberMinimumDigitsCount)
				throw new InvalidOperationException($"Недостаточно данных. Требуется минимум { PhoneNumberMinimumDigitsCount } символов, значение ({ phone }) содержит всего { length } символов.");

			if (length > PhoneNumberDigitsCount)
				throw new InvalidOperationException($"Значение { phone } не является номером телефона, т.к. превышает допустимую длину ({ PhoneNumberDigitsCount } символов).");

			if (length == PhoneNumberDigitsCount)
			{
				if (phone.StartsWith(PhoneNumberStartsWith))
					return phone;

				throw new InvalidOperationException($"Неккоректный номер: { phone }. Номер телефона должен начинаться с { PhoneNumberStartsWith }.");
			}

			int startLength = PhoneNumberDigitsCount - length;

			phone = PhoneNumberStartsWith.Substring(0, startLength) + phone;

			if (!phone.StartsWith(PhoneNumberStartsWith))
				throw new InvalidOperationException($"Неккоректный номер: { phone }. Номер телефона должен начинаться с { PhoneNumberStartsWith }.");

			return phone;
		}

		/// <summary>
		/// Возвращает список форматированных номеров телефонов из строки, в которой номера разделены одним из символов разделителей.
		/// </summary>
		/// <param name="phones">Строка с номерами телефонов.</param>
		/// <param name="separators">Знаки разделители.</param>
		/// <param name="throwException">Выбрасывать исключения. Если лошь, значения, спровоцировавшие исключения отбрасываются.</param>
		/// <returns>Список форматированных номеров телефонов.</returns>
		public static List<string> GetFormattedPhoneNumbersList(string phones, string separators = "\n", bool throwException = false)
		{
			if (separators == null)
				throw new ArgumentException(Resources.EmptyParam_Phones);

			if (separators == null)
				throw new ArgumentException(Resources.EmptyParam_Separators);

			List<string> result = new List<string>();

			if (phones.TrimEnd() == string.Empty)
				return result;

			string[] words = phones.Split(separators.ToCharArray());

			foreach (string word in words)
			{
				try
				{
					if(word.TrimEnd() != string.Empty)
						result.Add(PreparePhoneNumber(word));
				}
				catch
				{
					if (throwException)
						throw;
				}
			}

			return result;
		}

		/// <summary>
		/// Удаляет все нечисловые символы из строки.
		/// </summary>
		/// <param name="value">Значение.</param>
		/// <returns>Строка из чисел, либо пустая строка, в случае отсутствия таковых.</returns>
		static string dropNotDecimalDigit(string value)
		{
			StringBuilder sb = new StringBuilder();

			foreach (char letter in value)
				if (char.IsDigit(letter))
					sb.Append(letter);

			return sb.ToString();
		}
	}
}
