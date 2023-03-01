using System;
namespace Singleton
{
	public class Logger
	{
		private static readonly Lazy<Logger> _lazy = new Lazy<Logger>(() => new Logger());

		//private static Logger? _instance;
		public static Logger Instance
		{
			get => _lazy.Value;
			//get
			//{
			//	if (_instance == null)
			//	{
			//		_instance = new Logger();
			//	}

			//	return _instance;
			//}
		}

		private Logger()
		{
		}

		public void Log(string logMessage) => Console.Write($"You Logged: {logMessage}");
	}
}

