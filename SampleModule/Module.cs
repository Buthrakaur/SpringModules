using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Core.IO;
using SpringModules.Core.Modularity;

namespace SampleModule
{
	public class Module: IModule
	{
		public void Install(IModuleInstaller installer)
		{
			installer.RegisterXmlResource(new AssemblyResource("SampleModule/SampleModule.Time/objects.xml"));
		}
	}
}
