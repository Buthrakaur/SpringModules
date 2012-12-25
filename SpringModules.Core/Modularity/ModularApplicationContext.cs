using System;
using System.Collections.Generic;
using Spring.Context;
using Spring.Context.Support;

namespace SpringModules.Core.Modularity
{
	public class ModularApplicationContext: IModularApplicationContext
	{
		private readonly List<IModule> modules = new List<IModule>();
		private bool isInitialized;

		public void AddModule(IModule module)
		{
			modules.Add(module);
		}

		public void Initialize()
		{
			var applicationContext = new GenericApplicationContext();
			Initialize(applicationContext);

			//kdyz vytvarime svuj vlastni kontext, tak je potreba refreshnout, aby se nacetly komponenty
			applicationContext.Refresh();
		}

		private readonly object initializeLock = new object();
		public void Initialize(AbstractApplicationContext existingContext)
		{
			lock (initializeLock)
			{
				if (isInitialized)
				{
					throw new InvalidOperationException("ModularApplicationContext is already initialized - it looks like you tried to call Initialize() twice.");
				}

				var moduleInstaller = new ModuleInstaller(existingContext);
				modules.ForEach(m => m.Install(moduleInstaller));

				Container = existingContext;
				isInitialized = true;
			}
		}

		public IApplicationContext Container { get; private set; }
	}
}
