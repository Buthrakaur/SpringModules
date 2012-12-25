using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleModule.Time;
using Spring.Core.IO;
using Spring.Objects.Factory.Support;
using SpringModules.Core.Modularity;

namespace SampleModule
{
	public class Module: IModule
	{
		public void Install(IModuleInstaller installer)
		{
			installer.RegisterXmlResource(this.ThisAssemblyResource("SampleModule.Time", "objects.xml"));
			installer.RegisterComponent("x", new GenericObjectDefinition
				{
					IsSingleton = true,
					ObjectType = typeof(RandomSystemTime)
				});
		}
	}
}
