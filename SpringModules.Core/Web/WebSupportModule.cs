using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context.Support;
using SpringModules.Core.Modularity;

namespace SpringModules.Core.Web
{
	public class WebSupportModule: Spring.Context.Support.WebSupportModule
	{
		public override void Init(System.Web.HttpApplication app)
		{
			base.Init(app);

			var applicationContext = WebApplicationContext.GetRootContext() as AbstractApplicationContext;

			var ctx = new ModularApplicationContext();
			foreach (var module in new AppDirectoryModuleLocator().GetModules())
			{
				ctx.AddModule(module);
			}
			ctx.Initialize(applicationContext);
		}
	}
}
