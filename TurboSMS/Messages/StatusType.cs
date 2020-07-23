namespace TurboSMS.Messages
{
	/// <summary>
	/// Статус доставки сообщения.
	/// </summary>
	public enum StatusType
	{
		/// <summary>
		/// Сообщение принято в обработку и будет отправлено.
		/// </summary>
		Queued,

		/// <summary>
		/// Сообщение отправлено в мобильную сеть, но ещё не обработан ответ от оператора.
		/// </summary>
		Accepted,

		/// <summary>
		/// Сообщение отправлено и ожидается его доставка.
		/// </summary>
		Sent,

		/// <summary>
		/// Сообщение доставлено получателю.
		/// </summary>
		Delivered,

		/// <summary>
		/// Сообщение прочитано получателем.
		/// </summary>
		Read,

		/// <summary>
		/// Истек срок сообщения, за который оно должно было доставиться.
		/// </summary>
		Expired,

		/// <summary>
		/// Не доставлено.
		/// </summary>
		Undelivered,

		/// <summary>
		/// Сообщение отклонено.
		/// </summary>
		Rejected,

		/// <summary>
		/// Неизвестный статус.
		/// </summary>
		Unknown,

		/// <summary>
		/// Невозможно отправить сообщение.
		/// </summary>
		Failed,

		/// <summary>
		/// Отправка отменена и кредиты возвращены на баланс.
		/// </summary>
		Cancelled
	}
}
