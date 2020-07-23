# TurboSMS
Библиотека для работы с API сервиса turbosms.ua

Примеры использования:

1. Отправить смс:

var message = new TurboSMS.Messages.Message
{
  Sender = this.Sender,
  Text = this.MessageText,
  Recipients = this.Recipients,
  Sms = new Sms()
};

MessageEngine engine = new MessageEngine(this.Token);
var result = engine.SendMessage(message);

2. Отправить сообщение в Viber:

var message = new TurboSMS.Messages.Message
{
  Sender = this.Sender,
  Text = this.MessageText,
  Recipients = this.Recipients,
  Viber = new Viber()
};

MessageEngine engine = new MessageEngine(this.Token);
var result = engine.SendMessage(message);

3. Отправить гибридное сообщение (сначала в Viber, если не вышло, то смс) с одинаковым текстом:

var message = new TurboSMS.Messages.Message
{
  Sender = this.Sender,
  Text = this.MessageText,
  Recipients = this.Recipients,
  Sms = new Sms(),
  Viber = new Viber()
};

MessageEngine engine = new MessageEngine(this.Token);
var result = engine.SendMessage(message);

4. Отправить гибридное сообщение (сначала в Viber, если не вышло, то смс) с разным текстом:

var message = new TurboSMS.Messages.Message
{
  Sender = this.Sender,
  Recipients = this.Recipients,
  Sms = new Sms{ Text = this.MessageText },
  Viber = new Viber{ Text = this.ViberText }
};

MessageEngine engine = new MessageEngine(this.Token);
var result = engine.SendMessage(message);

5. Посмотреть баланс:

UserEngine engine = new UserEngine(this.Token);
var result = engine.ReadBalance();

6. Отформатировать номер в формат 380ХХХХХХХХХ.

var formattedPhone = Helper.PreparePhoneNumber("(050) 123-45-67");

7. Получить список отформатированных телефонных номеров из строки:

var recipients = Helper.GetFormattedPhoneNumbersList("(050) 123-45-67\n 380971234567");

Весь код подробно документирован.
Истончик информации: https://turbosms.ua/api.html
