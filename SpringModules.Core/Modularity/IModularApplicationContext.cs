using Spring.Context;
using Spring.Context.Support;

namespace SpringModules.Core.Modularity
{
	public interface IModularApplicationContext
	{
		void AddModule(IModule module);
		void Initialize();
		void Initialize(AbstractApplicationContext existingContext);
		IApplicationContext Container { get; }
	}
}