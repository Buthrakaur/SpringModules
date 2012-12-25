using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModule.Time
{
	public class RandomSystemTime: ISystemTime
	{
		private readonly Random random = new Random();
		private readonly long minTicks = DateTime.Now.AddYears(-10).Ticks;
		private readonly long maxTicks = DateTime.Now.AddYears(10).Ticks;

		public DateTime GetCurrentTime()
		{
			var ticksDiff = maxTicks - minTicks;
			var randomTicks = (long)(random.NextDouble()*ticksDiff);
			return new DateTime(minTicks + randomTicks);
		}
	}
}
