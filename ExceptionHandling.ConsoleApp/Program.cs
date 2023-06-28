internal class Program
{
	private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

	private static void Main(string[] args)
	{
		try
		{
			_logger.Info("Application started...");
			new EmailSender().Send();
		}
		catch (Exception exception)
		{
			_logger.Error(exception);
			Console.WriteLine("Nie udało się wysłać maila.");
		}
		finally
		{
			_logger.Info("Application stopped...");
		}

		// global exception handling in console app
		//AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
		//static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
		//{
		//	//Logger.Error(e.ExceptionObject);
		//	Console.WriteLine("Error!");
		//	Environment.Exit(1);
		//}
	}
}

public class EmailSender
{
	// without error handling
	//public void Send()
	//{
	//	new HostSmtp().Connect();
	//}

	// worst solution, catch without code
	//public void Send()
	//{
	//	try
	//	{
	//		new HostSmtp().Connect();
	//	}
	//	catch (Exception)
	//	{
	//	}
	//}

	// log error to file
	//public void Send()
	//{
	//	try
	//	{
	//		new HostSmtp().Connect();
	//	}
	//	catch (Exception exception)
	//	{
	//		//Logger.Error("Additional information", exception);
	//	}
	//}

	// log error to file with throw exception, lost info about stack trace
	//public void Send()
	//{
	//	try
	//	{
	//		new HostSmtp().Connect();
	//	}
	//	catch (Exception exception)
	//	{
	//		//Logger.Error("Additional information", exception);
	//		throw exception;
	//	}
	//}

	// log error to file with throw new exception, lost info about stack trace
	//public void Send()
	//{
	//	try
	//	{
	//		new HostSmtp().Connect();
	//	}
	//	catch (Exception exception)
	//	{
	//		//Logger.Error("Additional information", exception);
	//		throw new Exception("Info about Exception");
	//	}
	//}

	// log error to file with throw with info about stack trace - the right way to handle exceptions
	public void Send()
	{
		try
		{
			new HostSmtp().Connect();
		}
		catch (Exception exception)
		{
			//Logger.Error("Additional information", exception);
			throw;
		}
	}

	// log error to file with throw new exception with exception with info about stack trace - the right way to handle exceptions
	//public void Send()
	//{
	//	try
	//	{
	//		new HostSmtp().Connect();
	//	}
	//	catch (Exception exception)
	//	{
	//		//Logger.Error("Additional information", exception);
	//		throw new Exception("Some exception", exception);
	//	}
	//}
}

public class HostSmtp
{
	public void Connect() => throw new Exception("Cannot connect.");
}