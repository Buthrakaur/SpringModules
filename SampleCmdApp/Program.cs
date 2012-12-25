﻿using System;
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
			if (objects.Count != 1)
			{
				throw new SystemException("ISystemTime component not properly registered");
			}

			var systemTime = (ISystemTime)objects.Values.Cast<object>().Single();

			Console.Out.WriteLine("Current time is: " + systemTime.GetCurrentTime());
			Console.Out.WriteLine("press any key to continue");
			Console.In.Read();
		}
	}
}