using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpringModules.Core.Modularity;

namespace SampleModule.Two
{
	public class Module : IModule
	{
		public void Install(IModuleInstaller installer)
		{
			installer.RegisterSingleton<FixedSystemTime>(new Dictionary<string, object> { { "fixedTime", new DateTime(2001, 2, 3, 4, 5, 6) } });
		}
	}
}
