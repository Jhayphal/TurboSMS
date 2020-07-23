namespace TurboSMS.Messages
{
	/// <summary>
	/// Причина неудачи отправки сообщения в Viber.
	/// </summary>
	public enum RejectedStatus
	{
		/// <summary>
		/// Получатель не зарегистрирован в Viber.
		/// </summary>
		SRVC_NOT_VIBER_USER,

		/// <summary>
		/// Получатель заблокировал отправителя, от имени которого было отправлено сообщение, либо абсолютно все бизнес сообщения.
		/// </summary>
		SRVC_USER_BLOCKED,

		/// <summary>
		/// Viber получателя не поддерживает приём бизнес сообщений.
		/// </summary>
		SRVC_NO_SUITABLE_DEVICE
	}
}
