using System.Reflection;
using Spring.Context;
using Spring.Context.Support;
using Spring.Core.IO;
using Spring.Objects.Factory.Config;
using Spring.Objects.Factory.Xml;

namespace SpringModules.Core.Modularity
{
	public class ModuleInstaller: IModuleInstaller
	{
		private readonly AbstractApplicationContext container;
		private readonly XmlObjectDefinitionReader xmlReader;

		public ModuleInstaller(AbstractApplicationContext container)
		{
			this.container = container;
			xmlReader = new XmlObjectDefinitionReader(container);
		}

		public void RegisterXmlResource(IResource resource)
		{
			xmlReader.LoadObjectDefinitions(resource);
		}

		public void RegisterComponent(string name, IObjectDefinition objectDefinition)
		{
			container.RegisterObjectDefinition(name, objectDefinition);
		}

		public void RegisterNHibernateMappingsAssembly(Assembly assembly)
		{
			throw new System.NotImplementedException();
		}
	}
}