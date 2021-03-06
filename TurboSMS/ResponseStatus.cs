﻿
namespace TurboSMS
{
	/// <summary>
	/// Коды обработки запросов.
	/// </summary>
	public enum ResponseStatus
	{
		/// <summary>
		/// Запрос обработан успешно.
		/// </summary>
		OK = 0,

		/// <summary>
		/// Успешный результат вызова метода ping.
		/// </summary>
		PONG = 1,

		/// <summary>
		/// Отсутствует токен аутентификации.
		/// </summary>
		REQUIRED_TOKEN = 103,

		/// <summary>
		/// Отсутствуют данные запроса.
		/// </summary>
		REQUIRED_CONTENT = 104,

		/// <summary>
		/// Аутентификация не пройдена, не верный токен.
		/// </summary>
		REQUIRED_AUTH = 105,

		/// <summary>
		/// Пользователь заблокирован, работа с API невозможна до разблокировки.
		/// </summary>
		REQUIRED_ACTIVE_USER = 106,

		/// <summary>
		/// Отсутствует или пустой параметр отправителя сообщения.
		/// </summary>
		REQUIRED_MESSAGE_SENDER = 200,

		/// <summary>
		/// Отсутствует или пустой параметр текста сообщения.
		/// </summary>
		REQUIRED_MESSAGE_TEXT = 201,

		/// <summary>
		/// Отсутствует или пустой список получателей сообщения.
		/// </summary>
		REQUIRED_MESSAGE_RECIPIENT = 202,

		/// <summary>
		/// Не достаточно кредитов на балансе для создания рассылки.
		/// </summary>
		REQUIRED_BALANCE = 203,

		/// <summary>
		/// Отсутствуют или пустые параметры кнопки в сообщении, когда она обязательна.
		/// </summary>
		REQUIRED_MESSAGE_BUTTON = 204,

		/// <summary>
		/// Отсутствует или пустой параметр текста на кнопке в сообщении.
		/// </summary>
		REQUIRED_MESSAGE_BUTTON_CAPTION = 205,

		/// <summary>
		/// Отсутствует или пустой параметр URL адреса, куда перейдёт получатель сообщения при нажатии на кнопку.
		/// </summary>
		REQUIRED_MESSAGE_BUTTON_ACTION = 206,

		/// <summary>
		/// Неверный запрос, проверьте его структуру и корректность данных.
		/// </summary>
		INVALID_REQUEST = 300,

		/// <summary>
		/// Неверный токен аутентификации.
		/// </summary>
		INVALID_TOKEN = 301,

		/// <summary>
		/// Неверный отправитель сообщения.
		/// </summary>
		INVALID_MESSAGE_SENDER = 302,

		/// <summary>
		/// Неверная дата отложенной отправки сообщения.
		/// </summary>
		INVALID_START_TIME = 303,

		/// <summary>
		/// Недопустимое значение текста сообщения. Возвращается если передано не строковое значение или кодировка символов не входит в набор UTF-8.
		/// </summary>
		INVALID_MESSAGE_TEXT = 304,

		/// <summary>
		/// Недопустимый номер получателя, система не смогла распознать страну и оператора получателя.
		/// </summary>
		INVALID_PHONE = 305,

		/// <summary>
		/// Недопустимое значение параметра LifeTime, значение должно быть целочисленным и не представлено в виде строки.
		/// </summary>
		INVALID_TTL = 306,

		/// <summary>
		/// Недопустимое значение параметра MessageId, неверный формат.
		/// </summary>
		INVALID_MESSAGE_ID = 307,

		/// <summary>
		/// Не разрешённый отправитель для текущего пользователя.
		/// </summary>
		NOT_ALLOWED_MESSAGE_SENDER = 400,

		/// <summary>
		/// Отправитель разрешён, но не активирован на данный момент (не оплачено использование в текущем месяце, не завершена регистрация и т.п.).
		/// </summary>
		NOT_ALLOWED_MESSAGE_SENDER_NOT_ACTIVE = 401,

		/// <summary>
		/// Недопустимый тип файла изображения.
		/// </summary>
		NOT_ALLOWED_MESSAGE_IMAGE = 402,

		/// <summary>
		/// Недопустимая дата отложенной отправки сообщения (выходит за пределы установленных ограничений).
		/// </summary>
		NOT_ALLOWED_START_TIME = 403,

		/// <summary>
		/// Номер получателя находится в стоплисте (для sms) или в игнорлисте (для Viber), отправка невозможна.
		/// </summary>
		NOT_ALLOWED_NUMBER_STOPLIST = 404,

