namespace MessageTester
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxToken = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPhones = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxSms = new System.Windows.Forms.TextBox();
			this.textBoxViber = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonSendMessage = new System.Windows.Forms.Button();
			this.buttonBalance = new System.Windows.Forms.Button();
			this.labelBalance = new System.Windows.Forms.Label();
			this.textBoxSender = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonPing = new System.Windows.Forms.Button();
			this.textBoxPhoneFormated = new System.Windows.Forms.TextBox();
			this.textBoxPhoneUnformated = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonFormatNumber = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Токен:";
			// 
			// textBoxToken
			// 
			this.textBoxToken.Location = new System.Drawing.Point(93, 35);
			this.textBoxToken.Name = "textBoxToken";
			this.textBoxToken.Size = new System.Drawing.Size(340, 20);
			this.textBoxToken.TabIndex = 1;
			this.textBoxToken.Text = "593338494cd613db7bda39e9fdc954f77e8ab9ad";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Телефоны:";
			// 
			// textBoxPhones
			// 
			this.textBoxPhones.Location = new System.Drawing.Point(93, 88);
			this.textBoxPhones.Multiline = true;
			this.textBoxPhones.Name = "textBoxPhones";
			this.textBoxPhones.Size = new System.Drawing.Size(340, 59);
			this.textBoxPhones.TabIndex = 3;
			this.textBoxPhones.Text = "380977994896";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Смс:";
			// 
			// textBoxSms
			// 
			this.textBoxSms.Location = new System.Drawing.Point(93, 153);
			this.textBoxSms.Multiline = true;
			this.textBoxSms.Name = "textBoxSms";
			this.textBoxSms.Size = new System.Drawing.Size(340, 86);
			this.textBoxSms.TabIndex = 5;
			this.textBoxSms.Text = "Привет, Джайпхал!";
			// 
			// textBoxViber
			// 
			this.textBoxViber.Location = new System.Drawing.Point(93, 245);
			this.textBoxViber.Multiline = true;
			this.textBoxViber.Name = "textBoxViber";
			this.textBoxViber.Size = new System.Drawing.Size(340, 86);
			this.textBoxViber.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(53, 248);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Viber:";
			// 
			// buttonSendMessage
			// 
			this.buttonSendMessage.Location = new System.Drawing.Point(358, 337);
			this.buttonSendMessage.Name = "buttonSendMessage";
			this.buttonSendMessage.Size = new System.Drawing.Size(75, 23);
			this.buttonSendMessage.TabIndex = 8;
			this.buttonSendMessage.Text = "Отправить";
			this.buttonSendMessage.UseVisualStyleBackColor = true;
			this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
			// 
			// buttonBalance
			// 
			this.buttonBalance.Location = new System.Drawing.Point(93, 366);
			this.buttonBalance.Name = "buttonBalance";
			this.buttonBalance.Size = new System.Drawing.Size(340, 23);
			this.buttonBalance.TabIndex = 9;
			this.buttonBalance.Text = "Посмотреть баланс";
			this.buttonBalance.UseVisualStyleBackColor = true;
			this.buttonBalance.Click += new System.EventHandler(this.buttonBalance_Click);
			// 
			// labelBalance
			// 
			this.labelBalance.BackColor = System.Drawing.Color.Khaki;
			this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelBalance.Location = new System.Drawing.Point(93, 392);
			this.labelBalance.Name = "labelBalance";
			this.labelBalance.Size = new System.Drawing.Size(340, 29);
			this.labelBalance.TabIndex = 10;
			this.labelBalance.Text = "Нет данных";
			this.labelBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxSender
			// 
			this.textBoxSender.Location = new System.Drawing.Point(93, 62);
			this.textBoxSender.Name = "textBoxSender";
			this.textBoxSender.Size = new System.Drawing.Size(340, 20);
			this.textBoxSender.TabIndex = 11;
			this.textBoxSender.Text = "TAXI";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 65);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Отправитель:";
			// 
			// buttonPing
			// 
			this.buttonPing.Location = new System.Drawing.Point(93, 337);
			this.buttonPing.Name = "buttonPing";
			this.buttonPing.Size = new System.Drawing.Size(75, 23);
			this.buttonPing.TabIndex = 13;
			this.buttonPing.Text = "Ping";
			this.buttonPing.UseVisualStyleBackColor = true;
			this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
			// 
			// textBoxPhoneFormated
			// 
			this.textBoxPhoneFormated.Location = new System.Drawing.Point(222, 466);
			this.textBoxPhoneFormated.Name = "textBoxPhoneFormated";
			this.textBoxPhoneFormated.ReadOnly = true;
			this.textBoxPhoneFormated.Size = new System.Drawing.Size(211, 20);
			this.textBoxPhoneFormated.TabIndex = 16;
			// 
			// textBoxPhoneUnformated
			// 
			this.textBoxPhoneUnformated.Location = new System.Drawing.Point(222, 435);
			this.textBoxPhoneUnformated.Name = "textBoxPhoneUnformated";
			this.textBoxPhoneUnformated.Size = new System.Drawing.Size(211, 20);
			this.textBoxPhoneUnformated.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(93, 435);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 31);
			this.label7.TabIndex = 14;
			this.label7.Text = "Неформатированный номер телефона:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(93, 466);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 31);
			this.label5.TabIndex = 17;
			this.label5.Text = "Форматированный номер телефона:";
			// 
			// buttonFormatNumber
			// 
			this.buttonFormatNumber.Location = new System.Drawing.Point(270, 492);
			this.buttonFormatNumber.Name = "buttonFormatNumber";
			this.buttonFormatNumber.Size = new System.Drawing.Size(109, 23);
			this.buttonFormatNumber.TabIndex = 18;
			this.buttonFormatNumber.Text = "Форматировать";
			this.buttonFormatNumber.UseVisualStyleBackColor = true;
			this.buttonFormatNumber.Click += new System.EventHandler(this.buttonFormatNumber_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 526);
			this.Controls.Add(this.buttonFormatNumber);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxPhoneFormated);
			this.Controls.Add(this.textBoxPhoneUnformated);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.buttonPing);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxSender);
			this.Controls.Add(this.labelBalance);
			this.Controls.Add(this.buttonBalance);
			this.Controls.Add(this.buttonSendMessage);
			this.Controls.Add(this.textBoxViber);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxSms);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxPhones);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxToken);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Проверка библиотеки";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxToken;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPhones;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxSms;
		private System.Windows.Forms.TextBox textBoxViber;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonSendMessage;
		private System.Windows.Forms.Button buttonBalance;
		private System.Windows.Forms.Label labelBalance;
		private System.Windows.Forms.TextBox textBoxSender;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonPing;
		private System.Windows.Forms.TextBox textBoxPhoneFormated;
		private System.Windows.Forms.TextBox textBoxPhoneUnformated;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonFormatNumber;
	}
}

