using System;
using System.Collections.Generic;
using Spring.Context;
using Spring.Context.Support;

namespace SpringModules.Core.Modularity
{
	public class ModularApplicationContext: IModularApplicationContext
	{
		private readonly List<IModule> modules = new List<IModule>();

		public void AddModule(IModule module)
		{
			modules.Add(module);
		}

		public void Initialize()
		{
			if (Container != null)
			{
				throw new InvalidOperationException("ModularApplicationContext is already initialized - it looks like you tried to call Initialize() twice.");
			}

			var container = new GenericApplicationContext();
			var moduleInstaller = new ModuleInstaller(container);
			modules.ForEach(m => m.Install(moduleInstaller));
			
			container.Refresh();
			Container = container;
		}

		public IApplicationContext Container { get; private set; }
	}
}
