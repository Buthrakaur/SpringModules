using System;

namespace SampleModule.Time
{
	public class RealSystemTime : ISystemTime
	{
		public DateTime GetCurrentTime()
		{
			return DateTime.Now;
		}
	}
}
