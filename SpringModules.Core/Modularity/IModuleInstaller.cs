using System.Reflection;
using Spring.Core.IO;
using Spring.Objects.Factory.Config;

namespace SpringModules.Core.Modularity
{
	public interface IModuleInstaller
	{
		/// <summary>
		/// zaregistruje do Spring IOC kontejneru embedded resource, file apod s XML spring objects definici
		/// </summary>
		/// <param name="resource"></param>
		void RegisterXmlResource(IResource resource);

		/// <summary>
		/// zaregistruje programove do Spring IOC kontejneru komponentu
		/// </summary>
		/// <param name="name"></param>
		/// <param name="objectDefinition"></param>
		void RegisterComponent(string name, IObjectDefinition objectDefinition);

		/// <summary>
		/// zaregistruje assembly pro nacteni NHibernate mappings
		/// </summary>
		/// <param name="assembly"></param>
		void RegisterNHibernateMappingsAssembly(Assembly assembly);
	}
}