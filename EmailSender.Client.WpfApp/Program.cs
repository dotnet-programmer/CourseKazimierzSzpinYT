using EmailSender.Lib;

Email email = new(new EmailParams
{
	HostSmtp = "smtp.gmail.com",
	Port = 587,
	EnableSsl = true,
	SenderName = "Marek Nowak",
	SenderEmail = "maildowysylki@gmail.com",
	SenderEmailPassword = "password",
});

Console.WriteLine("Wysyłanie e-maila...");

await email.Send("odbiorca@maila.com", "E-mail testowy z aplikacji", "Wysłano z aplikacji EmailSender!");

Console.WriteLine("Wysłano e-maila");