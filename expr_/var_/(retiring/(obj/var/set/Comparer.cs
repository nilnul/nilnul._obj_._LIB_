using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.obj.var.set
{
	public class Comparer : IComparer<obj.var.Set>
	{
		public int Compare(Set x, Set y)
		{
			//order vars by their names.

			var allVars = new Set();

			allVars.UnionWith(x);
			allVars.UnionWith(y);

			//get all the names.

			//x.OrderBy( a=>a, nilnul.obj.var.comparer_.FroNaming.Lazy );


			

			throw new NotImplementedException();

			//throw new NotImplementedException();
		}
	}
}
