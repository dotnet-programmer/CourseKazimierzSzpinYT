using System.Net;
using System.Net.Mail;

namespace EmailSender.Lib;

public class Email(EmailParams emailParams)
{
	private SmtpClient _smtpClient;
	private MailMessage _mailMessage;

	private readonly string _hostSmtp = emailParams.HostSmtp;
	private readonly bool _enableSsl = emailParams.EnableSsl;
	private readonly int _port = emailParams.Port;
	private readonly string _senderEmail = emailParams.SenderEmail;
	private readonly string _senderEmailPassword = emailParams.SenderEmailPassword;
	private readonly string _senderName = emailParams.SenderName;

	public async Task Send(string emailRecipient, string subject, string body)
	{
		_mailMessage = new()
		{
			From = new MailAddress(_senderEmail, _senderName)
		};
		_mailMessage.To.Add(new MailAddress(emailRecipient));
		_mailMessage.Subject = subject;
		_mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
		_mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
		_mailMessage.Body = body;

		_smtpClient = new()
		{
			Host = _hostSmtp,
			EnableSsl = _enableSsl,
			Port = _port,
			DeliveryMethod = SmtpDeliveryMethod.Network,
			UseDefaultCredentials = false,
			Credentials = new NetworkCredential(_senderEmail, _senderEmailPassword),
		};

		_smtpClient.SendCompleted += OnSendCompleted;
		await _smtpClient.SendMailAsync(_mailMessage);
	}

	private void OnSendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
	{
		_smtpClient.Dispose();
		_mailMessage.Dispose();
	}
}