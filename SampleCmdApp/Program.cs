using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleModule;
using SampleModule.Time;
using SpringModules.Core.Modularity;

namespace SampleCmdApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var ctx = new ModularApplicationContext();
			ctx.AddModule(new Module());
			ctx.Initialize();

			var objects = ctx.Container.GetObjectsOfType(typeof (ISystemTime));
			if (objects.Count == 0)
			{
				throw new SystemException("ISystemTime component not properly registered");
			}

			foreach (var time in objects.Values.Cast<ISystemTime>())
			{
				Console.Out.WriteLine(time.GetType().FullName + " time is: " + time.GetCurrentTime());
			
			}

			Console.Out.WriteLine("press return to continue");
			Console.In.ReadLine();
		}
	}
}
