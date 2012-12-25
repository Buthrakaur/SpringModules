using Spring.Objects.Factory.Config;
using Spring.Objects.Factory.Support;

namespace SpringModules.Core.Modularity
{
	public static class IModuleInstallerExtensions
	{
		public static void RegisterSingleton<TService>(this IModuleInstaller moduleInstaller)
		{
			var serviceType = typeof(TService);
			moduleInstaller.RegisterComponent(serviceType.FullName,
											  new GenericObjectDefinition
												  {
													  IsSingleton = true,
													  AutowireMode = AutoWiringMode.Constructor,
													  ObjectType = serviceType
												  });
		}
	}
}
