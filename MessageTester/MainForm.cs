using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TurboSMS;
using TurboSMS.Messages;
using TurboSMS.Users;

namespace MessageTester
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private string Sender => textBoxSender.Text.Trim();

		private string MessageText => textBoxSms.Text.Trim();

		private List<string> Recipients => textBoxPhones.Text.Split(' ', '\n', '\r').Select(x => x.Trim()).ToList();

		private string Token => textBoxToken.Text.Trim();

		private void buttonSendMessage_Click(object sender, EventArgs e)
		{
			var message = new TurboSMS.Messages.Message
			{
				Sender = this.Sender,
				Text = this.MessageText,
				Recipients = this.Recipients,
				Sms = new Sms()
			};
			
			MessageEngine engine = new MessageEngine(this.Token);

			var result = engine.SendMessage(message);

			MessageBox.Show(result?.FirstOrDefault()?.ResponseStatus ?? "Error");
		}

		private void buttonBalance_Click(object sender, EventArgs e)
		{
			UserEngine engine = new UserEngine(this.Token);
			var result = engine.ReadBalance();

			if (result != null)
				labelBalance.Text = result.Balance.ToString(CultureInfo.InvariantCulture);
		}

		private void buttonPing_Click(object sender, EventArgs e)
		{
			UserEngine engine = new UserEngine(this.Token);
			bool result = engine.Ping();

			MessageBox.Show(result.ToString(CultureInfo.InvariantCulture));
		}

		private void buttonFormatNumber_Click(object sender, EventArgs e)
		{
			try
			{
				textBoxPhoneFormated.Text = Helper.PreparePhoneNumber(textBoxPhoneUnformated.Text);
			}
			catch (InvalidOperationException exception)
			{
				MessageBox.Show(exception.Message);
			}
		}
	}
}
