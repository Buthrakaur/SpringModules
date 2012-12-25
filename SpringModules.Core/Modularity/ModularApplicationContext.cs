using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SpringModules.Core.Modularity
{
	public class ModularApplicationContext: IModularApplicationContext
	{
		public void AddModule(IModule module)
		{
			throw new NotImplementedException();
		}

		public void Initialize()
		{
			throw new NotImplementedException();
			//all modules .Install()
		}
	}
}
