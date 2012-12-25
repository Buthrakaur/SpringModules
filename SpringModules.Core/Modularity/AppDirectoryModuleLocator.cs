using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using SpringModules.Core.Logging;

namespace SpringModules.Core.Modularity
{
	public class AppDirectoryModuleLocator: IModuleLocator
	{
		public IEnumerable<IModule> GetModules()
		{
			return GetDirectoriesToSearch()
				.SelectMany(GetAssembliesInDirectory)
				.SelectMany(GetModulesFromAssembly)
				.ToArray();
		}

		private static IEnumerable<string> GetDirectoriesToSearch()
		{
			var applicationDir = GetApplicationBaseDirectory();
			yield return applicationDir;
			var webBinDir = Path.Combine(applicationDir, "bin");
			if (Directory.Exists(webBinDir))
			{
				yield return webBinDir;
			}
		}

		private static string GetApplicationBaseDirectory()
		{
			var codeBase = Assembly.GetExecutingAssembly().CodeBase;
			return Path.GetDirectoryName(new Uri(codeBase).LocalPath);
		}

		private IEnumerable<Assembly> GetAssembliesInDirectory(string dir)
		{
			var allAssemblyFiles = Directory.GetFiles(dir, "*.dll", SearchOption.TopDirectoryOnly)
			         .Concat(Directory.GetFiles(dir, "*.exe", SearchOption.TopDirectoryOnly));

			foreach (var file in allAssemblyFiles)
			{
				Assembly asm;
				try
				{
					asm = Assembly.LoadFrom(file);
				}
				catch (Exception ex)
				{
					this.Warn("Can't load assembly from file: " + file, ex);
					continue;
				}

				yield return asm;
			}
		}

		private IEnumerable<IModule> GetModulesFromAssembly(Assembly assembly)
		{
			var moduleTypes = assembly.GetTypes()
			                          .Where(t => typeof (IModule).IsAssignableFrom(t));
			foreach (var type in moduleTypes)
			{
				IModule module;

				try
				{
					module = (IModule)Activator.CreateInstance(type);
				}
				catch (Exception ex)
				{
					this.Warn("Can't load module from type: " + type.FullName, ex);
					continue;
				}

				yield return module;
			}
		}
	}
}