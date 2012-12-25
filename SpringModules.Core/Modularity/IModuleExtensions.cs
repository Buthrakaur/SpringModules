using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Core.IO;

namespace SpringModules.Core.Modularity
{
	public static class IModuleExtensions
	{
		public static AssemblyResource ThisAssemblyResource(this IModule module, string nameSpace, string fileName)
		{
			var assemblyName = module.GetType().Assembly.GetName().Name;
			return new AssemblyResource(string.Format("{0}/{1}/{2}", assemblyName, nameSpace, fileName));
		}
	}
}
