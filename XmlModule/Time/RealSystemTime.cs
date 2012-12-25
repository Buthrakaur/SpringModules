using System;

namespace XmlModule.Time
{
	public class RealSystemTime : ISystemTime
	{
		public DateTime GetCurrentTime()
		{
			return DateTime.Now;
		}
	}
}
