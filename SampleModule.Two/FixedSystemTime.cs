using System;
using SampleModule.Time;

namespace SampleModule.Two
{
	public class FixedSystemTime: ISystemTime
	{
		private readonly DateTime fixedTime;

		public FixedSystemTime(DateTime fixedTime)
		{
			this.fixedTime = fixedTime;
		}

		public DateTime GetCurrentTime()
		{
			return fixedTime;
		}
	}
}