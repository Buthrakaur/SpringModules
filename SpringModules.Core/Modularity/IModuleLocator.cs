using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringModules.Core.Modularity
{
	public interface IModuleLocator
	{
		IEnumerable<IModule> GetModules();
	}
}
