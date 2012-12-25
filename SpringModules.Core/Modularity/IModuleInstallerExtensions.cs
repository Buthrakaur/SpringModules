using System.Collections.Generic;
using Spring.Objects.Factory.Config;
using Spring.Objects.Factory.Support;

namespace SpringModules.Core.Modularity
{
	public static class IModuleInstallerExtensions
	{
		public static void RegisterSingleton<TService>(this IModuleInstaller moduleInstaller, IEnumerable<KeyValuePair<string, object>> ctorArgs = null)
		{
			var serviceType = typeof(TService);

			var constructorArgumentValues = new ConstructorArgumentValues();
			if (ctorArgs != null)
			{
				foreach (var kv in ctorArgs)
				{
					constructorArgumentValues.AddNamedArgumentValue(kv.Key, kv.Value);
				}
			}

			moduleInstaller.RegisterComponent(serviceType.FullName,
											  new GenericObjectDefinition
												  {
													  IsSingleton = true,
													  AutowireMode = AutoWiringMode.Constructor,
													  ObjectType = serviceType,
													  ConstructorArgumentValues = constructorArgumentValues
												  });
		}
	}
}
