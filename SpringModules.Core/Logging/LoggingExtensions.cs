using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Logging;

namespace SpringModules.Core.Logging
{
	public static class LoggingExtensions
	{
		private static ILog GetLogger(Type type)
		{
			return LogManager.GetLogger(type);
		}

		public static void Warn(this object context, string message, Exception exception = null)
		{
			var log = GetLogger(context.GetType());
			if (exception != null)
			{
				log.Warn(message, exception);
			}
			else
			{
				log.Warn(message);
			}
		}
	}
}
