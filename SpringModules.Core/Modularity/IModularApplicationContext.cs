namespace SpringModules.Core.Modularity
{
	public interface IModularApplicationContext
	{
		void AddModule(IModule module);
		void Initialize();
	}
}