		/// <summary>
		/// Недопустимое количество получателей.
		/// </summary>
		NOT_ALLOWED_RECIPIENTS_LIMIT = 405,

		/// <summary>
		/// Недопустимая страна получателя. У пользователя не активирована возможность отправлять сообщения получателям данной страны. Для активации такой возможности свяжитесь с нашим отделом поддержки клиентов.
		/// </summary>
		NOT_ALLOWED_RECIPIENT_COUNTRY = 406,

		/// <summary>
		/// Получатель уже присутствует в рассылке, дубликаты игнорируются.
		/// </summary>
		NOT_ALLOWED_RECIPIENT_DUPLICATE = 407,

		/// <summary>
		/// Текст на кнопке слишком длинный, длопускается не более 30 символов.
		/// </summary>
		NOT_ALLOWED_MESSAGE_BUTTON_TEXT_LENGTH = 408,

		/// <summary>
		/// Недопустимое значение параметра ttl (выходит за пределы установленных ограничений).
		/// </summary>
		NOT_ALLOWED_MESSAGE_TTL = 409,

		/// <summary>
		/// Недопустимый контент в транзакционном сообщении. В таких сообщениях можно отправлять только текст, а кнопка и изображения запрещены.
		/// </summary>
		NOT_ALLOWED_MESSAGE_TRANSACTION_CONTENT = 410,

		/// <summary>
		/// Какой-то из параметров имеет недопустимое значение, свяжитесь с нашим отделом поддержки клиентов для выяснения деталей.
		/// </summary>
		NOT_ALLOWED_MESSAGE_DATA = 411,

		/// <summary>
		/// Текст содержит запрещённые фрагменты.
		/// </summary>
		NOT_ALLOWED_MESSAGE_TEXT = 412,

		/// <summary>
		/// Превышена допустимая длина текста сообщения.
		/// </summary>
		NOT_ALLOWED_MESSAGE_TEXT_LENGTH = 413,

		/// <summary>
		/// Данные сообщения с переданным message_id недоступны для текущего пользователя.
		/// </summary>
		NOT_ALLOWED_MESSAGE_ID = 414,

		/// <summary>
		/// Запрещено отправлять транзакционные сообщения от общего отправителя.
		/// </summary>
		NOT_ALLOWED_MESSAGE_TRANSACTION_SENDER = 415,

		/// <summary>
		/// Не удалось сконвертировать данные результата в JSON формат, незамедлительно свяжитесь с нашим отделом поддержки клиентов для выяснения деталей.
		/// </summary>
		FAILED_CONVERT_RESULT2JSON = 500,

		/// <summary>
		/// Не удалось сконвертировать данные результата в XML формат, незамедлительно свяжитесь с нашим отделом поддержки клиентов для выяснения деталей.
		/// </summary>
		FAILED_CONVERT_RESULT2XML = 501,

		/// <summary>
		/// Не удалось распознать тело запроса (неверный формат).
		/// </summary>
		FAILED_PARSE_BODY = 502,

		/// <summary>
		/// Не удалось отправить SMS сообщение.
		/// </summary>
		FAILED_SMS_SEND = 503,

		/// <summary>
		/// Не удалось отправить Viber сообщение.
		/// </summary>
		FAILED_VIBER_SEND = 504,

		/// <summary>
		/// Не удалось сохранить изображение.
		/// </summary>
		FAILED_SAVE_IMAGE = 505,

		/// <summary>
		/// Сообщения успешно созданы и добавлены в очередь отправки. Некоторые сообщения могут попадать на предварительную модерацию.
		/// </summary>
		SUCCESS_MESSAGE_ACCEPTED = 800,

		/// <summary>
		/// Сообщения успешно отправлены.
		/// </summary>
		SUCCESS_MESSAGE_SENT = 801,

		/// <summary>
		/// Сообщения успешно созданы и добавлены в очередь отправки, но некоторые получатели не попали в список рассылки, детали смотрите в ответе.
		/// </summary>
		SUCCESS_MESSAGE_PARTIAL_ACCEPTED = 802,

		/// <summary>
		/// Сообщения успешно отправлены, но некоторые получатели не попали в список рассылки, детали смотрите в ответе.
		/// </summary>
		SUCCESS_MESSAGE_PARTIAL_SENT = 803,

		/// <summary>
		/// Ошибка выполнения запроса, свяжитесь с отделом поддержки для выяснения деталей.
		/// </summary>
		FATAL_ERROR = 999
	}
}
